using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Filtro
    {
        public Filtro()
        {
            Falsear();
        }

        public void Falsear()
        {
            IDUno32 = false;
            Nombre = false;
            ApellidoP = false;
            ApellidoM = false;
            NumTel = false;
            Usuario = false;
            Contrasena = false;
            Correo = false;
            Direccion = false;
            IDDos16 = false;
            Descripcion = false;
            Color = false;
            IDTres32 = false;
            Pieza = false;
            Costo = false;
            YaPedido = false;
            FechaPedido = false;
            FechaRegistro = false;
            Modelo = false;
            Armado = false;
            IMEI = false;
            Rango = false;
            FechaLlegada = false;
            FechaSolucion = false;
        }

        private bool _blnNombre;

        public bool Nombre
        {
            get { return _blnNombre; }
            set { _blnNombre = value; }
        }

        private string _strNombre;

        public string NombreValor
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private bool _blnApellidoP;

        public bool ApellidoP
        {
            get { return _blnApellidoP; }
            set { _blnApellidoP = value; }
        }

        private string _strApellidoP;

        public string ApellidoPValor
        {
            get { return _strApellidoP; }
            set { _strApellidoP = value; }
        }

        private bool _blnApellidoM;

        public bool ApellidoM
        {
            get { return _blnApellidoM; }
            set { _blnApellidoM = value; }
        }

        private string _strApellidoM;

        public string ApellidoMValor
        {
            get { return _strApellidoM; }
            set { _strApellidoM = value; }
        }

        private bool _blnNumTel;

        public bool NumTel
        {
            get { return _blnNumTel; }
            set { _blnNumTel = value; }
        }

        private string _strNumTel;

        public string NumTelValor
        {
            get { return _strNumTel; }
            set { _strNumTel = value; }
        }

        private bool _blnUsuario;

        public bool Usuario
        {
            get { return _blnUsuario; }
            set { _blnUsuario = value; }
        }

        private string _strUsuario;

        public string UsuarioValor
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }

        private bool _blnCorreo;

        public bool Correo
        {
            get { return _blnCorreo; }
            set { _blnCorreo = value; }
        }

        private string _strCorreo;

        public string CorreoValor
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }

        private bool _blnDireccion;

        public bool Direccion
        {
            get { return _blnDireccion; }
            set { _blnDireccion = value; }
        }

        private string _strDireccion;

        public string DireccionValor
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }

        private bool _blnDescripcion;

        public bool Descripcion
        {
            get { return _blnDescripcion; }
            set { _blnDescripcion = value; }
        }

        private string _strDescripcion;

        public string DescripcionValor
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        private bool _blnColor;

        public bool Color
        {
            get { return _blnColor; }
            set { _blnColor = value; }
        }

        private string _strColor;

        public string ColorValor
        {
            get { return _strColor; }
            set { _strColor = value; }
        }

        private bool _blnPieza;

        public bool Pieza
        {
            get { return _blnPieza; }
            set { _blnPieza = value; }
        }

        private string _strPieza;

        public string PiezaValor
        {
            get { return _strPieza; }
            set { _strPieza = value; }
        }

        private double _dblCosto;

        public double CostoValor
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }

        private bool _blnCosto;

        public bool Costo
        {
            get { return _blnCosto; }
            set { _blnCosto = value; }
        }

        private bool _blnYaPedido;

        public bool YaPedido
        {
            get { return _blnYaPedido; }
            set { _blnYaPedido = value; }
        }

        private bool _blnYaPedidoValor;

        public bool YaPedidoValor
        {
            get { return _blnYaPedidoValor; }
            set { _blnYaPedidoValor = value; }
        }

        private DateTime _dtmFechaP;

        public DateTime FechaPedidoValor
        {
            get { return _dtmFechaP; }
            set { _dtmFechaP = value; }
        }

        private bool _blnFechaP;

        public bool FechaPedido
        {
            get { return _blnFechaP; }
            set { _blnFechaP = value; }
        }

        private DateTime _dtmFechaR;

        public DateTime FechaRegistroValor
        {
            get { return _dtmFechaR; }
            set { _dtmFechaR = value; }
        }

        private bool _blnFechaR;

        public bool FechaRegistro
        {
            get { return _blnFechaR; }
            set { _blnFechaR = value; }
        }

        private bool _blnIDUno32;

        public bool IDUno32
        {
            get { return _blnIDUno32; }
            set { _blnIDUno32 = value; }
        }

        private int _intIDUno32;

        public int IDUno32Valor
        {
            get { return _intIDUno32; }
            set { _intIDUno32 = value; }
        }

        private bool _blnIDDos16;

        public bool IDDos16
        {
            get { return _blnIDDos16; }
            set { _blnIDDos16 = value; }
        }

        private Int16 _intIDDos16;

        public Int16 IDDos16Valor
        {
            get { return _intIDDos16; }
            set { _intIDDos16 = value; }
        }

        private bool _blnIDTres32;

        public bool IDTres32
        {
            get { return _blnIDTres32; }
            set { _blnIDTres32 = value; }
        }

        private int _intIDTres32;

        public int IDTres32Valor
        {
            get { return _intIDTres32; }
            set { _intIDTres32 = value; }
        }

        private bool _blnModelo;

        public bool Modelo
        {
            get { return _blnModelo; }
            set { _blnModelo = value; }
        }

        private string _strModelo;

        public string ModeloValor
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }

        private bool _blnArmado;

        public bool Armado
        {
            get { return _blnArmado; }
            set { _blnArmado = value; }
        }

        private bool _blnArmadoValor;

        public bool ArmadoValor
        {
            get { return _blnArmadoValor; }
            set { _blnArmadoValor = value; }
        }

        private bool _blnIMEI;

        public bool IMEI
        {
            get { return _blnIMEI; }
            set { _blnIMEI = value; }
        }

        private string _strIMEI;

        public string IMEIValor
        {
            get { return _strIMEI; }
            set { _strIMEI = value; }
        }

        private bool _blnContrasena;

        public bool Contrasena
        {
            get { return _blnContrasena; }
            set { _blnContrasena = value; }
        }

        private string _strContrasena;

        public string ContrasenaValor
        {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }

        private bool _blnRango;

        public bool Rango
        {
            get { return _blnRango; }
            set { _blnRango = value; }
        }

        private char _chrRango;

        public char RangoValor
        {
            get { return _chrRango; }
            set { _chrRango = value; }
        }

        private bool _blnFechaL;

        public bool FechaLlegada
        {
            get { return _blnFechaL; }
            set { _blnFechaL = value; }
        }

        private DateTime _dtmFechaL;

        public DateTime FechaLlegadaValor
        {
            get { return _dtmFechaL; }
            set { _dtmFechaL = value; }
        }

        private bool _blnFechaS;

        public bool FechaSolucion
        {
            get { return _blnFechaS; }
            set { _blnFechaS = value; }
        }

        private DateTime _dtmFechaS;

        public DateTime FechaSolucionValor
        {
            get { return _dtmFechaS; }
            set { _dtmFechaS = value; }
        }

        public string GenerarCondicion(string strTabla)
        {
            bool blnAnterior = false;
            string strConsulta = "";
            if (IDUno32||Nombre||ApellidoP||ApellidoM||NumTel||Usuario||Contrasena||
                Correo||Direccion||IDDos16||Descripcion||Color||IDTres32||Pieza||Costo||
                YaPedido||FechaPedido||FechaRegistro||Modelo||Armado||IMEI||Rango||
                FechaLlegada||FechaSolucion)
            {
                if(Nombre)
                {
                    if(strTabla == "ESTADO")
                        strConsulta += " NOMBREESTADO LIKE '%" + NombreValor + "%'";
                    else
                        strConsulta += " NOMBRE LIKE '%" + NombreValor + "%'";
                    blnAnterior = true;
                }
                if (ApellidoP)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " APELLIDOP LIKE '%" + ApellidoPValor + "%'";
                    blnAnterior = true;
                }
                if (ApellidoM)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " APELLIDOM LIKE '%" + ApellidoMValor + "%'";
                    blnAnterior = true;
                }
                if (NumTel)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " NUMTELEFONO LIKE '%" + NumTelValor + "%'";
                    blnAnterior = true;
                }
                if (IDUno32)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    switch (strTabla)
                    {
                        case "CLIENTE":
                            strConsulta += " IDCLIENTE = " + IDUno32Valor;
                            break;
                        case "PEDIDO":
                            strConsulta += " IDPEDIDO = " + IDUno32Valor;
                            break;
                        case "PENDIENTE":
                            strConsulta += " IDPENDIENTE = " + IDUno32Valor;
                            break;
                        case "TELEFONO":
                            strConsulta += " IDTELEFONO = " + IDUno32Valor;
                            break;
                        case "TELPROB":
                            strConsulta += " IDTELEFONO = " + IDUno32Valor;
                            break;
                    }
                    blnAnterior = true;
                }
                if (Usuario)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " USUARIO LIKE '%" + UsuarioValor + "%'";
                    blnAnterior = true;
                }
                if (Contrasena)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " CONTRASENA LIKE '%" + ContrasenaValor + "%'";
                    blnAnterior = true;
                }
                if (Correo)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " CORREO LIKE '%" + CorreoValor + "%'";
                    blnAnterior = true;
                }
                if (Direccion)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " DIRECCIÓN LIKE '%" + DireccionValor + "%'";
                    blnAnterior = true;
                }
                if (IDDos16)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    switch (strTabla)
                    {
                        case "ESTADO":
                            strConsulta += " IDESTADO = " + IDDos16Valor;
                            break;
                        case "PROBLEMA":
                            strConsulta += " IDPROBLEMA = " + IDDos16Valor;
                            break;
                        case "TELEFONO":
                            strConsulta += " IDESTADO = " + IDDos16Valor;
                            break;
                        case "TELPROB":
                            strConsulta += " IDPROBLEMA = " + IDDos16Valor;
                            break;
                    }
                    blnAnterior = true;
                }
                if (Descripcion)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    switch (strTabla)
                    {
                        case "ESTADO":
                            strConsulta += " DESCRIPESTADO LIKE '%" + DescripcionValor + "%'";
                            break;
                        case "PENDIENTE":
                            strConsulta += " DESCRIPPENDIENTE LIKE '%" + DescripcionValor + "%'";
                            break;
                        case "PROBLEMA":
                            strConsulta += " DESCRIPPROBLEMA LIKE '%" + DescripcionValor + "%'";
                            break;
                        case "TELEFONO":
                            strConsulta += " DESCRIPTELEFONO LIKE '%" + DescripcionValor + "%'";
                            break;
                    }
                    blnAnterior = true;
                }
                if (Color)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " COLOR LIKE '%" + ColorValor + "%'";
                    blnAnterior = true;
                }
                if (Pieza)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " PIEZA LIKE '%" + PiezaValor + "%'";
                    blnAnterior = true;
                }
                if (Costo)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " COSTO = " + CostoValor;
                    blnAnterior = true;
                }
                if (YaPedido)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " YAPEDIDO = " + (YaPedidoValor? 1 : 0);
                    blnAnterior = true;
                }
                if (FechaPedido)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " FECHAPEDIDO = '" + FechaPedidoValor.ToShortDateString() +"'";
                    blnAnterior = true;
                }
                if (FechaRegistro)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    if (strTabla == "PEDIDO")
                        strConsulta += " FECHAREGISTRADO = '" + FechaRegistroValor.ToShortDateString() + "'";
                    else
                        strConsulta += " FECHAREGISTRO = '" + FechaRegistroValor.ToShortDateString() + "'";
                    blnAnterior = true;
                }
                if (IDTres32)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " IDCLIENTE = " + IDTres32Valor;
                    blnAnterior = true;
                }
                if (Modelo)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " MODELO LIKE '%" + ModeloValor + "%'";
                    blnAnterior = true;
                }
                if (Armado)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " ARMADO = " + (ArmadoValor? 1 : 0);
                    blnAnterior = true;
                }
                if (IMEI)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " IMEI LIKE '%" + IMEIValor + "%'";
                    blnAnterior = true;
                }
                if (Rango)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " RANGO LIKE '%" + RangoValor + "%'";
                    blnAnterior = true;
                }
                if (FechaLlegada)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " FECHALLEGADA = '" + FechaLlegadaValor.ToShortDateString() + "'";
                    blnAnterior = true;
                }
                if (FechaSolucion)
                {
                    if (blnAnterior)
                        strConsulta += " AND";
                    strConsulta += " FECHASOLUCION = '" + FechaSolucionValor.ToShortDateString() + "'";
                    blnAnterior = true;
                }
            }
            blnAnterior = false;
            return strConsulta;
        }
    }
}
