using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeBudgetWeb
{
    public partial class Register : System.Web.UI.Page
        
    {
    private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int result = wsProxy.KorisnikRegister(txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text);
            
            if (result == 1)
            {
                Response.Write("uspesno ste se registrovali");
            }
            else
            {
                lblUsername.Text = "unesite drugo korisnicko ime";
                lblUsername.Visible = true;
            }
            
                
            
        }

        protected void lnkBtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}