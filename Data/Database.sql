
--create database CoffeeShop 
--go

USE [master]
go 

drop database if exists CoffeeShop
go 

create database CoffeeShop 
go

USE [CoffeeShop] 
go 

--Table 
CREATE TABLE [TableFood] (
	[id] int identity primary key, 
	[name] NVARCHAR(100) not null default 'Noname', 
	[status] NVARCHAR(100) not null default 'Empty', 
	[isDeleted] int default 0
)
go 

--Acount
create table [Account] (
	--[id] int identity primary key, 
	[userName] NVARCHAR(100) primary key, --# 
	[displayName] NVARCHAR(100) NOT NULL default 'Quan', 
	[password] NVARCHAR(1000) not null default '123456789', 
	[type] INT not null default 0, --0: staff, 1: admin 
	[isDeleted] int default 0, 
) 
go 

--Category 
create table [FoodCategory] (
	[id] int identity primary key, 
	[name] NVARCHAR(100) NOT NULL default 'Noname', 
	[isDeleted] int default 0, 
) 
go 

--Food 
create table [Food] (
	[id] int identity primary key, 
	[name] NVARCHAR(100) NOT NULL default 'Noname', 
	[idCategory] int not null, 
	[price] float not null default 0, 
	[isDeleted] int default 0, 

	foreign key (idCategory) references dbo.FoodCategory(id) 
) 
go 

--Bill 
create table [Bill] (
	[id] int identity primary key, 
	[dateCheckIn] date NOT NULL default getdate(), 
	[dateCheckOut] date, 
	[idTable] int not null, 
	[status] int not null default 0, -- 0: no payment 
	[isDeleted] int default 0, 

	foreign key (idTable) references dbo.TableFood(id) 
) 
go 

--BillInfo 
create table [BillInfo] (
	[id] int identity primary key, 
	[idBill] int NOT NULL, 
	[idFood] int not null, 
	[count] int not null default 0, 
	[isDeleted] int default 0, 

	foreign key (idBill) references dbo.Bill(id), 
	foreign key (idFood) references dbo.Food(id) 
) 
go 




