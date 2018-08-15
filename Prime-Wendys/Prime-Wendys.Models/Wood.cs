using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("WOOD")]
    public class Wood
    {
        [Key]
        public int Wood_Id { get; set; }
        public string Wood_Type { get; set; }
        public string Wood_Desc { get; set; }
        public double Wood_Price { get; set; }
        public byte[] Wood_Picture { get; set; }

        public Wendy Wendy { get; set; }
    }
}