
--Hoang Ngoc Quan: 6/12/2023

/* 
use [CoffeeShop]
go 


insert into dbo.Account
(
	[userName], [displayName], [password], [type]
)
values
(
	N'quanhn', N'Hoang Ngoc Quan', N'123456789', 1
)
go 


insert into dbo.Account
(
	[userName], [displayName], [password], [type]
)
values
(
	N'quanhn2', N'Hoang Ngoc Quan', N'123456789', 0
)
go 
*/ 

use [CoffeeShop] 
go 
select userName as N'Tên ðãng nh?p', 
	displayName as N'Tên hi?n th?', 
	type as N'Admin' 
	from dbo.Account where dbo.Account.isDeleted = 0; 
go 



