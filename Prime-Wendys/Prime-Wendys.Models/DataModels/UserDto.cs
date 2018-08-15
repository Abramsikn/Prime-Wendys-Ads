using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeWendys.Models.DataModels
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string ContactNumber { get; set; }
        public string DoB { get; set; }
        public string Home_Address { get; set; } /* 2111, Something Street */
        public string City { get; set; } /*  */
        public string State { get; set; } /*  */
        public int Zip_Code { get; set; } /*  */
    }
}
