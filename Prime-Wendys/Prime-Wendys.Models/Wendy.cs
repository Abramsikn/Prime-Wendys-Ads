using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrimeWendys.Models
{
    [Table("WENDY")]
    public class Wendy
    {
        [Key]
        public int Wendy_Id { get; set; }
        public string Size { get; set; }
        public int NumOfRooms { get; set; }
        public double Wendy_Type { get; set; }
        public double Price { get; set; }
        public byte[] Picture { get; set; }

        [ForeignKey("Wood")]
        public int Wood_Id { get; set; }
        
        public Wood Wood { get; set; } /* The relationship is 1 to 1 to Wood Table */

    }
}