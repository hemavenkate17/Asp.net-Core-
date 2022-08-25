
Create database MyDatabase

use MyDatabase

CREATE TABLE employees (
    employee_id int NOT NULL,
    name varchar(50) NOT NULL,
    status varchar(50) NOT NULL,
    manager varchar(30),
    wfm_manager varchar(30),
    email text,
    lockstatus varchar(30),
    experience decimal(5,0),
    profile_id int,
    primary key (employee_id)
);

insert into employees values ( 1000,'Hemalatha', 'approved','Rohit','Deena','hemavenkate@gmail.com','Not Locked',2,1)
insert into employees values ( 1001,'Vinoba', 'rejected','lokesh','Deepak','vinoba@gmail.com','Locked',3,2)
insert into employees values ( 1002,'Bersy', 'approved','miryala','Gowtham','bersy@gmail.com','Not Locked',4,3)

select * from employees

CREATE TABLE users (
    username varchar(30) NOT NULL,
    password varchar(30) NOT NULL,
    name varchar(30) NOT NULL,
    role varchar(30) NOT NULL,
    email text
);

insert into users values ('Karnan V' , '1234', 'Karnan','Software Engineer','karnan@gmail.com')
insert into users values ('Venkate E' , '5678', 'Venkatesan','Trainee','venkate@gmail.com')
insert into users values ('Laxmi V' , '7890', 'Laxmi','Test Engineer','laxmi@gmail.com')

select * from users 

CREATE TABLE skills (
	skillid decimal(5,0) NOT NULL,
    name varchar(30) NOT NULL,
    primary key (skillid)
);

insert into skills values (1, 'java, sql server, C#')
insert into skills values (2, 'Angular, react js, node js')
insert into skills values (3, 'Python, javascript, jquery')

select * from skills

CREATE TABLE skillmap (
	employee_id int ,
	skillid decimal(5,0) ,
	FOREIGN KEY (employee_id) REFERENCES employees (employee_id),
    FOREIGN KEY (skillid) REFERENCES skills (skillid)
);

insert into skillmap values (1000, 1)
insert into skillmap values (1001, 2)
insert into skillmap values (1002, 3)

select * from skillmap 

CREATE TABLE softlock (
	employee_id int ,
	manager varchar(30),
    reqdate date,
    status varchar(30),
    lastupdated date,
    lockid int not null ,
    requestmessage text,
    wfmremark text,
    managerstatus varchar(30),
    mgrstatuscomment text,
    mgrlastupdate date,
    primary key (lockid),
	FOREIGN KEY (employee_id) REFERENCES employees (employee_id)
);

insert into softlock values (1000, 'Rohit','2022-09-08','Requested','2022-08-11',100,'need this employee','','','',null)

select * from softlock

