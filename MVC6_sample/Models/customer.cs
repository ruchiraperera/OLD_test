using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC6_sample.Models
{

    //No, you cannot have two partial classes referring to the same class in two different assemblies 

    [MetadataType(typeof(customerMetaData))]
    public partial class tbl_customer { }


    public class customerMetaData {

        [Key]
        public int cus_id { get; set; }

        [Display(Name = "Customer Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Customer name is required")]
        public string name { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [Display(Name = "Data of Birth")]
        [UIHint("Birthday")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public Nullable<System.DateTime> dob { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<System.DateTime> createdDate { get; set; }
    }


}