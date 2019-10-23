using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Pedido
    {
        public Pedido(int intID, string strPieza, double dlbCosto, bool blnPedido, DateTime dtmFechaP, DateTime dtmFechaR, int intIDC, string strUsuario)
        {
            ID = intID;
            Pieza = strPieza;
            Costo = _dblCosto;
            YaPedido = blnPedido;
            FechaPedido = dtmFechaP;
            FechaRegistro = dtmFechaR;
            IDCliente = intIDC;
            Usuario = strUsuario;
        }

        private int _intIdCliente;

        public int IDCliente
        {
            get { return _intIdCliente; }
            set { _intIdCliente = value; }
        }

        private int _intId;

        public int ID {
            get { return _intId; }
            set { _intId = value; }
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

        public bool YaPedido
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

        private string _strUsuario;

        public string Usuario
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }

    }
}
