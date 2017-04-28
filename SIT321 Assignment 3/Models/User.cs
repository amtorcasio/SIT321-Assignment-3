using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIT321_Assignment_3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Type { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}