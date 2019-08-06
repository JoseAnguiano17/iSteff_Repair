using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Telefono
    {
        private string _strIdTelefono;

        public string IdTelefono
        {
            get { return _strIdTelefono; }
            set { _strIdTelefono = value; }
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

        private string _strIdProblema;

        public string IdProblema
        {
            get { return _strIdProblema; }
            set { _strIdProblema = value; }
        }

        private bool _blnArmado;

        public bool Armado
        {
            get { return _blnArmado; }
            set { _blnArmado = value; }
        }

        private string _strImei;

        public string Imei
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

    }
}
