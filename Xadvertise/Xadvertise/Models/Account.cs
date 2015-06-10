using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xadvertise.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string CompanyName { get; set; }
        public string Manager { get; set; }
        public string ManagerContact { get; set; }
        public DateTime StartDate { get; set; }
        public double Cost { get; set; }

    }
}