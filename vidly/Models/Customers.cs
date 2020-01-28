using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customers
    {
       public int id { get; set; }
        [Required]
        [StringLength(255)]
        public String name { get; set; }
        public DateTime? birthdate { get; set; }
        public bool isSubscribedTnNewsletters { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}