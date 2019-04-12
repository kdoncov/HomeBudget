using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HomeBudgetWeb
{
    public class FilterEnum
    {

        //private HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient wsProxy = new HomeBudgetWebServiceReference.HomeBudgetWebServiceSoapClient();
        //private Boolean m_vrsta;

        enum Mesec { Januar = 0, Februar, Mart, April, Maj, Jun, Jul, Avgust, Septembar, Oktobar, Novembar, Decembar };
        Type Meseci = typeof(Mesec);
        

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FilterEnum() { }

        /// <summary>
        /// popunjava listu meseci
        /// </summary>
        /// <param name="listaMesec"></param>
        public void PopuniMesec(DropDownList listaMesec)
        {
            listaMesec.Items.Clear();
            listaMesec.Items.Add("---");
            foreach (string naziv in Enum.GetNames(Meseci))
                listaMesec.Items.Add(naziv);
        }

    }
}