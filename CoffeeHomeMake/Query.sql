create database CoffeeHomeMake
go

use CoffeeHomeMake
go

create table PersonnelType
(
	id int identity primary key,
	name nvarchar(50) not null
)
go

create table WorkPlace
(
	id int identity primary key,
	name nvarchar(100) not null,
	address nvarchar(100) not null
)
go


create table Personnel 
(
	id int identity primary key,
	name nvarchar(100) not null,
	address nvarchar(100) not null,
	sex int not null default 0,
	bornDay date not null,
	firstDateAtWork date,
	salary float, -- mức lương /giờ
	personnelType int not null default 0,
	CMND nvarchar(12),
	workPlace int not null,
	status nvarchar(50), -- đang làm hoặc nghỉ việc,
	dateLeave date
	foreign key (personnelType) references PersonnelType(id),
	foreign key (workPlace) references WorkPlace(id)
)
go


create table Account
(
	userName nvarchar(50) primary key,
	disPlayName nvarchar(50) not null,
	passWord nvarchar(1000) not null,
	type int not null default 0,
	idPersonnel int foreign key (idPersonnel) references Personnel(id)
)
go


create table SupplierType
(
	id int identity primary key,
	name nvarchar(100) not null
)
go

create table Supplier
(
	id int identity primary key,
	name nvarchar(100) not null,
	address nvarchar(100) not null default N'Việt Nam',
	phone nvarchar(15),
	type int foreign key(type) references SupplierType(id)
)
go


create table Material
(
	id int identity primary  key,
	name nvarchar(100) not null,
	unit nvarchar(50) not null,
	weight float not null,
	price float not null,
	idSupplier int foreign key(idSupplier) references Supplier(id)
)
go



create table ImportGoods
(
	id int identity primary key,
	theday date not null default getdate(),
	idPersonnel int,
	idMaterial int,
	count int,
	total float
	foreign key(idPersonnel) references Personnel(id),
	foreign key(idMaterial) references Material(id)
)
go

create table Inventory
(
	id int identity primary key,
	idMaterial int,
	count int,
	total float
	foreign key(idMaterial) references Material(id)
)
go

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null,
	status nvarchar(50) default N'Trống',
)
go

create table Category
(
	id int identity primary key,
	name nvarchar(50) not null
)
go

create table Product
(
	id int identity primary key,
	name nvarchar(100),
	price float,
	idCategory int
	foreign key(idCategory) references Category(id)
)
go

create table Bill
(
	id int identity primary key,
	idTableFood int,
	idPersonnel int,
	dateCheckIn date default Getdate(),
	dateCheckOut date ,
	discount int not null default 0,
	realPay float not null default 0,
	checkOut int default 0
	foreign key(idTableFood) references TableFood(id),
	foreign key(idPersonnel) references Personnel(id)
)
go


create table BillInfo
(
	id int identity primary key,
	idBill int,
	idProduct int,
	count int
	foreign key(idBill) references Bill(id),
	foreign key(idProduct) references Product(id)
)
go


declare @i int = 1
while(@i <= 20)
begin
	insert into TableFood(name, status) values(N'Bàn số ' + CAST(@i as nvarchar(3)), N'Trống')
	set @i = @i + 1
end
go

insert into Category(name) values('Italya style')
insert into Category(name) values('American style')
insert into Category(name) values(N'Việt Nam style')
insert into Category(name) values('France style')
insert into Category(name) values(N'Food')
insert into Category(name) values(N'CHÈ')

go

insert into Product(name, price, idCategory) values('Expresso', 40000, 1)
insert into Product(name, price, idCategory) values('Americano', 30000, 1)
insert into Product(name, price, idCategory) values('Ristretto', 350000, 1)
insert into Product(name, price, idCategory) values('Latte', 50000, 1)
insert into Product(name, price, idCategory) values('Macchiato', 45000, 1)
insert into Product(name, price, idCategory) values('Cappuccino', 30000, 1)
insert into Product(name, price, idCategory) values('Pour Over', 43000, 1)
insert into Product(name, price, idCategory) values('Mocha', 28000, 1)
go

insert into Product(name, price, idCategory) values('Veranda Blend', 42000, 2)
insert into Product(name, price, idCategory) values('Willow Blend', 40000, 2)
insert into Product(name, price, idCategory) values('Colombia', 55000, 2)
insert into Product(name, price, idCategory) values('Will Blend', 40000, 2)
insert into Product(name, price, idCategory) values('House Blend', 30000, 2)
insert into Product(name, price, idCategory) values('Kenya', 35000, 2)
insert into Product(name, price, idCategory) values('Decaf Sumatra', 60000, 2)
go

insert into Product(name, price, idCategory) values(N'Coffee sữa đá', 55000, 3)
insert into Product(name, price, idCategory) values(N'Coffee sữa nóng', 50000, 3)
insert into Product(name, price, idCategory) values(N'Coffee đá', 45000, 3)
insert into Product(name, price, idCategory) values(N'Bạc xỉu', 60000, 3)
insert into Product(name, price, idCategory) values(N'Coffee Arabica', 35000, 3)
insert into Product(name, price, idCategory) values(N'Coffee Robusta', 35000, 3)
insert into Product(name, price, idCategory) values(N'Coffee Culi', 35000, 3)
insert into Product(name, price, idCategory) values(N'Coffee Catimor', 35000, 3)
go

insert into Product(name, price, idCategory) values(N'Café KAH', 80000, 4)
insert into Product(name, price, idCategory) values(N'Café Noisette ', 75000, 4)
insert into Product(name, price, idCategory) values(N'Café Americain ', 65000, 4)
insert into Product(name, price, idCategory) values(N'Café Crème ', 40000, 4)
insert into Product(name, price, idCategory) values(N'Café Un Déca', 30000, 4)
go

insert into Product(name, price, idCategory) values(N'Chem chép New Zealand xốt tiêu', 300000, 5)
insert into Product(name, price, idCategory) values(N'Bồ câu tiềm thảo mộc hạt sen', 150000, 5)
insert into Product(name, price, idCategory) values(N'Tôm hùm Baby rang hương bách thảo', 250000, 5)
insert into Product(name, price, idCategory) values(N'Steak sốt vang', 150000, 5)
insert into Product(name, price, idCategory) values(N'Lẩu thượng uyển', 280000, 5)
insert into Product(name, price, idCategory) values(N'Chả mực vinh quy', 90000, 5)
insert into Product(name, price, idCategory) values(N'Hải sâm hầm tứ bửu', 400000, 5)
insert into Product(name, price, idCategory) values(N'Súp hải sản hạt sen', 100000, 5)
insert into Product(name, price, idCategory) values(N'Cá tầm nướng sa tế', 50000, 5)
insert into Product(name, price, idCategory) values(N'Cánh gà nướng thái', 150000, 5)
insert into Product(name, price, idCategory) values(N'Bò áp chảo Macau - khoai tây', 250000, 5)
insert into Product(name, price, idCategory) values(N'Vịt nướng tiêu đen', 40000, 5)
insert into Product(name, price, idCategory) values(N'Gà kim chi nướng nấm hương', 350000, 5)
insert into Product(name, price, idCategory) values(N'Thăn bò áp chảo', 330000, 5)
insert into Product(name, price, idCategory) values(N'Bò xiên Mignon', 200000, 5)
insert into Product(name, price, idCategory) values(N'Vi cá tiềm bách hợp hạt sen', 700000, 5)
insert into Product(name, price, idCategory) values(N'Bánh hải sản Metropole', 380000, 5)
go

insert into Product(name, price, idCategory) values(N'Chè hạt sen', 20000, 6)
insert into Product(name, price, idCategory) values(N'Chè bạch quả', 30000, 6)
insert into Product(name, price, idCategory) values(N'Chè khúc bạch', 30000, 6)
insert into Product(name, price, idCategory) values(N'Chè bà ba', 15000, 6)
insert into Product(name, price, idCategory) values(N'Chè bưởi', 20000, 6)
insert into Product(name, price, idCategory) values(N'Chè khoai mì', 25000,6)
insert into Product(name, price, idCategory) values(N'Chè bắp', 35000, 6)
insert into Product(name, price, idCategory) values(N'Chè thái', 30000, 6)
insert into Product(name, price, idCategory) values(N'Chè củ năng', 40000, 6)
go

create PROC USP_GetListProductByIdCategory
@id int
as
begin
	select * from Product where idCategory = @id
end
go

--insert data test---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
insert into PersonnelType(name) values(N'Admin')
insert into PersonnelType(name) values(N'Pha chế - cook')
insert into PersonnelType(name) values(N'Phục vụ')
insert into PersonnelType(name) values(N'Bảo vệ')
insert into PersonnelType(name) values(N'Shiper')
go

insert into WorkPlace(name, address) values(N'Chi nhánh 1', N'1 Đoàn Nguyễn Tuân')
insert into WorkPlace(name, address) values(N'Chi nhánh 2', N'34 Việt Trì, Hà Nội')
insert into WorkPlace(name, address) values(N'Chi nhánh 3', N'Cung Đình Huế')
insert into WorkPlace(name, address) values(N'Chi nhánh 4', N'Tầng 30 Bitesco')


go

insert into Personnel(name, bornDay, address, sex, workPlace, personnelType, CMND, firstDateatWork, salary,status, dateLeave) values(N'Phạm Minh Tài', '1990-01-02', N'ẤP 1 Hưng Long', 1, 1, 1, '025943133', '2019-01-03', 100000, N'Đang làm việc', null)
go

insert into Account(userName, passWord, disPlayName, type, idPersonnel) values('Elliot47','741253021220717864511724120418410161155', N'World', 1, 1)
go
select * from Personnel

insert into SupplierType(name) values(N'Nhà cung cấp nguyên liệu thực phẩm')
insert into SupplierType(name) values(N'Nhà cung cấp nguyên liệu thức uống')
insert into SupplierType(name) values(N'Nhà cung cấp trang thiết bị')
insert into SupplierType(name) values(N'khác')
go

insert into Supplier(name, address, type, phone) values(N'Trung Nguyên legend',N'82-84 Bùi Thị Xuân Q.1 Tp Hồ Chí Minh', 2, N'39251852')
insert into Supplier(name, address, type, phone) values(N'Hi-Food',N'Khu dân cư Tân Phong, Quận 7', 1, N' 0243 9433 711')
insert into Supplier(name, address, type, phone) values(N'Điện máy xanh', N'Ngã 4 chợ Hưng Long', 3, N'18001061')
go



--delete Supplier
--delete Bill
--dbcc Checkident ('Supplier', reseed, 0)

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create PROC USP_LogIn
@userName nvarchar(50), @passWord nvarchar(1000)
as
begin
	select * from Account where userName = @userName and passWord = @passWord
end
go

create PROC USP_InsertBill
@idTableFood int, @idPersonnel int
as
begin
	insert into Bill(idTableFood, idPersonnel, dateCheckIn, checkOut) values (@idTableFood ,  @idPersonnel , getdate(), 0)
end
go

create PROC USP_InsertBillInfo
@idBill int, @idProduct int
as
begin
	declare @count int = 1
	declare @isExitsBillInfo int 

	select @isExitsBillInfo = id, @count = count
	from BillInfo
	where idBill = @idBill and idProduct = @idProduct

	if(@isExitsBillInfo > 0)
	begin
		update BillInfo set count = @count + 1 where idProduct = @idProduct 
	end
	else
		insert into BillInfo(idBill, idProduct, count) values(@idBill, @idProduct ,@count)
end
go


create trigger UTG_CheckStatusTableFromBill
on Bill for insert, update
as
begin
	declare @idBill int

	select @idBill = id 
	from inserted
	where checkOut = 0

	declare @idTable int
	select @idTable = idTableFood from Bill where id = @idBill

	if(@idBill > 0)
		update TableFood set status = N'Có người' where id = @idTable
end
go

select * from Bill
select * from BillInfo

select TableFood.status, Bill.id as idBill, Bill.checkOut, BillInfo.count  
from TableFood, Bill, BillInfo
where TableFood.id = Bill.idTableFood and Bill.id = BillInfo.idBill and TableFood.status = N'Có người'

select TableFood.status, Bill.id as idBill, Bill.checkOut, BillInfo.count  
from TableFood, Bill, BillInfo
where TableFood.id = Bill.idTableFood and Bill.id = BillInfo.idBill and TableFood.status = N'Trống'

select bILL.id
from TableFood, Bill
where TableFood.id = Bill.idTableFood and TableFood.id = 1 and Bill.checkOut = 0

select * from BillInfo where idBill = 24

select p.name, p.price, bi.count, p.price*bi.count as [Total] from Bill as b, BillInfo as bi, Product as p where b.id = bi.idBill and p.id = bi.idProduct and b.checkOut = 0 and  idBill = 24 

select t.name, t.status, b.id as N'Có Bill số', b.checkOut as N'Chưa check out'
from TableFood as t, Bill as b
where t.id = b.idTableFood and b.checkOut = 0 and b.id = 24
go


-------------------------------TRIGGER-------------------------------

create trigger UTG_UpdateBillInfo
on BillInfo for insert, update
as
begin
	declare @idBill int
	
	select @idBill = idBill from inserted

	declare @idTableFood int

	select @idTableFood = idTableFood 
	from Bill
	where id = @idBill and checkOut = 0

	declare @count int
	select @count = count(*) from BillInfo where idBill = @idBill

	if(@count  > 0)
		update TableFood set status = N'Có người' where id = @idTableFood
	else
		update TableFood set status = N'Trống' where id = @idTableFood
end
go

create Trigger  UTG_UpdateBill
on Bill for update
as
begin
	declare @idBill int
	
	select @idBill = id from inserted

	declare @idTable int

	select @idTable = idTableFood from Bill where id = @idBill

	declare @count int

	select @count = count(*) from Bill where idTableFood = @idTable and checkOut = 0

	if(@count = 0)
		update TableFood set status  = N'Trống' where id = @idTable
end
go
---------------------------------------------------------------------

create PROC USP_DeleteCountBillInfo
@idBill int , @idProduct int
as
begin
	declare @isExitsBillInfo int
	declare @FoodCount int

	select @isExitsBillInfo  = id, @FoodCount = count
	from BillInfo
	where idBill = @idBill and idProduct = @idProduct

	if(@isExitsBillInfo > 0)
	begin
		declare @newCount int = @FoodCount - 1
		if(@newCount > 0)
			update BillInfo set count = @newCount where idProduct = @idProduct
		else
			delete BillInfo where idBill = @idBill and idProduct = @idProduct
	end
end
go


create PROC USP_SwitchTable
@idTable1 int, @idTable2 int, @idPersonnel int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int

	select @idFirstBill = id from Bill where idTableFood = @idTable1 and checkOut = 0
	select @idSecondBill = id from Bill where idTableFood = @idTable2 and checkOut = 0

	declare @isFirstTableEmpty int = 0
	declare @isSecondTableEmty int = 0

	if(@idFirstBill is Null)
	begin
		insert into Bill(dateCheckIn, dateCheckOut, idPersonnel, idTableFood, checkOut) values(GetDate(), null, @idPersonnel, @idTable1, 0)

		select @idFirstBill = Max(id) from Bill where idTableFood = @idTable1 and checkOut = 0
	end
	select @isFirstTableEmpty = Count(*) from BillInfo where idBill = @idFirstBill

	if(@idSecondBill is Null)
	begin
		insert into Bill(dateCheckIn, dateCheckOut, idPersonnel, idTableFood, checkOut) values(Getdate(), null, @idPersonnel, @idTable2, 0)

		select @idSecondBill = MAX(id) from Bill where idTableFood = @idTable2 and checkOut = 0
	end
	select @isSecondTableEmty = Count(*) from BillInfo where idBill = @idSecondBill



	select id into IDBillInfoTable from BillInfo where idBill = @idSecondBill

	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill
	update BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)

	drop Table IDBillInfoTable

	if(@isFirstTableEmpty = 0)
		update TableFood set status = N'Trống' where id = @idTable2
	if(@isSecondTableEmty = 0)
		update TableFood set status = N'Trống' where id = @idTable1
end
go


create PROC USP_CombineTable 
@idTable1 int, @idTable2 int, @idPersonnel int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int
	
	select @idFirstBill = id from Bill where idTableFood = @idTable1 and checkOut = 0
	select @idSecondBill = id from Bill where idTableFood = @idTable2 and checkOut = 0

	if(@idFirstBill is Null)
	begin
		insert into Bill(DateCheckIn, DateCheckOut, idPersonnel, idTableFood, checkOut) values(getdate(), Null, @idPersonnel, @idTable1, 0)
		select @idFirstBill = max(id) from Bill where idTableFood  = @idTable1 and checkOut = 0
	end


	if(@idSecondBill is Null)
	begin
		insert into Bill(DateCheckIn, DateCheckOut, idPersonnel, idTableFood, checkOut) values(getdate(), Null, @idPersonnel, @idTable2, 0)
		select @idSecondBill = max(id) from Bill where idTableFood  = @idTable2 and checkOut = 0
	end
	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill
	update TableFood set status = N'Trống' where id = @idTable1
	
end
go


--delete BillInfo
--delete Bill
--dbcc Checkident ('BillInfo', reseed, 0)


go

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
go


create PROC USP_ReportPerDay
@date date
as
begin
	select b.id as 'ID', dateCheckIn as 'CheckIn', dateCheckOut as 'CheckOut', discount as 'DisCount', realPay as 'Pay', p.name as 'Cashier'
	from Bill as b, Personnel as p
	where checkOut = 1 and p.id = b.idPersonnel and dateCheckIn = @date and dateCheckOut = @date
end
go

create PROC USP_ReportMonth
@dateCheckIn date, @dateCheckOut date
as
begin
	select b.id as 'ID', dateCheckIn as 'CheckIn', dateCheckOut as 'CheckOut', discount as 'DisCount', realPay as 'Pay', p.name as 'Cashier'
	from Bill as b, Personnel as p
	where checkOut = 1 and p.id = b.idPersonnel and dateCheckIn >= @dateCheckIn and dateCheckOut <= @dateCheckOut
end
go


create PROC USP_TOP10Sell
@dateCheckIn date, @dateCheckOut date
as
begin
	select top 10 p.name, p.price,SUM(bi.count) as totalCount
	from Product as p, BillInfo as bi, Bill as b
	where p.id =  bi.idProduct and b.id = bi.idBill and b.dateCheckIn >= '2019-09-01' and b.dateCheckOut <= '2019-09-30' and b.checkOut = 1
	group by p.name, p.price
	order by totalCount desc
end
go


create PROC USP_DetailTop10
@dateCheckIn date, @dateCheckOut date, @Prevenue float
as
begin
	select top 10 p.name, p.price,SUM(bi.count) as totalCount, p.price * SUM(bi.count) as 'total' ,ROUND(((p.price * SUM(bi.count)) / @Prevenue * 100), 2) as 'Percent'
	from Product as p, BillInfo as bi, Bill as b
	where p.id =  bi.idProduct and b.id = bi.idBill and b.dateCheckIn >= @dateCheckIn and b.dateCheckOut <= @dateCheckOut and b.checkOut = 1
	group by p.name, p.price
	order by totalCount desc
end
go

create PROC USP_ProlemProduct
@dateCheckIn date, @dateCheckOut date
as
begin
	select p.name, p.price, SUM(bi.count) as 'totalCount', SUM(bi.count)*p.price as 'TotalPrice'
	from Product as p, BillInfo as bi, Bill as b
	where p.id =  bi.idProduct and b.id = bi.idBill and b.dateCheckIn >= @dateCheckIn and b.dateCheckOut <= @dateCheckOut and b.checkOut = 1
	group by p.name, p.price
	having SUM(bi.count) < 10
	order by totalCount asc
end
go


create PROC USP_GetListStaff
as
begin
	select pn.id, pn.name, pn.address, pn.bornDay, pn.sex, pn.CMND, pn.firstDateAtWork as N'DateAtWork', pn.salary as 'SalaryperHours' , w.name as N'Workplace', w.address as 'Location' , pt.name as N'Position', pn.status, pn.dateLeave 
	from Personnel as pn, PersonnelType as pt, WorkPlace as w
	where pn.personnelType = pt.id and pn.workPlace = w.id 
end
go


create PROC USP_InsertNewPersonnel
@name nvarchar(100), @address nvarchar(100), @sex int, @bornDay date, @idPersonnelType int, @idWorkPlace int, @salary float, @CMND nvarchar(12), @firstDateAtWork date
as
begin
	insert into Personnel(name, address, sex, bornDay, personnelType, workPlace, salary, CMND, firstDateAtWork, status) values(@name, @address, @sex, @bornDay, @idPersonnelType, @idWorkPlace, @salary, @CMND, @firstDateAtWork, N'Đang làm việc')
end
go


create PROC USP_GetInfoPersonnel
@id int
as
begin
	select pn.id, pn.name, pn.address, pn.bornDay, pn.sex, pn.CMND, pn.firstDateAtWork as N'DateAtWork', pn.salary as 'SalaryperHours' , w.name as N'Workplace', w.address as 'Location' , pt.name as N'Position', pn.status, pn.dateLeave 
	from Personnel as pn, PersonnelType as pt, WorkPlace as w
	where pn.personnelType = pt.id and pn.workPlace = w.id and  pn.id = @id
end
go

create PROC USP_UpdatePersonnelINfo
@id int, @name nvarchar(100), @address nvarchar(100), @sex int, @bornDay date, @personnelType int, @workPlace int, @salary float, @CMND nvarchar(12), @firstDayAtWork date
as
begin
	update Personnel set name = @name, address = @address, sex = @sex, bornDay = @bornDay, personnelType = @personnelType, workPlace = @workPlace, salary = @salary, cmnd = @CMND, firstDateAtWork = @firstDayAtWork
	where id = @id
end
go

create PROC USP_GetListStaffFired
as
begin
	select pn.id, pn.name, pn.address, pn.bornDay, pn.sex, pn.CMND, pn.firstDateAtWork as N'DateAtWork', pn.salary as 'SalaryperHours' , w.name as N'Workplace', w.address as 'Location' , pt.name as N'Position', pn.status, pn.dateLeave 
	from Personnel as pn, PersonnelType as pt, WorkPlace as w
	where pn.personnelType = pt.id and pn.workPlace = w.id and  pn.status = N'Đã nghỉ việc'
end
go

create PROC USP_GetListMaterial
as
begin
	select m.id , m.name  , m.unit , m.price , m.weight , s.name as N'Supplier'
	from Supplier as s, Material as m
	where s.id = m.idSupplier
end
go

create PROC USP_GetMaterialbelongSupplier

@id int
as
begin
	select m.id , m.name  , m.unit , m.price , m.weight , s.name as N'Supplier'
	from Supplier as s, Material as m
	where s.id = m.idSupplier and s.id = @id
end
go

create PROC USP_AddNewMaterial
@name nvarchar(100), @unit nvarchar(50), @weight float, @price float, @idSupplier int
as
begin
	insert into Material(name, unit, weight, price, idSupplier) values(@name, @unit, @weight, @price, @idSupplier)
end
go


create PROC USP_GetListImportGoods
as
begin
	select i.id , i.theday , p.name as N'nameStaff', s.name as N'Supplier', s.address , m.name as N'Material', m.price, m.unit, m.weight, i.count, (m.price*i.count) as N'total'
	from ImportGoods as i, Material as m, Personnel as p, Supplier as s
	where i.idMaterial = m.id  and  p.id = i.idPersonnel and m.idSupplier = s.id
end
go


create PROC USP_ImportGoods
@date Date, @idPersonnel int, @idMaterial int, @count int
as
begin
	insert into ImportGoods(theday, idPersonnel, idMaterial, count) values(@date, @idPersonnel, @idMaterial, @count)
end
go


create PROC USP_AddnewSupplier
@name nvarchar(100), @address nvarchar(100), @phone nvarchar(20), @idSupplierType int
as
begin
	insert into Supplier(name, address, phone, type) values(@name, @address, @phone, @idSupplierType)
end
go


create PROC USP_UpdateSupplier
@id int, @name nvarchar(100), @address nvarchar(100), @phone nvarchar(20), @idSupplierType int
as
begin
	update Supplier set name = @name, address = @address, phone = @phone, type = @idSupplierType where id = @id
end
go


create PROC USP_GetListProductByPageNumber
@pageNumber int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows * @pageNumber
	declare @exceptRows int = (@pageNumber - 1) * @pageRows

	;with ProductShow as (select p.id as N'STT', p.name as N'Tên SP', p.price as N'Đơn giá', c.name as N'Nhóm' 
	from Product as p, Category as c 
	where p.idCategory = c.id)

	select Top (@selectRows) * from ProductShow
	except
	select Top (@exceptRows) * from ProductShow
end
go



create PROC USP_GetListBillByPageNumber
@dateCheckIn date, @dateCheckOut date, @pageNumber int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows * @pageNumber
	declare @exceptRows int = (@pageNumber - 1) * @pageRows

	;with BillShow as (select b.id as 'ID', dateCheckIn as 'CheckIn', dateCheckOut as 'CheckOut', discount as 'DisCount', realPay as 'Pay', p.name as 'Cashier'
	from Bill as b, Personnel as p
	where checkOut = 1 and p.id = b.idPersonnel and dateCheckIn >= @dateCheckIn and dateCheckOut <= @dateCheckOut)

	select Top (@selectRows) * from BillShow
	except
	select Top (@exceptRows) * from BillShow
end
go


create PROC USP_AddNewAccount
@userName nvarchar(100), @pass nvarchar(1000), @displayName nvarchar(100), @idPersonnel int
as
begin
	insert into Account(userName, passWord, disPlayName, type, idPersonnel) values(@userName, @pass, @displayName, 0, @idPersonnel)
end
go



select * 
from Personnel as p
where id not in(select idPersonnel from Account) and  status = N'Đang làm việc' and p.personnelType = 1 or p.personnelType = 2

select * from Account
go
create PROC USP_UpdateAccount
@useName nvarchar(100), @displayName nvarchar(100), @newpass nvarchar(1000)
as
begin
	update Account set disPlayName = @displayName, passWord = @newpass where userName = @useName
end
go