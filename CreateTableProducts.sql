create table Products(

        ProductID int not null primary key identity,
        Name nvarchar(100) not null,
        Description nvarchar(500),
       Category nvarchar(50),
	   Price decimal(16,2) not null

)


insert into Products (Name, Price, Category)
values ('Go�dzik',3,'Kwiaty ci�te'),('R�a',10,'Kwiaty ci�te'),('Tulipan',5,'Kwiaty ci�te'),('Hiacynt',4,'Kwiaty ci�te'),('S�oneczniki',7,'Kwiaty ci�te'),('�onkil',10,'Kwiaty ci�te'),('Piwonia',12,'Kwiaty ci�te'),('Gladiole',15,'Kwiaty ci�te'),('Fikus',20,'Bonsai'),('D�b',40,'Bonsai'),('Klon',30,'Bonsai'),('Wrzos',10,'Bonsai'),('R�a',20,'Kwiaty doniczkowe'),('Pelargonia',12,'Kwiaty doniczkowe')


select * from Products
