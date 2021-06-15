using System;
using System.Collections.Generic;
using System.Text;

namespace Ic_june2021
{
    public class User
    {
        public static string AcessLevel { get; set; }
        public User() { }

        public User(string email, string password)
        {   this.email=email;
            this.password=password;

        }
        public string email { get; set; }
        public string password { get; set; }
    }
    }






