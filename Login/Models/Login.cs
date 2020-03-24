using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Login
    {

        public bool ValidateDatabase(string user, string password)
        {
            // SQL linq
            /* 
            
            var user = from x in login where  
               (x.user == user)  && (x.password == password)) select x;
            
            bool envio = (user.Count == 1) ? true : false;

            */

            return true;

        }
    }
}