using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Pedido
    {
        private string _strIdCliente;

        public string IdCliente
        {
            get { return _strIdCliente; }
            set { _strIdCliente = value; }
        }

        private string _idPedido;

        public string IdPedido {
            get { return _idPedido; }
            set { _idPedido = value; }
        }

        private string _strPieza;

        public string Pieza
        {
            get { return _strPieza; }
            set { _strPieza = value; }
        }

        private double _dblCosto;

        public double Costo
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }

        private bool _blnPedido;

        public bool EsPedido
        {
            get { return _blnPedido; }
            set { _blnPedido = value; }
        }

        private DateTime _dtmFechaPedido;

        public DateTime FechaPedido
        {
            get { return _dtmFechaPedido; }
            set { _dtmFechaPedido = value; }
        }

        private DateTime _dtmFechaRegistro;

        public DateTime FechaRegistro
        {
            get { return _dtmFechaRegistro; }
            set { _dtmFechaRegistro = value; }
        }
    }
}
