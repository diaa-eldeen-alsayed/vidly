using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Genre
    {
        public byte id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}