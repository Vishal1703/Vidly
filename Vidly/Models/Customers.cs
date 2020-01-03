using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string  Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MemberShipType  MembershipType { get; set; }

        [Display(Name="MemeberShip Type")]
        public byte MembershiptypeId { get; set; }

        [Display(Name="Date Of Birth")]
        public DateTime? BirthDate { get; set; }


    }
}