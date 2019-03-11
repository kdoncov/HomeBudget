﻿using HomeBudgetWeb.BL;
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

        [WebMethod]
        public Korisnik KorisnikLogIn(string username, string password)
        {
            KorisnikBL korisnikBL = new KorisnikBL();
            return korisnikBL.LogIn(username, password);
        }

        [WebMethod]
        public int KorisnikRegister(string name, string surname, string username, string password)
        {
            KorisnikBL korisnikBL = new KorisnikBL();
            return korisnikBL.Register(name, surname, username, password);
        }




    }
}
