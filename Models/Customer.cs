using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Videly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribToNewsLetter { get; set; }
        public MembershipType MembershipTypes { get; set; }
        /*
         This is what we call and navigation property because it allows us
         to navigate from one type to another,In this case from customer to
         it's membership type these navigation properties are useful when you
         want.to load an object and its related objects together from a
         database.For example we can load the customer and its membership
         type together.*/
        //public byte MemberShipId { get; set; }

    }
}