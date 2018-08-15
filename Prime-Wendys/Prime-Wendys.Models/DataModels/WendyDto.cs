using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeWendys.Models.DataModels
{
    public class WendyDto
    {
        public string Size { get; set; }
        public int NumOfRooms { get; set; }
        public double Price { get; set; }
        public double Wendy_Type { get; set; }
        public byte[] Picture { get; set; }
        
        public WoodDto Wood { get; set; }   /* What's the meaning of this?*/
    }
}
