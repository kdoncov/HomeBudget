using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.Common
{
    public static class TypeDefaultValue
    {
        #region Constants

        public const string TextBoxBindingPropertyName = "Text";
        public const string DateControlBindingPropertyName = "Value";
        public const string ComboBoxControlBindingPropertyName = "Selected";
        public const string CheckBoxBindingPropertyName = "Checked";
        public const string DecimalTextBoxBindingPropertyName = "Value";
        public const string NumericTextBoxBindingPropertyName = "Value";
        public const string DoubleTextBoxBindingPropertyName = "Value";
        public const string ComboBoxControlByValueBindingPropertyName = "SelectedByValue";
        public const string IntTextBoxBindingPropertyName = "Value";
        public const string GodinaEditorBindingPropertyName = "Value";
        public const string ShortTextBoxBindingPropertyName = "Value";

        public const string StringDefaultValue = "";
        public const int IntDefaultValue = int.MinValue;
        public const int IntInvalidValue = int.MaxValue;
        public static readonly Guid GuidDefaultValue = Guid.Empty;

        #endregion Constants

        #region Static fields

        private static readonly string TheStringDefaultValue = String.Empty;
        private const long TheLongDefaultValue = long.MinValue;
        private const long TheLongInvalidValue = long.MaxValue;
        private const short TheShortDefaultValue = short.MinValue;
        private const short TheShortInvalidValue = short.MaxValue;
        private const decimal TheDecimalDefaultValue = decimal.MinValue;
        private const decimal TheDecimalInvalidValue = decimal.MaxValue;
        private const bool TheBooleanDefaultValue = false;
        private static readonly DateTime TheDateTimeDefaultValue = DateTime.MinValue;
        private static readonly DateTime TheDateTimeInvalidValue = DateTime.MaxValue;
        private static readonly DateTime TheDateTimeCurrentValue = DateTime.Now;
        private static readonly byte[] TheByteDefaultValue = null;
        private const double TheDoubleDefaultValue = double.MinValue;
        private const double TheDoubleInvalidValue = double.MaxValue;
        private const float TheFloatDefaultValue = float.MinValue;

        #endregion Static fields

        #region Static methods

        public static decimal DecimalDefaultValue
        {
            get
            {
                return TheDecimalDefaultValue;
            }
        }

        public static decimal DecimalInvalidValue
        {
            get
            {
                return TheDecimalInvalidValue;
            }
        }

        public static double DoubleDefaultValue
        {
            get
            {
                return TheDoubleDefaultValue;
            }
        }

        public static double DoubleInvalidValue
        {
            get
            {
                return TheDoubleInvalidValue;
            }
        }

        public static long LongDefaultValue
        {
            get
            {
                return TheLongDefaultValue;
            }
        }

        public static long LongInvalidValue
        {
            get
            {
                return TheLongInvalidValue;
            }
        }

        public static short ShortDefaultValue
        {
            get { return TheShortDefaultValue; }
        }

        public static short ShortInvalidValue
        {
            get { return TheShortInvalidValue; }
        }

        public static bool BooleanDefaultValue
        {
            get { return TheBooleanDefaultValue; }
        }

        public static DateTime DateTimeDefaultValue
        {
            get
            {
                return TheDateTimeDefaultValue;
            }
        }

        public static DateTime DateTimeInvalidValue
        {
            get
            {
                return TheDateTimeInvalidValue;
            }
        }

        public static DateTime DateTimeCurrentValue
        {
            get
            {
                return TheDateTimeCurrentValue;
            }
        }

        public static byte[] ByteDefaultValue
        {
            get
            {
                return TheByteDefaultValue;
            }
        }

        public static float FloatDefaultValue
        {
            get
            {
                return TheFloatDefaultValue;
            }
        }

        public static object GetTypeDefaultValue(Type type)
        {
            if (type == typeof(short))
            {
                return ShortDefaultValue;
            }
            if (type == typeof(int))
            {
                return IntDefaultValue;
            }
            if (type == typeof(long))
            {
                return LongDefaultValue;
            }
            if (type == typeof(DateTime))
            {
                return DateTimeDefaultValue;
            }
            if (type == typeof(bool))
            {
                return BooleanDefaultValue;
            }
            if (type == typeof(string))
            {
                return StringDefaultValue;
            }
            if (type == typeof(decimal))
            {
                return DecimalDefaultValue;
            }
            if (type == typeof(float))
            {
                return FloatDefaultValue;
            }
            return null;
        }

        #endregion Static methods
    }
}
