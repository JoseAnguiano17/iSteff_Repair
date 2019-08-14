using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Pestañas
{
    public partial class Pendientes : UserControl
    {
        MainForm origen;

        public Pendientes(MainForm origen)
        {
            InitializeComponent();
            this.origen = origen;
        }
    }
}
