using AutoMapper;
using CoffeeReviewBackend.Data;
using CoffeeReviewBackend.Dto;
using CoffeeReviewBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeReviewBackend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {

        private readonly CoffeeDbContext _context;
        private readonly IMapper _mapper;

        public CoffeeController(CoffeeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coffee>>> GetCoffees()
        { 
            IEnumerable<Coffee> FetchedCoffees = await _context.Coffees
                .Include(coffee => coffee.Brand)
                .Include(coffee => coffee.Reviews)
                .ToListAsync();

            var FetchedCoffeesDto = _mapper.Map<IEnumerable<CoffeeDto>>(FetchedCoffees);

            return Ok(FetchedCoffeesDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CoffeeDto>> GetCoffeeById(int id)
        {
            var FetchedCoffee = await _context.Coffees
                .Include(coffee => coffee.Brand)
                .FirstOrDefaultAsync(coffee => coffee.Id == id);

            if (FetchedCoffee == null)
                return NotFound();

            var FetchedCoffeeDto = _mapper.Map<CoffeeDto>(FetchedCoffee);

            return Ok(FetchedCoffeeDto);
        }

        [HttpPost]
        public async Task<ActionResult<CoffeeDto>> CreateCoffee(Coffee coffee)
        {
            _context.Coffees.Add(coffee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCoffees), new { id = coffee.Id }, _mapper.Map<CoffeeDto>(coffee));
        }


    }
}
