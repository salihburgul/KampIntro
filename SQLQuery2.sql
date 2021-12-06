--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'
--case insensitive
Select * from Products where categoryId=1 or categoryId=3

Select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where cateoryıd=1 order by UnitPrice desc  --ascending(artan) --descendin(azalan)

select count(*) from Products where CategoryID=2

select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.Productname, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnıtPrice>10

--DTO Data Transformation object
--inner join eşleşmeyen datayı getirmez sadece eşleşenleri getirir
--köşeli parantez, boşluk sıkıtntı yaratmaması için kullanılır
--left solda olup sağda olmayanları listeler

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderId = od.OrderID

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerId is null



