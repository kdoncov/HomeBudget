using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeBudgetWeb
{
    public partial class Login : System.Web.UI.Page
    {
        private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            HomeBudgetWebServiceReference.Korisnik korisnik = wsProxy.KorisnikLogIn(txtUsername.Text, txtPassword.Text);
            Response.Write("Ulogovani korisnik je " + korisnik.Ime + " " + korisnik.Prezime);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int result = wsProxy.KorisnikRegister(txtName.Text, txtSurname.Text, txtUsernameRegister.Text, txtPasswordRegister.Text);
            System.Web.UI.HtmlControls.HtmlInputRadioButton radioBtn2 = tab2 as System.Web.UI.HtmlControls.HtmlInputRadioButton;

            if (result == 1)
            {
                Response.Write("uspesno ste se registrovali");
            }
            else
            {
                
                radioBtn2.Checked = true;
                lblUsername.Text = "unesite drugo korisnicko ime";
                lblUsername.Visible = true;
            }
        }
    }
}