Configure EF Core

Create Model
Create Database context class file
Genarate the Database from code migrations


Model creation important notes

01. Data Annotation
02. DataGenerationAttributes 	
    Computed: ValueGeneratedOnAddOrUpdate
    Identity: ValueGeneratedOnAdd
    None: ValueGeneratedNever

System.ComponentModel.DataAnnotations.Schema attributes
Attribute 	Description
Table -	The database table and/or schema that a class is mapped to.
Column - 	The database column that a property is mapped to.
ForeignKey 	Specifies the property is used as a foreign key in a relationship.
DatabaseGenerated 	Specifies how the database generates values for a property.
NotMapped 	Applied to properties or classes that are to be excluded from database mapping.
InverseProperty 	Specifies the inverse of a navigation property
ComplexType 	Denotes that the class is a complex type. *Not currently implemented in EF Core.

System.ComponentModel.Annotations attributes
Attribute 	Description
Key 	Identifies one or more properties as a Key
Timestamp 	Specifies the data type of the database column as rowversion
ConcurrencyCheck 	Specifies that the property is included in concurrency checks
Required 	Specifies that the property's value is required
MaxLength 	Sets the maximum allowed length of the property value (string or array)
StringLength 	Sets the maximum allowed length of the property value (string or array)

----------------------------------------------------------------------------------------------------------------

Timestamp attributes

The TimeStamp attribute is used to specify that a property should take part in concurrency management.

    public class Author
    {
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
        [TimeStamp]
        public byte[] RowVersion { get; set; }
    }

	- The Fluent API equivalent to the TimeStamp attribute is the IsConcurrencyToken method chained 
	with the ValueGeneratedOnAddOrUpdate ( [DatabaseGenerated(DatabaseGeneratedOption.Computed)] ) method.
	-  How we can use the Isconcurrency Token method in OnModelCreating method in Db Context
	modelBuilder.Entity<Author>()
            .Property(a => a.FirstName).IsConcurrencyToken();
	- How we can use before ValueGeneratedOnAddOrUpdate
	        modelBuilder.Entity<Author>()
            .Property(a => a.RowVersion)
            .IsConcurrencyToken()
            .ValueGeneratedOnAddOrUpdate();

//---------------------------------------------------------------------------------------------------------

concurrency Check

 - This can be added to any property to avoid any concurrency exceptions or conflicts

	example 
	    [ConcurrencyCheck]
    public string LastName { get; set; }

	//fluent api declaration with model binder..
	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Author>()
            .Property(a => a.LastName).IsConcurrencyToken();
    } 

//--------------------------------------------------------------------------------------------------------------

Concurrency management in EF Code
There are three ways of concurrency management

	01, last in wins
	02, pessimistic concurrency
	03, optimistic concurrency

last in win - in many cases there is only one version of truth. So it doesnt matter who changes or override data. 
Last change will be remainded in the record.

pessmistic concurrency - when the record has been being edited by one person then it will be locked for a while. So the second 
person wont allow to edit while first person finish the job.

optimistic concurrency - check the version and available to edit. before data has been updated it check the concurrency checks.

//--------------------------------------------------------------------------------------------------------------

	Computed Columns

	[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

	with fluent API

	modelBuilder.Entity<Person>()
        .Property(p => p.DisplayName)
        .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");

//--------------------------------------------------------------------------------------------------------------



