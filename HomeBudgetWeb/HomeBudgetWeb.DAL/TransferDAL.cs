using HomeBudgetWeb.Common.Exceptions;
using HomeBudgetWeb.DAL.Base;
using System;
using System.Collections.Generic;
using HomeBudgetWeb.DataObjects;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudgetWeb.Common;

namespace HomeBudgetWeb.DAL
{
    public class TransferDAL
    {
        #region Constants

        private const string cTransfer_SelectBase = "sp_Transfer_SelectBase";
        private const string cVrstaTransfera_Unos = "sp_VrstaTransfera_Unos";
        private const string cPodvrstaTransfera_Unos = "sp_PodvrstaTransfera_Insert";
        private const string cTransfer_Unos = "sp_Transfer_InsertNew";


        #endregion Constants
        public List<MesecniTransferi> MesecniTransferi(IDbContext dbContext, int IDKorisnika, int mesec, int vrstaTransfera, int podvrstaTransfera, bool prihodRashod)
        {
            

            List<MesecniTransferi> mesecniTransferi = new List<MesecniTransferi>();

            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cTransfer_SelectBase) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmIdKorisnika = cmd.Parameters.Add("@IDKorisnik", SqlDbType.Int);
                prmIdKorisnika.Direction = ParameterDirection.Input;
                prmIdKorisnika.Value = IDKorisnika;

                SqlParameter prmMesec = cmd.Parameters.Add("@Mesec", SqlDbType.Int);
                prmMesec.Direction = ParameterDirection.Input;
                prmMesec.Value = mesec;

                SqlParameter prmVrstaTransfera = cmd.Parameters.Add("@VrstaTransfera", SqlDbType.Int);
                prmVrstaTransfera.Direction = ParameterDirection.Input;
                prmVrstaTransfera.Value = vrstaTransfera;

                SqlParameter prmPodvrstaTransfera = cmd.Parameters.Add("@PodvrstaTransfera", SqlDbType.Int);
                prmPodvrstaTransfera.Direction = ParameterDirection.Input;
                prmPodvrstaTransfera.Value = podvrstaTransfera;

                SqlParameter prmPrihodRashod = cmd.Parameters.Add("@PrihodRashod", SqlDbType.Bit);
                prmPrihodRashod.Direction = ParameterDirection.Input;
                prmPrihodRashod.Value = prihodRashod;

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
                            mesecniTransferi.Add(new MesecniTransferi(reader));
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

            return mesecniTransferi;
        }

        public int NovaPodvrstaTransfera(IDbContext dbContext, int idVrsteTransfera, string opis)
        {
            int numberOfRowsInserted = TypeDefaultValue.IntDefaultValue;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cPodvrstaTransfera_Unos) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmIdVrsteTransfera = cmd.Parameters.Add("IDVrstaTransfera", SqlDbType.Int);
                prmIdVrsteTransfera.Direction = ParameterDirection.Input;
                prmIdVrsteTransfera.Value = idVrsteTransfera;

                SqlParameter prmOpis = cmd.Parameters.Add("@Opis", SqlDbType.NVarChar);
                prmOpis.Direction = ParameterDirection.Input;
                prmOpis.Value = opis;



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

        public int NovaVrstaTransfera(IDbContext dbContext, int id, int prihodRashod, string opis)
        {
            int numberOfRowsInserted = TypeDefaultValue.IntDefaultValue;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cTransfer_SelectBase) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmPrihodRashod = cmd.Parameters.Add("@PrihodRashod", SqlDbType.Int);
                prmPrihodRashod.Direction = ParameterDirection.Input;
                prmPrihodRashod.Value = prihodRashod;

                SqlParameter prmOpis = cmd.Parameters.Add("@Opis", SqlDbType.NVarChar);
                prmOpis.Direction = ParameterDirection.Input;
                prmOpis.Value = opis;



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

        public int UnosTransfera(IDbContext dbContext, int IdKorisnika, string datum, int podvrstaTransfera, float iznos)
        {
            DateTime noviDatum = DateTime.Parse(datum);
            int numberOfRowsInserted = TypeDefaultValue.IntDefaultValue;
            var isTransaction = true;

            try
            {
                var cmd = new SqlCommand(cTransfer_Unos) { CommandType = CommandType.StoredProcedure };

                #region Populate Parameters

                SqlParameter prmIdKorisnika = cmd.Parameters.Add("@IDKorisnik", SqlDbType.Int);
                prmIdKorisnika.Direction = ParameterDirection.Input;
                prmIdKorisnika.Value = IdKorisnika;
                
                SqlParameter prmDatum = cmd.Parameters.Add("@Datum", SqlDbType.DateTime);
                prmDatum.Direction = ParameterDirection.Input;
                prmDatum.Value = noviDatum;

                SqlParameter prmPodvrstaTransfera = cmd.Parameters.Add("@PodvrstaTransfera", SqlDbType.Int);
                prmPodvrstaTransfera.Direction = ParameterDirection.Input;
                prmPodvrstaTransfera.Value = podvrstaTransfera;

                SqlParameter prmIznos = cmd.Parameters.Add("@Iznos", SqlDbType.Float);
                prmIznos.Direction = ParameterDirection.Input;
                prmIznos.Value = iznos;

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

    }

}
