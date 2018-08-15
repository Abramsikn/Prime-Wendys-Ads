using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("DOOR")]
    public class Door
    {
        [Key]
        public int Door_Id { get; set; }
        public string Door_Type { get; set; }
        public double Door_Price { get; set; }
        public byte[] Door_Picture { get; set; }

        public Wendy Wendy { get; set; }
    }
}
