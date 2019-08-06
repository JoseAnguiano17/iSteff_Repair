using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    class Recibido
    {
        private string _strIdCliente;

        public string IdCliente
        {
            get { return _strIdCliente; }
            set { _strIdCliente = value; }
        }

        private string _strIdTelefono;

        public string IdTelefono
        {
            get { return _strIdTelefono; }
            set { _strIdTelefono = value; }
        }

    }
}
