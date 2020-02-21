using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Create_WebApps_in_Core.Models
{

    [Table("tbl_Student",Schema ="dbo")]
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("StudentName",Order =2,TypeName ="varchar(200)")]
        public string Name { get; set; }
        [Column("RegisteredDate")]
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public string LoggedTime { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
