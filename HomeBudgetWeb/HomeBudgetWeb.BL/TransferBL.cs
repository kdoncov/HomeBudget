using HomeBudgetWeb.DAL;
using HomeBudgetWeb.DAL.Base;
using System;
using System.Collections.Generic;
using HomeBudgetWeb.DataObjects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeBudgetWeb.BL
{
    public class TransferBL
    {
        public TransferBL() { }

        public List<MesecniTransferi> MesecniTransferiPrikaz(int IDKorisnika, int mesec, int vrstaTransfera, int podvrstaTransfera, bool prihodRashod)
        {
            List<MesecniTransferi> mesecniTransferi = new List<MesecniTransferi>();

            TransferDAL transferDal = new TransferDAL();
            mesecniTransferi = transferDal.MesecniTransferi(null, IDKorisnika, mesec, vrstaTransfera, podvrstaTransfera, prihodRashod);
            return mesecniTransferi;
            
        }

    }
}
