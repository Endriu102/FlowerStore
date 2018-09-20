create table Products(

        ProductID int not null primary key identity,
        Name nvarchar(100) not null,
        Description nvarchar(500),
       Category nvarchar(50),
	   Price decimal(16,2) not null

)


insert into Products (Name, Price, Category)
values ('GoŸdzik',3,'Kwiaty ciête'),('Ró¿a',10,'Kwiaty ciête'),('Tulipan',5,'Kwiaty ciête'),('Hiacynt',4,'Kwiaty ciête'),('S³oneczniki',7,'Kwiaty ciête'),('¯onkil',10,'Kwiaty ciête'),('Piwonia',12,'Kwiaty ciête'),('Gladiole',15,'Kwiaty ciête'),('Fikus',20,'Bonsai'),('D¹b',40,'Bonsai'),('Klon',30,'Bonsai'),('Wrzos',10,'Bonsai'),('Ró¿a',20,'Kwiaty doniczkowe'),('Pelargonia',12,'Kwiaty doniczkowe')


select * from Products
