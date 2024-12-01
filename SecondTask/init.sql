IF OBJECT_ID('ProductCategories') IS NOT NULL
  DROP TABLE ProductCategories;
IF OBJECT_ID('Products') IS NOT NULL
  DROP TABLE Products;
IF OBJECT_ID('Categories') IS NOT NULL
  DROP TABLE Categories;

CREATE TABLE Products
(
    id INT PRIMARY KEY IDENTITY,
    title VARCHAR(100) NOT NULL
);

CREATE TABLE Categories
(
    id INT PRIMARY KEY IDENTITY,
    title VARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories
(
	id INT PRIMARY KEY IDENTITY,
    productId INT NOT NULL,
    categoryId INT NOT NULL,
    CONSTRAINT FK_ProductCategory_To_Product FOREIGN KEY (productId) REFERENCES Products (id),
    CONSTRAINT FK_ProductCategory_To_Category FOREIGN KEY (categoryId) REFERENCES Categories (id),
);

INSERT Categories(title)
VALUES 
('Овощи'),
('Сладости');

INSERT Products(title)
VALUES 
('Картошка'),
('Тетрадь');

INSERT ProductCategories(productId, categoryId)
VALUES 
(1, 1),
(1, 2);