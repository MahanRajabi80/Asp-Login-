using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example_22_4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateHyperLink("صفحه ی ورود", "webform1.aspx");
            CreateLabel();
            CreateHyperLink("سایت یاهو", "http://www.yahoo.com");
            CreateLabel();
            CreateHyperLink("سایت گوگل", "http://www.google.com");
            CreateLabel();
            CreateHyperLink("سایت مایکروسافت", "http://www.microsoft.com");
        }
        //------------------------------------------------------
        private void CreateHyperLink(string text, string url)
        {
            HyperLink hyperLink = new HyperLink();
            this.Controls.Add(hyperLink);
            hyperLink.Text = text;
            hyperLink.Font.Size = 16;
            hyperLink.NavigateUrl = url;
        }
        //------------------------------------------------------
        private void CreateLabel()
        {
            Label label = new Label();
            label.Text = "";
            label.Width = 20;
            this.Controls.Add(label);
        }
    }
}