using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.DataObjects
{
    public class Korisnik
    {
        #region Private fields

        private long? mID;
        private string mIme;
        private string mPrezime;

        #endregion Private fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Korisnik class.
        /// </summary>
        public Korisnik()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Korisnik class and populates properties from data reader.
        /// </summary>
        /// <param name="reader">SQL data reader</param>
        public Korisnik(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        #endregion Constructors

        #region Properties

        public long? ID
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Ime
        {
            get { return mIme; }
            set { mIme = value; }
        }

        public string Prezime
        {
            get { return mPrezime; }
            set { mPrezime = value; }
        }

        #endregion Properties

        #region Non-virtual methods

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                //ID = GetValueHelper.GetValue<long>(reader, "KorisnikID");
                //Ime = GetValueHelper.GetValue<string>(reader, "Ime");
                //Prezime = GetValueHelper.GetValue<string>(reader, "Prezime");
                ID = (long)reader["KorisnikID"];
                Ime = reader["Ime"].ToString();
                Prezime = reader["Prezime"].ToString();
            }
        }

        #endregion Non-virtual methods
    }
}

