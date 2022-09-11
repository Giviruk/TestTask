# Создание таблицы продуктов

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

# Заполнение продуктов
INSERT INTO Products
VALUES
	(1, 'PRODUCT 1'),
	(2, 'PRODUCT 2'),
	(3, 'PRODUCT 3'),
	(4, 'PRODUCT 4'),
	(5, 'PRODUCT 5');

# Создание таблицы категорий
CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

# Заполнение категорий
INSERT INTO Categories
VALUES
	(1, 'Books'),
	(2, 'Furniture'),
	(3, 'Technic');

# Создание таблицы связей
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

# Заполнение таблицы связей
INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 2),
	(2, 3),
	(2, 4);

# Запрос
SELECT Prod."Name", Cat."Name" FROM Products Prod
    LEFT JOIN ProductCategories ProdCat ON Prod.Id = ProdCat.ProductId
    LEFT JOIN Categories Cat ON ProdCat.CategoryId = Cat.Id;
