create database DBEmployee

use DBEmployee

create table Department(
    Id int primary key identity,
    Name varchar(50)
)


create table Employee(
    Id int primary key identity,
    FullName varchar(50),
    IdDepartment int references Department(Id),
    Salary decimal(10, 2),
    HireDate datetime
)

Insert into Department(Name) values 
("Administrator"),
("Marketing"),
("Sales"),
("Production")


Insert into Department(FullName, IdDepartment, Salary, HairDate) values 
("Mary Patterson", 1, 1500, GETDATE())