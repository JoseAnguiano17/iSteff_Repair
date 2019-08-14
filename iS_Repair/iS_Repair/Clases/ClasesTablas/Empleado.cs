using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Empleado
    {
        private int _intUsuario;

        public int Usuario {
            get { return _intUsuario; }
            set { _intUsuario = value; }
        }

        private int _intContrasena;

        public int Contrasena {
            get { return _intContrasena; }
            set { _intContrasena = value; }
        }

        private string _strNombre;

        public string Nombre {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strTelefono;

        public string Telefono {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private string _strCorreo;

        public string Correo {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }

        private string _strDireccion;

        public string Direccion {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }

    }
}
