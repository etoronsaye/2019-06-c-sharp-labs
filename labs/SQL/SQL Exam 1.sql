-- Exercise 1
-- 1.1
select CustomerID, CompanyName, Address + ', ' + City + ', ' + Country as Location from Customers where City in ('Paris','London')
-- 1.2
select * from Products where QuantityPerUnit LIKE '%bottle%'
-- 1.3
select p.ProductName, s.CompanyName, s.Country from Products p Inner Join Suppliers s on p.SupplierID = s.SupplierID
where QuantityPerUnit LIKE '%bottle%'
-- 1.4
select c.CategoryName, COUNT(*) as TotalProducts from Products p
Inner Join Categories c on p.CategoryID = c.CategoryID group by c.CategoryName order by TotalProducts desc
-- 1.5
select TitleOfCourtesy + ' ' + FirstName + ' ' + LastName as Name, City from Employees
-- 1.6
select r.RegionDescription, FORMAT (SUM(unitPrice * Quantity), '#,###,###') as SalesTotal from [Order Details] od Inner Join Orders o on od.OrderID = o.OrderID Inner Join EmployeeTerritories e on o.EmployeeID = e.EmployeeID
Inner Join Territories t on e.TerritoryID = t.TerritoryID Inner Join Region r on t.RegionID = r.RegionID group by r.RegionDescription having SUM(unitPrice * Quantity) > 1000000 
-- 1.7
select COUNT(*) as Freight100Up from Orders  where ShipCountry in ('USA', 'UK') and Freight > 100.00 
-- 1.8
select TOP 2 OrderID, (Discount * UnitPrice * Quantity) as DiscountAmount from [Order Details] Order By DiscountAmount desc 


-- Exercise 2
-- 2.1
drop database if exists Exam
drop table if exists Spartans

create database Exam
create table Spartans(
	SpartanID int IDENTITY PRIMARY KEY,
	Title nvarchar(50),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	University nvarchar(100),
	Course nvarchar(50),
	Mark int
)

SET IDENTITY_INSERT Spartans ON
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (1, 'Dr.', 'Toby', 'Soutar', 'University Of Michigan', 'Geology', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (2, 'Pastor', 'Kyro', 'Newman', 'University of the Arts of London', 'Games Design', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (3, 'Dr.', 'Alex', 'Johnson', 'University of Brunel', 'Games Design', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (4, 'Fr.', 'Liam', 'Russell', 'University of College', 'Games Design', 2.1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (5, 'Miss.', 'Brooke', 'Harris', 'University of Westminster', 'Computing', 2.1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (6, 'Professor', 'Sam', 'Ige', 'University of Swansea', 'Chemical Engineering', 2.2);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (7, 'Eng.', 'Sanru', 'Mathybalan', 'University of Cardiff', 'Software Engineering', 2.2);
SET IDENTITY_INSERT Spartans OFF

select * from Spartans

-- Exercise 3
-- 3.1
select EmployeeID, FirstName + ' ' + LastName as Name, ReportsTo from Employees
-- 3.2
select s.CompanyName, FORMAT(SUM(od.UnitPrice * od.Quantity), '#,###,###') as SalesTotal from [Order Details] od Inner Join 
Products p on od.ProductID = p.ProductID Inner Join Suppliers s on p.SupplierID = s.SupplierID group by s.CompanyName 
having SUM(od.UnitPrice * od.Quantity) > 10000
-- 3.3
select top 10 c.ContactName, COUNT(*) 'total order' from Orders o inner join Customers c on o.CustomerID = c.CustomerID 
where YEAR(OrderDate) = 1998 group by c.ContactName order by COUNT(*) desc
-- 3.4
Select  CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + right('00' + CAST(MONTH(OrderDate) AS VARCHAR(2)), 2) as 'MonthYear', 
AVG(DATEDIFF( DAY, OrderDate, ShippedDate)) as 'Ship Time' 
from orders group by  CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + right('00' + CAST(MONTH(OrderDate) AS VARCHAR(2)), 2) order By MonthYear asc