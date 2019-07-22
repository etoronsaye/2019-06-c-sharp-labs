-- SELECT CustomerID, CompanyName, address, city, postalCode, country FROM Customers WHERE city = 'Paris' OR city = 'London'

-- SELECT * FROM products WHERE QuantityPerUnit LIKE '%bottle%'

/* SELECT ProductName, suppliers.SupplierID, Suppliers.Country 
FROM products LEFT JOIN Suppliers ON products.supplierID = suppliers.supplierid where QuantityPerUnit LIKE '%bottle%' */

-- SELECT count(*), CategoryName FROM [Products by Category] GROUP BY categoryName

-- SELECT TitleOfCourtesy + FirstName + LastName, City FROM Employees WHERE country = 'UK'

-- SELECT * FROM orders WHERE freight > 100 AND (shipCountry = 'UK' OR shipCOuntry = 'USA')

-- SELECT top 1 (discount * UnitPrice * Quantity), OrderID FROM [Order Details] WHERE discount > 0 ORDER BY discount desc

/*DROP table SpartansTable
CREATE table SpartansTable(
ID INT PRIMARY KEY, Firstname VARCHAR(20), Surname VARCHAR(20), University VARCHAR(20), Course VARCHAR(40), Grade VARCHAR(3)

)
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(1,'sanru', 'mathy', 'cardiff', 'software engineering', '1st')
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(2,'Liam', 'russell', 'Northbrook MET', 'Game Dev', '2:1')
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(3,'Alex', 'johnson', 'brunel', 'Game design', '2:1')
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(4,'kieron', 'newman', 'UAL', 'Game design', '2:2')
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(5,'Sam', 'ige', 'swansea', 'chemical engineering', '2:1')
INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES(6,'Toby', 'soutir', 'MCGILL', 'Geology', '2:1')

select * from SpartansTable*/

-- select TitleOfCourtesy + FirstName + Lastname, ReportsTo from employees

/* SELECT suppliers.CompanyName,  SUM( [Order Details].UnitPrice * [Order Details].Quantity * (1-Discount)) AS total FROM [Order Details]  
JOIN products ON Products.ProductID = [Order Details].ProductID 
JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID  
GROUP BY CompanyName 
HAVING SUM( [Order Details].UnitPrice * [Order Details].Quantity ) > 10000 ORDER BY total desc */

-- select TOP 10 shipName,  COUNT(ShipName) as total from orders group by ShipName order by total desc

select  DAY(ShippedDate - orderDate) as Time, OrderDate from orders   order by MONTH(orderDate)