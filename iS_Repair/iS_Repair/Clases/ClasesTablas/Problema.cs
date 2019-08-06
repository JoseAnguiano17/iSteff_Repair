using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    class Problema
    {
        private string _strId;

        public string Id
        {
            get { return _strId; }
            set { _strId = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblCosto;

        public double Costo
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }

        private string _strIdEstado;

        public string IdEstado
        {
            get { return _strIdEstado; }
            set { _strIdEstado = value; }
        }

        private DateTime _dtmFechaSolucion;

        public DateTime FechaSolucion
        {
            get { return _dtmFechaSolucion; }
            set { _dtmFechaSolucion = value; }
        }
    }
}
