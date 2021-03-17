using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Logic
{
    public static class Extensions
    {
        public static DateTime? ToNullable(this DateTime value)
        {
            if (value == default)
                return null;
            return value;
        }

        public static DateTime? ToNullableValue(this DateTimePicker datetimepicker)
        {
            if (!datetimepicker.Checked || !datetimepicker.Enabled)
                return null;
            return datetimepicker.Value.ToNullable();
        }
    }
}
