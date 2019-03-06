using HomeBudgetWeb.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeBudgetWeb.HomeBudgetWebServiceReference;

namespace HomeBudgetWeb

{
    public partial class Login : System.Web.UI.Page
    {
        private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            HomeBudgetWebServiceReference.Korisnik korisnik = wsProxy.KorisnikLogIn(TextBoxUsername.Text, TextBoxPassword.Text);
        }
    }
}