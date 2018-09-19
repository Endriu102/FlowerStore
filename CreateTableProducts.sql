create table Products(

        ProductID int not null primary key identity,
        Name nvarchar(100) not null,
        Description nvarchar(500),
       Category nvarchar(50),
	   Price decimal(16,2) not null

)


insert into Products (Name, Price)
values ('Go�dzik',3),('R�a',10),('Tulipan',5),('Hiacynt',4),('S�oneczniki',7),('�onkil',10),('Piwonia',12),('Gladiole',15)


select * from Products
