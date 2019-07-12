/* Join 3 tables
product + (supplier) company name + (CAtegory ) categoryname (ie category of supplier) */

select ProductID, ProductName, CompanyName as Supplier, c.CategoryID, CategoryName From Products
Inner Join Suppliers s on products.SupplierID = s.SupplierID
Inner Join Categories c on c.CategoryID = Products.CategoryID
