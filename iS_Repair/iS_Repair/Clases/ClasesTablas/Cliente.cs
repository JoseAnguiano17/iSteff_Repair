using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases
{
    class Cliente
    {
        private string _strID;

        public string ID
        {
            get { return _strID; }
            set { _strID = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strNumeroTelefono;

        public string NumeroTelefono
        {
            get { return _strNumeroTelefono; }
            set { _strNumeroTelefono = value; }
        }
    }
}
