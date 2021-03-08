Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City ='London'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID,ProductName

select * from Products where CategoryID=1 order by UnitPrice asc  --Artan sırayla
--desc  azalan sırayla

select count(*) from Products   -- satir sayisini verir.

select count(*) Adet from Products where CategoryID=2 --colon adi=Adet 

select CategoryID from Products group by CategoryID

select CategoryID,count(*) from Products group by CategoryID 

select CategoryID,count(*) from Products 
group by CategoryID having count(*)<10


select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName --goruntulenecek tablolar
from Products inner join Categories --categoriler ve urunlerin bir araya getirilmesi
on Products.CategoryID = Categories.CategoryID  --hangi kosulda bir araya getirilecegi on ile yazilir.
where Products.UnitPrice>10

--DTO = Data Transformation Object

select * from Products p inner join[Order Details] od  --kısaltma adlar ve order detail dosyanin adi ayri yaziligi için 
on p.ProductID = od.ProductID

select * from Products p left join[Order Details] od  --products ile order detailste ortak olanlari al ve productsi komple al
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --null olanlari gosterir.