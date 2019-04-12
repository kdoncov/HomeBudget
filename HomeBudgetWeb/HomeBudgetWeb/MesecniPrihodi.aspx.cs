using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeBudgetWeb.DataObjects;

namespace HomeBudgetWeb
{
    
    public partial class MesecniPrihodi : System.Web.UI.Page
    {
        private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();
        private FilterEnum objPopuniGodinu = new FilterEnum();


        protected void Page_Load(object sender, EventArgs e)
        {
            List<MesecniTransferi> result = new List<MesecniTransferi>();
            int ID = Convert.ToInt32(Session["CurrentUser"]); //prosleđuje id ulogovanog korisnika
            //result = wsProxy.MesecniTransferi(ID, 1, 1, 1, true);

            
            //HomeBudgetWebServiceReference.Filters[] filterResults = wsProxy.PopuniFilter(id, prihodRashod);
            //wsProxy.PopuniVrstePrihoda();
            //wsProxy.PopuniPodvrstePrihoda();      
            objPopuniGodinu.PopuniMesec(dpdMesec);                      ///popunjavanje filtera

            
            gvMesecniPrihodi.DataSource = result.ToList();
            gvMesecniPrihodi.DataBind();

        }

        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Session["CurrentUser"]);
            string datum = inpDate.Value.ToString();
            float iznos = (float)Convert.ToDouble(txtAmount.Text);

            int result = wsProxy.UnosTransfera(ID, inpDate.Value, txtTypeTransfer.Text, txtTransferSubtype.Text, iznos);

            

        }
    }
}