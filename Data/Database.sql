/*
create database CoffeeShop 
go
*/ 

USE CoffeeShop 
go 

/*
Food 
TableFood 
FoodCategory 
Account 
Bill 
BillInfo 
*/ 

IF OBJECT_ID(N'TableFood', N'U') IS NULL
CREATE TABLE TableFood (
	id int identity primary key, 
	name NVARCHAR(100), 
	status NVARCHAR(100), 
	isDeleted int
)
go 

