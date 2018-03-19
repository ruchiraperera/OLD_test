- Why we use Stored Procedure 
	it reduce network load, reduce excution time and security purposes.
	(Stored Procedures can be encrypted and that also prevents SQL Injection Attacks)

	CREATE PROCEDURE spEmployee   
    AS   
    BEGIN   
      
    SELECT EmployeeId, Name, Gender, DepartmentName   
    FROM tblEmployees   
    INNER JOIN tblDepartments   
    ON tblEmployees.EmployeeDepartmentId = tblDepartments.DepartmentId   
    END   


- What is a function in SQL Server?
	function is a sequence of statement that gets the input and return those result. 
	function must have return type.  (user defined function and pre defined function - logical function, string function
	Functions only work with input parameters.)
	

    Create function ss(@id int)   
    returns table   
    as   
    return select * from item where itemId = @id   


- What is a trigger in SQL Server?
	it is same as stored procedure and which is fired when event occurs. 

	there are two types of trrigers - DDL triggers, DML triggers

	create trigger deep   
	on emp   
	for   
	insert, update, delete   
	as   
	print 'you can notinsert,update and delete this table i'   
	rollback; 

	DDL - Create_table, Create_view, drop_table, Drop_view and Alter_table


	DML - user define triggers

- What is a view in the database?
	A View is nothing but a select query with a name given to it or we can simply say a view is a Named Query

	Multiple views can be created on one table.
    Views can be defined as read-only or updatable.
    Views can be indexed for better performance.
    Insert, update, delete can be done on an updatable view.

	CREATE VIEW view_name AS   
	SELECT column_name(s)   
	FROM table_name   
	WHERE condition

	if we add check option - then we can't update query

	update viewname set state = 'OH';
	insert into viewname (fields) VALUES ();

- What do I need views in a database?
	To hide the complexity of the underlying database schema, or customize the data and schema for a set of users.
    To control access to rows and columns of data.
    To aggregate data for performance.

- Clusted indexing OR Non clusted indexing
	A Clustered Index sorts and stores the data in the table based on keys. A Clustered Index can be defined only once per table 
	Non Clustered Indexes or simply indexes are created outside of the table. SQL Server supports 999 Non-Clustered per table and each Non-Clustered can have up to 1023 columns

- What are query types in a database?
	DDL - create, alter drop
	DML - INSERT , update delete, insert into (bulk)
	DCL - GRANT, revoke (Data Control Language)
	TCL - rollback, tansaction, commint (Transaction Control Language)

- Types of joins
	inner join
	full join
	right outer join
	left outer join

- Chcek in sql server

	create table emp(empId int check(empId >10),empName varchar(15))   

	check constraint is a rule that help to validate insert data


	exec sp_help emp 

- What is a constraint in SQL?
	Primary Key Constraint
    Foreign Key Constraint
    Not Null Constraint
    Unique constraint
    Default Constraint
    Check Constraint
