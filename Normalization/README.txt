Normalization - 

why normalization - should remove data redundency
	create meaningful data structure

types of normalization - 1NF, 2NF, 3NF and BCNF

1NF - make sure signle valued attributes for columns, unique names for columns, need to be in same domain data, remove duplicate colums

2NF - should be 1NF records, remove partial dependency .

-------------------------------------------------------------------
|  Course  |    InstId    |   Instructor   |  Instructor Phone    |
-------------------------------------------------------------------
|  English |  1           |  John Doe      |     0123456789       |
|  French  |  1           |  John Doe      |     0123456789       |
|  Drawing |  2           |  Alan Smith    |     9856321158       |
|  PHP     |  3           |  Camella Ford  |     2225558887       |
|  C++     |  3           |  Camella Ford  |     2225558887       |
-------------------------------------------------------------------

primitive and non primitive attributes - primitive (candidate keys)
if there is a unquie key to identify specific attributes and another key to identify other keys
that is called partial dependency


3NF - should ne 2NF records, remove transitive dependency

-------------------------------------------------------------------
|  Course  |    Field     |   Instructor   |  Instructor Phone    |
-------------------------------------------------------------------
|  English |  Languages   |  John Doe      |     0123456789       |
|  French  |  Languages   |  John Doe      |     0123456789       |
|  Drawing |  Art         |  Alan Smith    |     9856321158       |
|  PHP     |  Programming |  Camella Ford  |     2225558887       |
|  C++     |  Programming |  Camella Ford  |     2225558887       |
-------------------------------------------------------------------

Transitive dependency

when you get course details, then you will get intraustor phone details as well, if you remove 
course details then it removes the intructor phone number too. so best way is u need to separate 
instructor deatils and course details (need to have two tables called course and instructor)


BCNF - foreign keys

Stu_ID is the super-key in the relation Student_Detail and Zip is the super-key in the relation ZipCodes. So,

Stu_ID → Stu_Name, Zip

and

Zip → City

Which confirms that both the relations are in BCNF.

determinant must be a candidate key.



interview questions - 

- What are different types of Normalization Levels or Normalization Forms?
- What is De-normalization? 

De-normalization is the process of optimizing the read performance of a database by 
adding redundant data or by grouping data

- What is a Transaction?
A transaction is a logical unit of work performed against a database in which all steps must be performed or none.

- What are ACID properties?
A database transaction must be Atomic, Consistent, Isolation and Durability.

- What are the differences between Truncate and Delete?
	Truncate is a DDL statement. Delete is a DML statement
	In case of delete, rollback recovers data before issuing a commit. In case of truncate, you cannot recover data.

- What are the differences between Having and Where clause?
	The Where clause filters rows before grouping. Having clause filters rows after grouping.
	aggregation function can be used with having clause.

- What are the differences between UNION and UNION ALL.
	union - without duplicate records
	union all with duplicate records

- DDL and DML
	DDL - data definition language
	DML - data manupulate language.