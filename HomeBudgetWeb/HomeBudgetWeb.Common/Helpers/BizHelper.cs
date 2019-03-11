using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.Common.Helpers
{
    public class BizHelper
    {
        #region Constructors

        public BizHelper()
        {
        }

        #endregion Constructors

        #region Static methods

        public static T GetValue<T>(IDataRecord record, string columnName)
        {
            return GetValue(record, columnName, default(T));
        }

        public static T GetValue<T>(IDataRecord record, string columnName, T defaultValue)
        {
            var fieldExists = false;
            for (int idx = 0; idx < record.FieldCount; idx++)
            {
                if (!record.GetName(idx).Equals(columnName)) continue;
                fieldExists = true;
                break;
            }

            if (!fieldExists) return defaultValue;

            if (record[columnName] == null || record[columnName] == DBNull.Value)
            {
                return defaultValue;
            }

            try
            {
                return (T)record[columnName];
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion Static methods
    }
}
