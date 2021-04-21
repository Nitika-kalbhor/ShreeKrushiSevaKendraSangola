using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericBillInfo
{
    class Utility
    {
        public static void ClearSpace(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as ComboBox;
                var datePicker = c as DateTimePicker;
                if (textBox != null)
                    (textBox).Clear();
                if (comboBox != null)
                    comboBox.Text = "";
                if (datePicker != null)
                {
                    datePicker.Text = "";
                }
                if (c.HasChildren)
                    ClearSpace(c);
            }
        }
    }
}
