-- Insert Brands
INSERT INTO [dbo].[Brands] ([Name])
VALUES 
('Starbucks'),
('Dunkin'' Donuts'),
('Peet''s Coffee'),
('Lavazza'),
('Nespresso');

-- Insert Users
INSERT INTO [dbo].[Users] ([Username], [Password])
VALUES 
('user1', 'password'),
('user2', 'password'),
('user3', 'password'),
('user4', 'password'),
('user5', 'password');

-- Insert Coffees
INSERT INTO [dbo].[Coffees] ([Name], [BrandId])
VALUES 
('Espresso', 1),
('Americano', 1),
('Latte', 2),
('Cappuccino', 2),
('Cold Brew', 3),
('French Roast', 3),
('Italian Roast', 4),
('Arabica', 4),
('Mocha', 5),
('Vanilla Latte', 5);

-- Insert Reviews
INSERT INTO [dbo].[Reviews] ([Content], [UserId], [CoffeeId])
VALUES 
('Great coffee, strong flavor!', 1, 1),
('A bit too bitter for my taste.', 2, 1),
('Smooth and rich, loved it!', 3, 2),
('Not bad, but I''ve had better.', 4, 2),
('Refreshing and perfect for summer.', 1, 3),
('Tastes amazing with a splash of milk.', 2, 3),
('Too acidic for me.', 5, 4),
('Perfectly balanced and smooth.', 3, 4),
('A must-try for coffee enthusiasts.', 4, 5),
('Not my favorite, but still decent.', 1, 5),
('Rich and bold.', 2, 6),
('Too dark for my liking.', 3, 6),
('Love the smokiness!', 4, 7),
('A classic I always enjoy.', 5, 7),
('Delightful and aromatic.', 1, 8),
('Could use a stronger flavor.', 2, 8),
('Great with dessert!', 3, 9),
('Perfect for a sweet tooth.', 4, 9),
('Overly sweet for me.', 5, 10),
('Smooth and creamy.', 1, 10);
