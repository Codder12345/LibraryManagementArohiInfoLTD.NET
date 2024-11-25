create database Librarysystem
use Librarysystem

----------------------------------------------------------------------------
-----------------LoginTable--------------------------------------------------
-----------------------------------------------------------------------------
create table Login_Table
(
 ID int not null IDENTITY(1,1) primary key,
 username varchar(150)not null,
 pass varchar(150)not null
)
insert into Login_Table(username,pass)values('pooja','pass');
select * from Login_Table;
-----------------------------------------------------------------------
------------------------------------AddBookTable------------------------
--------------------------------------------------------------------------

create table AddBook_Table
(
bid int not null IDENTITY(1,1) primary key,
bName varchar(150) not null,
bAuthor varchar(150)not null,
bPublication varchar(150)not null,
bDate varchar(150)not null,
bPrice bigint not null,
bQuantity bigint not null
)
insert into AddBook_Table(bName,bAuthor,bPublication,bDate,bPrice,bQuantity)
values('life','lifestyle',2022,'22/2/2021',200,1000);

select *from AddBook_Table
--------------------------------------------------------------------------
------------------------------AddStudentTable-------------------------------
-----------------------------------------------------------------------------
create table AddStudent_Table
(
studID int  not null IDENTITY(1,1) primary key,
studName varchar(150),
studEnroll varchar(150),
studDep varchar(150),
studSem varchar(150),
studContact bigint,
studEmail varchar(150)
)
select * from AddStudent_Table
--------------------------------------------------------------------------------------
----------------------------IssueBookTable----------------------------------------------
------------------------------------------------------------------------------------------

create table IssueBook_Table
(
ID int not null IDENTITY(1,1),
stud_Enroll varchar (150),
stud_Name varchar(150),
stud_Dep varchar(150),
stud_Sem varchar(150),
stud_Contact bigint not null,
stud_Email varchar(150) not null,
book_Name varchar(1150)not null,
book_Issue_date varchar(150)not null,
book_Return_date varchar(150)
);

select * from IssueBook_Table
select * from IssueBook_Table where stud_Enroll='101' and book_Issue_date;
insert into IssueBook_Table values(101,'pooja','com','5th',9075272433,'waykar@gmail.com','java','08/12/2023','02/02/2024')
Truncate  table IssueBook_Table;