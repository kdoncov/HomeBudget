using HomeBudgetWeb.DAL;
using HomeBudgetWeb.DAL.Base;
using HomeBudgetWeb.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Korisnik = HomeBudgetWeb.DataObjects.Korisnik;

namespace HomeBudgetWeb.BL
{
    public class KorisnikBL
    {
        public KorisnikBL() { }

        public Korisnik LogIn(string email, string password)
        {
            IDbContext dbContext = new DbContext();
            dbContext.OpenConnection();
            dbContext.BeginTransaction();

            KorisnikBL korisnikBL = new KorisnikBL(); // zasto ovo 
            return korisnikBL.LogIn(email, password); // i ovo
        }
    }
}
