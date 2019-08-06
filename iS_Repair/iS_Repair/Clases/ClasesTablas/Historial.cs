using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Historial
    {
        private string _strIdTelefono;

        public string IdTelefono
        {
            get { return _strIdTelefono; }
            set { _strIdTelefono = value; }
        }

        private string _strIdProblema;

        public string IdProblema
        {
            get { return _strIdProblema; }
            set { _strIdProblema = value; }
        }

    }
}
