
drop database test02
drop table table_02

create database test02

create table table_02(
	id int NOT NULL,
	name nvarchar(50) NOT NULL,
	date_of_birth DATETIME NULL
)

INSERT INTO table_02 VALUES (1, 'BOB', '2019-01-01 05:22:01.123')

/* new record but no name*/
INSERT INTO table_02 (id,name, date_of_birth) VALUES (2,'TIM', '2019-01-01 05:22:01.123')
INSERT INTO table_02 (id,name) VALUES (3,'PAULA')

select * from table_02