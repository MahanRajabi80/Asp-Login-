using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example_22_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName == "admin" && Login1.Password == "admin")
                Response.Redirect("WebForm2.aspx");
        }
    }
}