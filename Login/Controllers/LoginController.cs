using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        string message = "Error Login, please check information";

        // Get Data from Web
        // Params user, password
        public ActionResult AuthData(FormCollection form)
        {
            string user = form["user"];
            string password = form["password"];

            bool login_response = ValidateData(user, password);
            string view_response = ViewRedirect(login_response);

            // Redirect to HomeController
            // Login = true   Redirect to view_response Action Method Admin
            // Login = false  Redirect to view_response Action Method Home
            return RedirectToAction(view_response , "Home" , new { message = this.message });
        }

        // Validate Data in data base
        public Boolean ValidateData(string user, string password)
        {
            // Call Model Data Base


            //Login oLogin = new Login();
            // bool login_response = oLogin.ValidateDatabase(user, password);

            bool login_response = (user == "prueba" && password == "prueba") ? true : false;
            return login_response;
        }

        // Redirect View
        public String ViewRedirect(bool login_response)
        {
            String redirect = (login_response) ? "Admin" : "Index";
            return redirect;

        }
    }
}