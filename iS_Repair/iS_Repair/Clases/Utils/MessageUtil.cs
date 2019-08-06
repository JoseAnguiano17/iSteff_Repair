using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Clases.Utils
{
    class MessageUtil
    {
        public static void Information(String message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(String message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Error(String message)
        {
            MessageBox.Show(message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static bool Confirmation(String message)
        {
            DialogResult confirmacion = MessageBox.Show(message, "Confirmation"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

    }
}
