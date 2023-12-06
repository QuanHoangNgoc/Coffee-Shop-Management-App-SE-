
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


/*select userName as N'Tên ðãng nh?p', 
	displayName as N'Tên hi?n th?', 
	type as N'Admin' 
	from dbo.Account where dbo.Account.isDeleted = 0; 
go*/ 


/*
select * 
from dbo.Account
where (
	isDeleted = 0 and 
	username like N'quanhn' and
	password like N'123456789' 
) 
*/ 


/* 
select * 
from dbo.Account 
where isDeleted = 0; 

declare @i int = 0 
while @i <= 10 
begin 
	insert dbo.TableFood (name) values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1 
end 
go 
*/ 


/*
select * from dbo.TableFood
go 

update dbo.TableFood set status = N'Có ngý?i' where id = 1
go 
*/


select * from dbo.TableFood
go 

