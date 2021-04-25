CREATE DATABASE FoodApp;

USE FoodApp;

CREATE TABLE Category(
	CategoryId BIGINT Identity(1,1) PRIMARY KEY,
	CategoryName VARCHAR(50) NOT NULL
);

INSERT INTO Category(CategoryName) VALUES('Starter');
INSERT INTO Category(CategoryName) VALUES('Breakfast');
INSERT INTO Category(CategoryName) VALUES('Lunch');
INSERT INTO Category(CategoryName) VALUES('Dinner');
INSERT INTO Category(CategoryName) VALUES('Desserts');
INSERT INTO Category(CategoryName) VALUES('Appetizers');
INSERT INTO Category(CategoryName) VALUES('Salads');
INSERT INTO Category(CategoryName) VALUES('Pizza');

SELECT * FROM Category;

CREATE TABLE Menu(
	MenuId BIGINT IDENTITY(1,1) PRIMARY KEY, 
	ItemName VARCHAR(100) NOT NULL,
	Price DECIMAL(5,2) NOT NULL,
	ItemDescription VARCHAR(MAX) NOT NULL,
	CategoryId BIGINT NOT NULL, 
	ItemImage Image,
	FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId) ON DELETE NO ACTION ON UPDATE NO ACTION,
);

INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Honey Glazed Onion Rings', 5.99, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 1);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Smoked Chicken Quesadilla', 8.99, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 1);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Ancho Chilli Shrimp Tacos', 20.58, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 1);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Loaded Fries', 12.32, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 1);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Bingsu', 13.54, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 5);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Antipasti', 21.32, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 1);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Breakfast Burrito', 31.2, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 2);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Kesar Pista Phirni', 43.2, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 5);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Sweatcorn Pies', 19.3, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 2);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Rasmalai Tiramisu', 12.43, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 5);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Nachos', 21.1, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 2);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Mexican Green Wave', 43.1, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 8);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Blueberry Cake', 32.1, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 2);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Hearty Muffins', 12.2, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 2);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Veg Extravaganza', 23.1, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 8);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('French Puffs', 14.23, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 8);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Masala Bhindi', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Margherita', 31.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 8);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Chana Kulcha', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Pasta Slad', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 7);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Gujrati Kadhi', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Rainbow Osto Salad', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 7);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Dahi Chicken', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Mix Vegetables', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Shahi Panner', 21.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);
INSERT INTO Menu(ItemName, Price, ItemDescription, CategoryId) VALUES('Dal Makhani', 15.4, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos nihil cupiditate ut vero alias quaerat inventore molestias vel suscipit explicabo.', 3);

SELECT * FROM Menu;

DELETE FROM Menu
WHERE MenuId > 26

UPDATE Menu
SET ItemImage = (
	SELECT BulkColumn 
	FROM Openrowset( Bulk 'E:\dotnet\Food Ordering App\FoodAppMain\wwwroot\images\gallery_1.jpg', Single_Blob) as img
)
WHERE MenuId In (9,14,19,24)

-- Image with datatype image wasn't workig
ALTER TABLE Menu 
DROP COLUMN ItemImage

-- Added a new column of type NVARCHAR(100)
ALTER TABLE Menu ADD ItemImage NVARCHAR(100);

UPDATE Menu
SET ItemImage = 'gallery_7212108506.jpg'
WHERE ItemImage='gallery_8212336399.jpg'


CREATE TABLE ReservationDetails(
	ReservationId BIGINT IDENTITY(1,2) PRIMARY KEY,
	CustomerName VARCHAR(100) NOT NULL,
	NumberOfCustomers INT NOT NULL,
	ReservationDate DATE NOT NULL,
);

SELECT * FROM ReservationDetails

CREATE TABLE [User](
	UserId BIGINT IDENTITY(1,1) PRIMARY KEY,
	UserEmail VARCHAR(100) NOT NULL,
	[Password] VARCHAR(100) NOT NULL
);

INSERT INTO [User](UserEmail, [Password]) VALUES('vermadimple1702@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('mahigill1708@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('klaus_tvd@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('gilbert.elena@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('candice123@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('himalyasharma@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('honey4u@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('preeti786@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('kaurhk05@yopmail.com', 'Abc@1234u');
INSERT INTO [User](UserEmail, [Password]) VALUES('singla_bhavish@yopmail.com', 'Abc@1234u');

SELECT * FROM [User];
SELECT * FROM Menu;

Update Menu
SET ItemName = 'Smoked Chicken' 
WHERE MenuId = 2


CREATE TABLE OrderHistory(
	OrderHistoryId BIGINT IDENTITY(1,1) PRIMARY KEY,
	UserId BIGINT NOT NULL,
	MenuId BIGINT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES [User](UserId) ON DELETE NO ACTION ON UPDATE NO ACTION,
	FOREIGN KEY (MenuId) REFERENCES Menu(MenuId) ON DELETE NO ACTION ON UPDATE NO ACTION,
);


INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,2);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,3);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(9,2);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(4,5);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(9,24);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(7,21);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,5);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,15);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,10);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(4,5);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(9,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(5,25);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(5,20);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,19);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,13);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,25);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,16);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,8);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,14);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,20);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(8,15);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(8,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(9,19);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(10,20);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(10,3);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(2,10);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,12);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,21);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(1,1);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,8);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(4,9);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(5,9);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(6,9);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(7,9);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(8,9);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,13);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,8);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(3,25);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(4,25);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(6,6);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(6,18);
INSERT INTO OrderHistory(UserId, MenuId) VALUES(6,25);


SELECT * FROM OrderHistory
WHERE UserId = 1
GO;

DELETE FROM OrderHistory
WHERE OrderHistoryId IN(31, 32, 33, 34, 35, 46, 47, 48, 52)

Alter PROCEDURE [dbo].[spGetMenuCategoryDetailById](
	@menuId BIGINT
)
AS 
BEGIN
	SELECT m.MenuId, m.Price, m.ItemName, m.ItemImage, m.ItemDescription, c.CategoryName
	FROM Menu m
	INNER JOIN Category c 
	ON m.CategoryId = c.CategoryId
	WHERE m.MenuId = @menuId

END
GO;

EXECUTE [dbo].[spGetMenuCategoryDetailById] @menuId = 2

CREATE TABLE PaymentDetails(
	PaymentDetailsId BIGINT IDENTITY(1,1) PRIMARY KEY,
	UserId BIGINT NOT NULL,
	UserEmailAddress VARCHAR(100) NOT NULL,
	UserResidenceAddress VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(100) NOT NULL,
	PaymentMethod VARCHAR(100) NOT NULL,

	FOREIGN KEY (UserId) REFERENCES [User](UserId) ON DELETE NO ACTION ON UPDATE NO ACTION
);


SELECT * FROM PaymentDetails
GO;

ALTER PROCEDURE [dbo].[spGetOrderHistoryById](
	@userId BIGINT
)
AS
BEGIN
	SELECT m.MenuId, u.UserId, m.ItemName, m.ItemImage, m.Price, m.ItemDescription, c.CategoryName, oh.OrderDateTime
	FROM OrderHistory oh
	INNER JOIN Menu m ON oh.MenuId = m.MenuId
	INNER JOIN [User] u ON oh.UserId = u.UserId
	INNER JOIN Category c ON m.CategoryId = c.CategoryId
	WHERE u.UserId = @userId
	ORDER BY oh.OrderDateTime
END

[dbo].[spGetOrderHistoryById] 1
GO;

-- Pagination on Menu
ALTER PROCEDURE [dbo].[spMenuPagination](
	@PageNumber INT,
	@PageSize INT
)
AS 
BEGIN
	SELECT *
	FROM Menu
	ORDER BY MenuId
	OFFSET (@PageNumber - 1)*@PageSize  ROWS
	FETCH NEXT @PageSize ROWS ONLY
END
GO;

[dbo].[spMenuPagination] 4,5

-- Adding column OrderDateTime in OrderHistory
ALTER TABLE OrderHistory
ADD OrderDateTime DATETIME
DEFAULT(GETUTCDATE())
WITH VALUES;

-- adding column UserRole in user table for authentication purpose
ALTER TABLE [User]
ADD UserRole INT
DEFAULT(0)
WITH VALUES;

SELECT * FROM [User];

UPDATE [User]
SET UserRole = 1
WHERE UserId = 1











