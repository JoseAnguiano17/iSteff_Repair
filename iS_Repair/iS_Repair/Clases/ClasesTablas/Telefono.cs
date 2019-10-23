using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Telefono
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        private string _strModelo;

        public string Modelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }

        private DateTime _dtmFechaLlegada;

        public DateTime FechaLlegada
        {
            get { return _dtmFechaLlegada; }
            set { _dtmFechaLlegada = value; }
        }

        private int _intIDCliente;

        public int IDCliente
        {
            get { return _intIDCliente; }
            set { _intIDCliente = value; }
        }

        private Int16 _intIDEstado;

        public Int16 IDEstado
        {
            get { return _intIDEstado; }
            set { _intIDEstado = value; }
        }

        private bool _blnArmado;

        public bool Armado
        {
            get { return _blnArmado; }
            set { _blnArmado = value; }
        }

        private string _strImei;

        public string IMEI
        {
            get { return _strImei; }
            set { _strImei = value; }
        }

        private string _strContrasena;

        public string Contrasena
        {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }

        private char _chrRango;

        public char Rango {
            get { return _chrRango; }
            set { _chrRango = value; }
        }

        public Telefono(int intID, string strModelo, string strDescrip, bool blnArmado, string strIMEI, string strContrasena, char chrRango, DateTime dtmFechaL, Int16 intIDE, int intIDC)
        {
            ID = intID;
            Modelo = strModelo;
            Descripcion = strDescrip;
            Armado = blnArmado;
            IMEI = strIMEI;
            Contrasena = strContrasena;
            Rango = chrRango;
            FechaLlegada = dtmFechaL;
            IDEstado = intIDE;
            IDCliente = intIDC;
        }
    }
}
