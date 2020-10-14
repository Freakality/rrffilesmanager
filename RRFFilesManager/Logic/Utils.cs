using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Logic
{
    public class Utils
    {
        public static void SetComboBoxDataSource(ComboBox comboBox, object dataSource, string displayMember = null)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.SelectedItem = null;
        }
    }
}
