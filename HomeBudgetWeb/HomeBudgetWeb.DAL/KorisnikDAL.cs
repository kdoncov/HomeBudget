using HomeBudgetWeb.Common;
using HomeBudgetWeb.Common.Exceptions;
using HomeBudgetWeb.DAL.Base;
using HomeBudgetWeb.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.DAL
{
    #region Class KorisnikDAL

    /// <summary>
    /// Summary description for KorisnikDAL
    /// </summary>
    public class KorisnikDAL
    {
        #region Constants

        private const string cLogovanje_GetByidKorisnik = "sp_Login_getByidKorisnik";
        private const string cKorisnik_Insert = "sp_Korisnik_Insert";
        private const string cLogovanje_Insert = "sp_Logovanje_Insert";
        private const string cLogovanje_Provera = "sp_Logovanje_KorisnickoImeProvera"; ///"SELECT * FROM Logovanje WHERE KorisnickoIme = @KorisnickoIme"; ///novo


        #endregion Constants

        #region Non-virtual methods

        /// <summary>
        /// Prijava u aplikaciju
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="dbContext">Db context</param>
        /// <returns>Current user</returns>
        public Korisnik LogIn(IDbContext dbContext, string username, string password)
        {
            Korisnik currentUser = new Korisnik();
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cLogovanje_GetByidKorisnik) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmUsername = cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar);
                prmUsername.Size = 50;
                prmUsername.Direction = ParameterDirection.Input;
                prmUsername.Value = username;

                SqlParameter prmPassword = cmd.Parameters.Add("@Lozinka", SqlDbType.NVarChar);
                prmPassword.Size = 50;
                prmPassword.Direction = ParameterDirection.Input;
                prmPassword.Value = password;

                #endregion Populate Parameters

                if (dbContext == null)
                {
                    dbContext = new DbContext();
                    dbContext.OpenConnection();
                    isTransaction = false;
                }

                cmd.Transaction = dbContext.Transaction;
                cmd.Connection = dbContext.Connection;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    if (((SqlDataReader)reader).HasRows)
                    {
                        while (reader.Read())
                        {
                            currentUser = new Korisnik(reader);
                        }
                    }
                }
            }
            catch (LoggedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                //throw new LoggedException(ExceptionFormatingHelper.OnException(ex, new { idZahteva }, "ESV.DataAccess", "ESVZahtevDAL", "PregledZahtevaPoId()"), ex);
                throw ex;
            }
            finally
            {
                if (!isTransaction)
                    dbContext.CloseConnection();
            }

            return currentUser;
        }

        /// <summary>
        /// Provera korisnickog imena
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool KorisnikProvera(IDbContext dbContext, string username)
        {
            bool usernameExist = false;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cLogovanje_Provera) { CommandType = CommandType.StoredProcedure };

                SqlParameter prmUsername = cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar);
                prmUsername.Size = 50;
                prmUsername.Direction = ParameterDirection.Input;
                prmUsername.Value = username;

                cmd.Transaction = dbContext.Transaction;
                cmd.Connection = dbContext.Connection;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    if (((SqlDataReader)reader).HasRows)
                    {
                        usernameExist = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!isTransaction)
                    dbContext.CloseConnection();
            }

            return usernameExist;
        }
        
        /// <summary>
        /// Registracija novog korisnika
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int KorisnikInsert(IDbContext dbContext, string name, string surname)
        {
            int idKorisnika = TypeDefaultValue.IntDefaultValue;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cKorisnik_Insert) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmName = cmd.Parameters.Add("@Ime", SqlDbType.NVarChar);
                prmName.Size = 50;
                prmName.Direction = ParameterDirection.Input;
                prmName.Value = name;

                SqlParameter prmSurname = cmd.Parameters.Add("@Prezime", SqlDbType.NVarChar);
                prmSurname.Size = 50;
                prmSurname.Direction = ParameterDirection.Input;
                prmSurname.Value = surname;
                

                #endregion Populate Parameters

                if (dbContext == null)
                {
                    dbContext = new DbContext();
                    dbContext.OpenConnection();
                    isTransaction = false;
                }
                
                cmd.Transaction = dbContext.Transaction;
                cmd.Connection = dbContext.Connection;

                idKorisnika = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!isTransaction)
                    dbContext.CloseConnection();
            }
            
            return idKorisnika;
        }
        
        /// <summary>
        /// Upis u tabelu Logovanje
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="idKorisnik"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static int LogovanjeInsert(DbContext dbContext, int idKorisnik, string username, string password)
        {
            int numberOfRowsInserted = TypeDefaultValue.IntDefaultValue;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cLogovanje_Insert) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmIDKorisnik = cmd.Parameters.Add("@IDKorisnik", SqlDbType.Int);
                prmIDKorisnik.Direction = ParameterDirection.Input;
                prmIDKorisnik.Value = idKorisnik;

                SqlParameter prmName = cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar);
                prmName.Size = 50;
                prmName.Direction = ParameterDirection.Input;
                prmName.Value = username;

                SqlParameter prmSurname = cmd.Parameters.Add("@Lozinka", SqlDbType.NVarChar);
                prmSurname.Size = 50;
                prmSurname.Direction = ParameterDirection.Input;
                prmSurname.Value = password;


                #endregion Populate Parameters

                if (dbContext == null)
                {
                    dbContext = new DbContext();
                    dbContext.OpenConnection();
                    isTransaction = false;
                }

                cmd.Transaction = dbContext.Transaction;
                cmd.Connection = dbContext.Connection;

                numberOfRowsInserted = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!isTransaction)
                    dbContext.CloseConnection();
            }
            
            return numberOfRowsInserted;
        }

        #endregion Non-virtual methods
    }

    #endregion Class KorisnikDAL
}
