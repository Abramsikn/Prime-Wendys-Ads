using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeWendys.Models.DataModels
{
    public class DoorDto
    {
        public string Door_Type { get; set; }
        public double Door_Price { get; set; }
        public byte[] Door_Picture { get; set; }
    }
}
