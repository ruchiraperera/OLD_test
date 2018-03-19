//------------------------------------------------

As long as you don't do it like queryable.ToList().Skip(5).Take(10), it won't return the whole recordset.

Take

Doing only Take(10).ToList(), does a SELECT TOP 10 * FROM.

Skip

Skip works a bit different because there is no 'LIMIT' function in TSQL. However it creates an SQL query that is based on the work described in this ScottGu blog post.

If you see the whole recordset returned, it probably is because you are doing a ToList() somewhere too early.

//-------------------------------------------------

LINQ – Overview

Here’s a summary of the LINQ providers that are included with .NET 4.

LINQ to SQL:

This is the original LINQ provider for data access. It allows you to fetch data from a SQL Server database.

LINQ to Entities:

Like LINQ to SQL, LINQ to Entities allows you to perform database queries with a LINQ expression. Unlike LINQ to SQL, it supports a range of database software—anything that has an ADO.NET provider—and it gives you more options for mapping tables to differently structured objects.

LINQ to Objects:

This is the simplest form of LINQ. It allows you to query collections of in-memory objects (such as an array, an ArrayList, a List, a Dictionary, and so on).

Parallel LINQ: This is a variation of LINQ to objects that has built-in support for multithreaded execution. That means you can use it to speed up intensive searches on in-memory collections—if your web server has multiple CPU cores.

LINQ to DataSet: This form of LINQ resembles LINQ to objects, except it digs DataRow objects out of a DataTable.

LINQ to XML: This form of LINQ allows you to search the elements contained in an XElement or XDocument . In other words, it allows you to perform more powerful searches when dealing with in-memory XML data.
