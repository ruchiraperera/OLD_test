using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    [Table("Student", Schema = "dbo")] // Table name defined and database schema defined....
    public class Student
    {
        // [Key] you dont need to use both key and Database generate attributes
        [Column("StudentId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //check Readme to know different options
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime RegisteredDate { get; set; }
        [NotMapped] // will not mapped to database table
        public string LoggingId { get; set; }
        [InverseProperty("PayId")] // this will provide list of PayIds
        public ICollection<StudentPayment> Payments { get; set; }        
    }

    [Table("PaymentHistory", Schema = "Finance")]
    public class StudentPayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int PayId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public decimal PaymentAmount { get; set; }
        [Timestamp] // this would be checked in concurrency check (optimistic concurrency)..
        public byte[] RowVersion { get; set; }
    }
}
