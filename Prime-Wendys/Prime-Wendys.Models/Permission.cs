using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("PERMISSION")]
    public class Permission
    {
        [Key]
        public int Per_Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }

        public Role Role { get; set; }
    }
}