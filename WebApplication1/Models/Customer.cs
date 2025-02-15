﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsSubscribeToNewsletter { get; set; }

        public MembershipType Membership { get; set; }
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthday { get; set; }
        public Genre Genre { get; set; }

    }
}