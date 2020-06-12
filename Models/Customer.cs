using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore_AzureSQL.Models
{
    [Table("Customer", Schema = "SalesLT")]
    public class Customer
    {
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        // TODO: add other properties to map the corresponding database fields
    }
}
