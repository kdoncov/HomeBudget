using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeBudgetWeb
{
    
    public partial class MesecniPrihodi : System.Web.UI.Page
    {
        private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            HomeBudgetWebServiceReference.MesecniTransferi[]  result = wsProxy.MesecniTransferi(1, 1, 1, 1, true);

            gvMesecniPrihodi.DataSource = result.ToList();
            gvMesecniPrihodi.DataBind();

        }

    }
}