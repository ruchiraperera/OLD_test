- Ienumerable VS Iquerable (lazy loading)

IEnumerable is suitable for LINQ to Object and LINQ to XML queries.
IEnumerable doesn’t support lazy loading. Hence not suitable for paging like scenarios.

example - IEnumerable<Employee> list = dc.Employees.Where(p => p.Name.StartsWith("S"));
list = list.Take<Employee>(10); 

query - 
     SELECT [t0].[EmpID], [t0].[EmpName], [t0].[Salary] FROM [Employee] AS [t0]
    WHERE [t0].[EmpName] LIKE @p0

IQueryable<Employee> list = dc.Employees.Where(p => p.Name.StartsWith("S"));
list = list.Take<Employee>(10); 

query -  SELECT TOP 10 [t0].[EmpID], [t0].[EmpName], [t0].[Salary] FROM [Employee] AS [t0]
    WHERE [t0].[EmpName] LIKE @p0

//-----------------------------------------------------------



	If you are writing an application that requires any of the following features, you should use the ADO.NET Entity Framework:

*       The ability to define more flexible mapping to existing relational schema, for example:

    o  Mapping a single class to multiple tables
    o  Mapping to different types of inheritance
    o  Directly Modeling Many to Many relationships
    o  Mapping to an arbitrary query against the store

*         The ability to query relational stores other than the Microsoft SQL Server family of products.

*        The ability to share a model across Replication, Reporting Services, BI, Integration Services, etc.


//-----------------------------------------------------------------------------------------------------------

why code first is better than database first?

* when database table update like field rename or data type change that will manuall update in EDMX file.
* but code first not like this.


//-----------------------------------------------------------------------------------------------------------



- What’s the difference between LINQ to SQL and Entity Framework?

	*** LINQ to SQL only supports 1 to 1 mapping of database tables, views, sprocs and functions available in Microsoft SQL Server. It's a great API to use for quick data access construction to relatively well designed SQL Server databases. LINQ2SQL was first released with C# 3.0 and .Net Framework 3.5.
LINQ to Entities (ADO.Net Entity Framework) is an ORM (Object Relational Mapper) API which allows 
for a broad definition of object domain models and their relationships to many different ADO.Net data providers. As such, 
you can mix and match a number of different database vendors, application servers or protocols 
to design an aggregated mash-up of objects which are constructed from a variety of tables, sources, services, etc.
ADO.Net Framework was released with the .Net Framework 3.5 SP1.

    LINQ to SQL is good for rapid development with SQL Server. EF is for enterprise scenarios and works with SQL Server as well as other databases.
    LINQ maps directly to tables. One LINQ entity class maps to one table. EF has a conceptual model and that conceptual model maps to the storage model via mappings. So one EF class can map to multiple tables, or one table can map to multiple classes.
    LINQ is more targeted towards rapid development while EF is for enterprise level where the need is to develop a loosely coupled framework.

	LINQ to SQL supports rapid development of applications that query Microsoft SQL Server databases using objects that map directly to SQL Server schemas.
	LINQ to Entities supports more flexible mapping of objects to Microsoft SQL Server and other relational databases through extended ADO.NET Data Providers.


- difference between code first / model first and database first

	code first - fully control by code and DB just a storage with no logic and EF will handle the creation and management 
	database first - design and create the database first and map database with Entityframework, Manual changes to the database are possible because the database defines your domain model. You can always update model from database
	model first - draw the model and let the workflow generate the database and EF script

- Will There Be Any Issues Adding A Table Without Primary Keys To A Data Model?
	all the entities must have unique key 

- How Do You Truncate A Table Using Entity Data Model?
	using (var context = new MyTestDbEntities())
	{
    context.ExecuteStoreCommand("TRUNCATE table Dummy");
	}

- What Is Deferred Loading(lazy Loading)?
	When objects are returned by a query, related objects are not loaded at the same time.
	Instead they are loaded automatically when the navigation property is accessed. Also known as “lazy loading,”

	_Orders = new Lazy<List<Order>>(() => LoadOrders());

- what is Eagerly loading - query returns with related objects which can be acheived by using include method.
	// Load all blogs and related posts 
    var blogs1 = context.Blogs 
                          .Include(b => b.Posts) 
                          .ToList(); 

- Explicit Loading: Explicitly loading takes place when you have disabled Lazy loading, and you still want to lazy loading. For this, we have to call the load method on the related entities.
	this can do by load function

	 // Get a specified customer by contact ID.
    var contact =
        (from c in context.Contacts
         where c.ContactID == contactID
         select c).First();

	 if (!contact.SalesOrderHeaders.IsLoaded)
    {
        contact.SalesOrderHeaders.Load();
    }


- disable lazy loading
	context.Configuration.LazyLoadingEnabled = false;
