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
    public class MesecniTransferi
    {
        #region Private fields

        private int mID; 
        private string mDatum;
        private int mVrstaTransfera;
        private string mVrstaTransferaOpis;
        private int mPodvrstaTransfera;
        private string mPodvrstaTransferaOpis;
        private int mIznos;

        #endregion Private fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the MesecniPrihodi class.
        /// </summary>
        public MesecniTransferi()
        {
        }
        public MesecniTransferi(IDataRecord dataRecord)
        {
            mID = BizHelper.GetValue(dataRecord, "IDKorisnik", TypeDefaultValue.IntDefaultValue);
            mDatum = BizHelper.GetValue(dataRecord, "Datum", TypeDefaultValue.StringDefaultValue);
            mVrstaTransfera = BizHelper.GetValue(dataRecord, "VrstaTransfera", TypeDefaultValue.IntDefaultValue);
            mVrstaTransferaOpis = BizHelper.GetValue(dataRecord, "VrstaTransferaOpis", TypeDefaultValue.StringDefaultValue);
            mPodvrstaTransfera = BizHelper.GetValue(dataRecord, "PodvrstaTransfera", TypeDefaultValue.IntDefaultValue);
            mPodvrstaTransferaOpis = BizHelper.GetValue(dataRecord, "PodvrstaTransferaOpis", TypeDefaultValue.StringDefaultValue);
            mIznos = BizHelper.GetValue(dataRecord, "Iznos", TypeDefaultValue.IntDefaultValue);
        }

        #endregion Constructors

        #region Properties

        public int Id
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Datum
        {
            get { return mDatum; }
            set { mDatum = value; }
        }

        public int VrstaTransfera
        {
            get { return mVrstaTransfera; }
            set { mVrstaTransfera = value; }
        }

        public string VrstaTransferaOpis
        {
            get { return mVrstaTransferaOpis; }
            set { mVrstaTransferaOpis = value; }
        }

        public int PodvrstaTransfera
        {
            get { return mPodvrstaTransfera; }
            set { mPodvrstaTransfera = value; }
        }

        public string PodvrstaTransferaOpis
        {
            get { return mPodvrstaTransferaOpis; }
            set { mPodvrstaTransferaOpis = value; }
        }
        public int Iznos
        {
            get { return mIznos; }
            set { mIznos = value; }
        }
        #endregion Properties
    }
}
