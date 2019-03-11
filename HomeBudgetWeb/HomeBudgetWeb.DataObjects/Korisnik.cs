using HomeBudgetWeb.Common;
using HomeBudgetWeb.Common.Helpers;
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

        public Korisnik(IDataRecord dataRecord)
        {
            mID = BizHelper.GetValue(dataRecord, "IDKorisnik", TypeDefaultValue.IntDefaultValue);
            mIme = BizHelper.GetValue(dataRecord, "Ime", TypeDefaultValue.StringDefaultValue);
            mPrezime = BizHelper.GetValue(dataRecord, "Prezime", TypeDefaultValue.StringDefaultValue);
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

        #endregion Non-virtual methods
    }
}

