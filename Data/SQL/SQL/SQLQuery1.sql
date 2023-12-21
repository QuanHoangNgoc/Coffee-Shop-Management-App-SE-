
--Hoang Ngoc Quan: 6/12/2023

use [CoffeeShop]
go 

/* 
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


use [CoffeeShop] 
go 


select userName as N'Tên ðãng nh?p', 
	displayName as N'Tên hi?n th?', 
	type as N'Admin' 
	from dbo.Account where dbo.Account.isDeleted = 0; 
go

select * 
from dbo.Account
where (
	isDeleted = 0 and 
	username like N'quanhn' and
	password like N'123456789' 
) 

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


select * from dbo.TableFood
go 

update dbo.TableFood set status = N'Có ngý?i' where id = 1
go 


select * from dbo.TableFood
go 

insert dbo.FoodCategory
([name])
values 
(N'Trà') 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'Trà xen vàng', 1, 39) 

select * from dbo.Food; 

insert dbo.FoodCategory 
([name])
values 
(N'Cà Phê Pha Phin') 

select * from dbo.Account; 
select * from dbo.FoodCategory; 
select * from dbo.Food; 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'Trà xanh ð?u ð?', 1, 40) 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'Trà th?ch ðào', 1, 55) 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'PHIN s?a ðá', 2, 29) 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'PHIN ðen ðá', 2, 35) 

insert dbo.Food
([name], [idCategory], [price]) 
values
(N'B?c x?u ðá', 2, 55) 

select * from dbo.FoodCategory; 
select * from dbo.Food; 
select * from dbo.Bill; 

insert dbo.Bill 
([idTable])
values
(1) 

insert dbo.Bill 
([idTable])
values
(2) 

insert dbo.Bill 
([idTable], [status])
values
(2, 1) 

insert dbo.BillInfo 
([idBill], [idFood], [count]) 
values 
(1, 1, 1) 

insert dbo.BillInfo 
([idBill], [idFood], [count]) 
values 
(1, 1, 1) 

insert dbo.BillInfo 
([idBill], [idFood], [count]) 
values 
(1, 2, 2) 

insert dbo.BillInfo 
([idBill], [idFood], [count]) 
values 
(2, 1, 3) 

insert dbo.BillInfo 
([idBill], [idFood], [count]) 
values 
(3, 3, 1) 
*/ 
--select * from dbo.Account; 
select * from dbo.FoodCategory; 
select * from dbo.Food; 
select * from dbo.Bill; 
select * from dbo.BillInfo; 

select 
	C.name as N'Tên món', 
	C.price as N'Giá', 
	B.count as N'S? lý?ng' 
from 
	((select * from dbo.Bill where (isDeleted = 0 and idTable = 1 and status = 0)) as A  
	join (select * from dbo.BillInfo where (isDeleted = 0)) as B 
	on (A.id = B.idBill))
		join (select * from dbo.Food where (isDeleted = 0)) as C 
		on (B.idFood = C.id)
go

select * from dbo.Account; 

select * from dbo.TableFood; 


















