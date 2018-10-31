create database bookStore
use bookStore

create table UserTable
(
id int primary key identity(1,1),
userName varchar(50),
email varchar(50),
userPassword varchar(50),
userType varchar(50)
)

create table Item
(
itemId int primary key identity(1,1),
isbn int,
itemName nvarchar(20),
publishDate date,
price float,
copyNumber int,
topic nvarchar(20),
category nvarchar(20),
stock int
)

create table Book
(
bookId int primary key identity(1,1),
isbn int,
itemName nvarchar(20),
publishDate date,
price float,
copyNumber int,
topic nvarchar(20),
category nvarchar(20),
stock int,
edition int
)

create table Journal
(
journalId int primary key identity(1,1),
isbn int,
itemName nvarchar(20),
publishDate date,
price float,
copyNumber int,
topic nvarchar(20),
category nvarchar(20),
stock int,
volume nvarchar(20)
)

create table Purchase
(
purchaseId int primary key identity(1,1),
customerName nvarchar(20),
itemName varchar(50),
itemPrice float,
quantity int,
purchaseDate date
)

--create table Book
--(
--itemId int foreign key references Item(itemId),
--edition varchar(20) 
--)

select top 1 itemId from Item where isbn=321 ORDER BY itemId DESC

select*from UserTable
update Book set stock=3 where bookId=2
delete from Purchase where purchaseId=3
select userType from UserTable where email='ss'

select * from userTable
if exists (select * from UserTable d where d.email = 'rr')
if not exists (select * from UserTable d where d.email = 'rr') select * from UserTable
insert into UserTable values('sas', 'rr', '1', 'employee')

insert into Book values(123, 'b5', '2010-10-01', 5.5, 6, 'fdfd', 'books', 8, 4)

delete from UserTable

delete from Item where id=3 and isbn=123

SELECT * from UserTable WHERE email = 'a';

select case when count(distinct email)= count(email)
then 'column values are unique' else 'column values are NOT unique' end
from UserTable;

ALTER TABLE Customer
ALTER column itemPrice float
GO