using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("USER")]
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string ContactNumber { get; set; }
        public string DoB { get; set; }
        public string Home_Address { get; set; } /* 2111, Something Strees */
        public string City { get; set; }
        public string State { get; set; }
        public int Zip_Code { get; set; }
        
        public ICollection<Role> Role { get; set; }
        public ICollection<Wendy> Wendys { get; set; }
    }
}
