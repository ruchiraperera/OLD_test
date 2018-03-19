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



