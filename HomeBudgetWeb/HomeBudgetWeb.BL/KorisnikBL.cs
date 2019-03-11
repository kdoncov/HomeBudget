using HomeBudgetWeb.DAL;
using HomeBudgetWeb.DAL.Base;
using HomeBudgetWeb.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Korisnik = HomeBudgetWeb.DataObjects.Korisnik;
using HomeBudgetWeb.Common;
using HomeBudgetWeb.Common.Exceptions;

namespace HomeBudgetWeb.BL
{
    public class KorisnikBL
    {
        public KorisnikBL() { }

        public Korisnik LogIn(string username, string password)
        {
            Korisnik currentUser = new Korisnik();

            KorisnikDAL korisnikDAL = new KorisnikDAL();
            currentUser = korisnikDAL.LogIn(null, username, password);

            return currentUser;
        }

        public int Register(string name, string surname, string username, string password)
        {
            int result = TypeDefaultValue.IntDefaultValue;
            DbContext dbContext = new DbContext();

            try
            {
                dbContext.OpenConnection();
                dbContext.BeginTransaction();

                KorisnikDAL korisnikDAL = new KorisnikDAL();

                bool usernameExist = korisnikDAL.KorisnikProvera(dbContext, username);

                if (usernameExist == true)
                {
                    return result;
                }
                
                int idKorisnika = korisnikDAL.KorisnikInsert(dbContext, name, surname);

                if (idKorisnika > 0)
                {
                    result = KorisnikDAL.LogovanjeInsert(dbContext, idKorisnika, username, password);
                }

                dbContext.Commit();
            }
            catch (LoggedException ex)
            {
                dbContext.RollBack();
                throw ex;
            }
            catch (Exception ex)
            {
                dbContext.RollBack();
                //throw new LoggedException(ExceptionFormatingHelper.OnException(ex, new { registrovaniSubjektId, esvSesijaId }, "ESV.BusinessLogic", "ESVZahtevBL", "NoviZahtev()"), ex);
            }
            finally
            {
                dbContext.CloseConnection();
            }
            return result;
        }
    }
}
