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

        /// <summary>
        /// Prikaz mesecnih transfera 
        /// </summary>
        /// <param name="IDKorisnika"></param>
        /// <param name="mesec"></param>
        /// <param name="vrstaTransfera"></param>
        /// <param name="podvrstaTransfera"></param>
        /// <param name="prihodRashod"></param>
        /// <returns></returns>
        public List<MesecniTransferi> MesecniTransferiPrikaz(int IDKorisnika, int mesec, int vrstaTransfera, int podvrstaTransfera, bool prihodRashod)
        {
            List<MesecniTransferi> mesecniTransferi = new List<MesecniTransferi>();

            TransferDAL transferDal = new TransferDAL();
            mesecniTransferi = transferDal.MesecniTransferi(null, IDKorisnika, mesec, vrstaTransfera, podvrstaTransfera, prihodRashod);
            return mesecniTransferi;
            
        }

        /// <summary>
        /// Dodavanje nove vrste transfera
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prihodRashod"></param>
        /// <param name="opis"></param>
        /// <returns></returns>
        public int NovaVrstaTransfera(int id, int prihodRashod, string opis)
        {
            TransferDAL novaVrstaTransferaDAL = new TransferDAL();
            return novaVrstaTransferaDAL.NovaVrstaTransfera(null, id, prihodRashod, opis);
        }

        /// <summary>
        /// Unos novog transfera
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="transferType"></param>
        /// <param name="transferSubType"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int UnosTransfera(int idKorisnika, string datum, int idPodvrsteTransfera, float iznos)
        {
            TransferDAL unosTransferaDAL = new TransferDAL();
            return unosTransferaDAL.UnosTransfera(null, idKorisnika, datum, idPodvrsteTransfera, iznos);
            
        }


        /// <summary>
        /// Unos nove podvrste transfera
        /// </summary>
        /// <param name="idVrsteTransfera"></param>
        /// <param name="opis"></param>
        /// <returns></returns>
        public int NovaPovrstaTransfera(int idVrsteTransfera, string opis)
        {
            TransferDAL novaPodvrstaTransferaDAL = new TransferDAL();
            return novaPodvrstaTransferaDAL.NovaPodvrstaTransfera(null, idVrsteTransfera, opis);
        }
    }
}
