using HomeBudgetWeb.BL;
using HomeBudgetWeb.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HomeBudgetWeb.WS
{
    /// <summary>
    /// Summary description for HomeBudgetWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HomeBudgetWebService : System.Web.Services.WebService
    {
        /// <summary>
        /// Metod za logovanje korisnika, vraca podatke o korisniku (ime i prezime)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [WebMethod]
        public Korisnik KorisnikLogIn(string username, string password)
        {
            KorisnikBL korisnikBL = new KorisnikBL();
            return korisnikBL.LogIn(username, password);
        }
        
        /// <summary>
        /// Metod za registrovanje korisnika, vraca podatak o upisanom redu
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [WebMethod]
        public int KorisnikRegister(string name, string surname, string username, string password)
        {
            KorisnikBL korisnikBL = new KorisnikBL();
            return korisnikBL.Register(name, surname, username, password);
        }
        
        /// <summary>
        /// Metod za prikaz mesecnih transfera, vraca listu objekata
        /// </summary>
        /// <param name="IDKorisnika"></param>
        /// <param name="mesec"></param>
        /// <param name="vrstaTransfera"></param>
        /// <param name="podvrstaTransfera"></param>
        /// <param name="prihodRashod"></param>
        /// <returns></returns>
        [WebMethod]
        public List<MesecniTransferi> MesecniTransferi(int IDKorisnika, int mesec, int vrstaTransfera, int podvrstaTransfera, bool prihodRashod)
        {
            TransferBL mesecniTransferiBL = new TransferBL();
            return mesecniTransferiBL.MesecniTransferiPrikaz(IDKorisnika, mesec, vrstaTransfera, podvrstaTransfera, prihodRashod);
        }
        
        /// <summary>
        /// Metod za unos nove vrste transfera
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prihodRashod"></param>
        /// <param name="opis"></param>
        /// <returns></returns>
        [WebMethod]

        public int NovaVrstaTransfera(int id, int prihodRashod, string opis)
        {
            TransferBL novaVrstaTransferaBL = new TransferBL();
            return novaVrstaTransferaBL.NovaVrstaTransfera(id, prihodRashod, opis);
        }

        /// <summary>
        /// Metod za unos nove podvrste transfera
        /// </summary>
        /// <param name="idVrsteTransfera"></param>
        /// <param name="opis"></param>
        /// <returns></returns>
        [WebMethod]
        public int UnosPodvrsteTransfera(int idVrsteTransfera, string opis)
        {
            TransferBL novaPodvrstaTransferaBL = new TransferBL();
            return novaPodvrstaTransferaBL.NovaPovrstaTransfera(idVrsteTransfera, opis);
        }

        /// <summary>
        /// Metod za unos novog transfera
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datum"></param>
        /// <param name="idPodvrsteTransfera"></param>
        /// <param name="iznos"></param>
        /// <returns></returns>
        [WebMethod]

        public int UnosTransfera(int idKorisnika, string datum, int idPodvrsteTransfera, float iznos)
        {
            TransferBL unosTransferaBL = new TransferBL();
            return unosTransferaBL.UnosTransfera(idKorisnika, datum, idPodvrsteTransfera, iznos);
        }





    }
}
