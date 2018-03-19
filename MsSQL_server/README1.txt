SSDT (sql server data tools) install for visual studio it will help to integrate business intelligent reports

SSIS - (sql server integration service) - it is the platform for ETL operations

ETL - Extract, transform and load (The process of collecting and cleaning data from various sourcess)

for data migration we can use sql server import and export wizard ****

SSIS stands for “SQL Server Integration Services”, Microsoft have their many products to compete different segment. To compete in segment of data migration, ETL and transformation, Microsoft had introduced their tool with SQL 2005. Microsoft empowers it with all the ammunition to help data migration, transformation, ETL and other function. According to me it is not a tool but a platform which empower user to do ETL (extract, transform, and load) operations, performing complex solution such like email to particular person or group on particular event, reading data from different sources including flat file, XLS file and many others, writing data to different sources is also possible. As per MSDN, SSIS is empowered with rich set of built – in task and transformation; tools for constructing packages. They have provided dual way to create SSIS package, one is User can write it programmatically or they provided GUI which help user to create a package without writing a single line of code.

Microsoft has designed this product to provide better approach towards data migration, manipulation and transformation. With the power to define the workflow of process and task, user can easily define how the process should flow and perform some task on different interval. It also provides color codification and real-time monitoring. It can handle heterogeneous data sources.

Now, question is “how easy user can do this activities?”.  Let’s say, we need to migrate our oracle data to SQLServer data and both the server are different location at different continent. To satisfy this change we can create single package or multiple package in SSIS project. So, we can create one package and create two connection(here, I would like to make clear that in this blog we are not going in detail of SSIS components) respectively. We also need to have manipulate data because of different data type or we may need to create some derived columns to do that we have used Tasks and converters and using these components we have transfer data without writing single code of line. This is the one of the best examples of ETL.

Let’s discussed about what are the advantages and disadvantages

Advantages

    SSIS can handle data from heterogeneous data sources at a same package. We say Data sources can be diverse, including custom or scripted adapters.
    SSIS consumes data which are difficult like FTP, HTTP,MSMQ, and Analysis services etc.…
    SSIS provides transformation functionality.
    Easier to maintain and package configuration
    Tightly integrated with Microsoft Visual Studio and SQL Server.
    Use the SQL Server Destination instead of OLE DB; which allows you to load data into SQL faster.
    Remove network as a bottleneck for insertion of data by SSIS into SQL.
    Better for complex transformations, multi-step operations, aggregating data from different data sources or types, and structured exception handling.
    Data can be loaded in parallel to many varied destinations.

Disadvantages

    To see package execution report need Management Studio rather than being published to reporting services or other way.
    If multiple packages are available that need to run parallel then you have a trouble. SSIS memory usage is high and it conflicts with SQL.
    In case of CPU allocation it also a problematic case when you have more packages to run parallel. You need to ensure that processer allocation between SQL and SSIS is done properly otherwise SQL have upper hand in it and due to that SSIS run very slow.

Finally, I would like to include my experience that SSIS removes need of hardcore programmers. If a person who know logic, some extend T-SQL and good knowledge of SSIS than he/she can write SSIS package. User does not need to have thorough knowledge of programming. As SSIS provides functionality to write script in .net language, user knowing “C#” or “VB” will be good to go.