Code first development.

Database.SetInitializer<DbCodeFirstEntity>(new CreateDatabaseIfNotExists<DbCodeFirstEntity>()); in dbcontext constructor.
using System.ComponentModel.DataAnnotations; library can be used to set attributes like primary key, composite keys,required and etc.


*** error-sorted - connectionstring should come below all "<connectionString /> was on the top part of the Web.config, just after <configuration> ,then I tried to build proejct again, after moving it right before </configuration>"



Migration process.. 

01. install-package EntityFramework
02. Enable-migrations
03. add-migration IntitialModel -IgnoreChanges -Force // empty migration
04. update migration/ update-database


*** working with existing database. 

new > data > ADO.net entity model > code first from database

//----------------------------------------------------------------------------------------

overide the conde first conversion

there two ways . => data annotations (recommend way) and fluent api

exmaple - 
database table one field needs to not null

with data annotation  - 
[Required]


fluent API - in db context 
protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Enityt<student>().property(t=> t.descroption).IsRequired()
        }

//-----------------------------------------------------------------------------------------

data annotations

[Table(tbl_student)]
public class student{}

[Key,databaseGenerated(databaseGeneratedOption.None)] // databaseGenerated(databaseGeneratedOption.None) if it is not auto generated one
public string ISBN {get; set;}

[index(isUnique = true)]


//---------------------------

relationship needs to maintain with fluent API





