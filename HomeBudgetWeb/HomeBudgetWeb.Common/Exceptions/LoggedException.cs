using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.Common.Exceptions
{
        public class LoggedException : Exception
        {
            #region Constructors

            public LoggedException() : base()
            { }

            public LoggedException(string message) : base(message)
            { }

            public LoggedException(string message, params object[] args)
                : base(string.Format(message, args))
            { }

            public LoggedException(string message, Exception innerException)
                : base(message, innerException)
            { }

            public LoggedException(string message, Exception innerException, params object[] args)
                : base(string.Format(message, args), innerException)
            { }

            #endregion Constructors
        }
    }

