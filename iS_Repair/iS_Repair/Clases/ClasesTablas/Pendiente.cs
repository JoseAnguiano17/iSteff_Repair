using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Pendiente
    {
        private int _intId;

        public int ID
        {
            get { return _intId; }
            set { _intId = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
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

        public Pendiente(int intID, string strDescrip, DateTime dtmFechaR, string strUsuario)
        {
            ID = intID;
            Descripcion = strDescrip;
            FechaRegistro = dtmFechaR;
            Usuario = strUsuario;
        }
    }
}
