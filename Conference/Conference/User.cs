using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Kind { get; set; }
    }
}