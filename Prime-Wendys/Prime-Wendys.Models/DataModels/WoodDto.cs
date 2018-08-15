using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeWendys.Models.DataModels
{
    public class WoodDto
    {
        public string Wood_Type { get; set; } 
        public string Wood_Desc { get; set; }
        public double Wood_Price { get; set; }
        public byte[] Wood_Picture { get; set; }
    }
}
