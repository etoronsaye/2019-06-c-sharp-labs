-- select * from Customers
-- select CustomerID, CompanyName, Address + ', ' + City + ', ' + Country as Location from Customers where City in ('Paris','London')
-- select * from Products where QuantityPerUnit LIKE '%bottle%'
-- select p.ProductName, s.CompanyName, s.Country from Products p Inner Join Suppliers s on p.SupplierID = s.SupplierID where QuantityPerUnit LIKE '%bottle%'
-- select c.CategoryName, COUNT(*) as TotalProducts from Products p Inner Join Categories c on p.CategoryID = c.CategoryID group by c.CategoryName order by TotalProducts desc
-- select TitleOfCourtesy + ' ' + FirstName + ' ' + LastName as Name, City from Employees
/* select r.RegionDescription, FORMAT (SUM(unitPrice * Quantity), '#,###,###') as SalesTotal from [Order Details] od Inner Join Orders o on od.OrderID = o.OrderID Inner Join EmployeeTerritories e on o.EmployeeID = e.EmployeeID
Inner Join Territories t on e.TerritoryID = t.TerritoryID Inner Join Region r on t.RegionID = r.RegionID group by r.RegionDescription having SUM(unitPrice * Quantity) > 1000000 */
-- select COUNT(*) as Freight100Up from Orders  where ShipCountry in ('USA', 'UK') and Freight > 100.00 
-- select TOP 2 OrderID, (Discount * UnitPrice * Quantity) as DiscountAmount from [Order Details] Order By DiscountAmount desc
-- select EmployeeID, FirstName + ' ' + LastName as Name, ReportsTo from Employees
-- select * from [Order Details]
/* select s.CompanyName, FORMAT(SUM(od.UnitPrice * od.Quantity), '#,###,###') as SalesTotal from [Order Details] od 
Inner Join Products p on od.ProductID = p.ProductID Inner Join Suppliers s on p.SupplierID = s.SupplierID group by s.CompanyName 
having SUM(od.UnitPrice * od.Quantity) > 10000  order by SUM(od.UnitPrice * od.Quantity) desc */

/* select top 10 c.ContactName,COUNT(*) 'total order' from Orders o inner join Customers c on o.CustomerID = c.CustomerID where YEAR(OrderDate) = 1998 
group by c.ContactName order by COUNT(*) desc */

--Plot the Average Ship Time by month for all data in the Orders Table
  
/*Select  CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + right('00' + CAST(MONTH(OrderDate) AS VARCHAR(2)), 2) as 'MonthYear', 
AVG(DATEDIFF( DAY, OrderDate, ShippedDate)) as 'Ship Time' 
from orders group by  CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + right('00' + CAST(MONTH(OrderDate) AS VARCHAR(2)), 2) order By MonthYear asc*/

---- NEW TEST


  