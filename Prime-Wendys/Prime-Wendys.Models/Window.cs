using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("WINDOW")]
    public class Window
    {
        [Key]
        public int Win_Id { get; set; }
        public string Win_Type { get; set; }
        public double Win_Price { get; set; }
        public byte[] Win_Picture { get; set; }

        public Wendy Wendy { get; set; }
    }
}