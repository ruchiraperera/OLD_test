SQL injection usually occurs when you ask a user for input, like their username/userid, and instead of a name/id, 
the user gives you an SQL statement that you will unknowingly run on your database.


example

txtUserId = getRequestString("UserId");
txtSQL = "SELECT * FROM Users WHERE UserId = " + txtUserId;

but user send something like- 

SELECT * FROM Users WHERE UserId = 105 OR 1=1; 

*** SQL Injection Based on ""="" is Always True
