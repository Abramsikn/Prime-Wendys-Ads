using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("ROLE")]
    public class Role
    {
        [Key]
        public int Role_Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }

        public User User { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}
