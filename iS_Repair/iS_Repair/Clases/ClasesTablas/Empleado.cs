using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Empleado
    {
        private string _strUsuario;

        public string Usuario {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }

        private string _strContrasena;

        public string Contrasena {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }

        private string _strNombre;

        public string Nombre {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strApellidoP;

        public string ApellidoP
        {
            get { return _strApellidoP; }
            set { _strApellidoP = value; }
        }

        private string _strApellidoM;

        public string ApellidoM
        {
            get { return _strApellidoM; }
            set { _strApellidoM = value; }
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

        private bool _blnAdmin;

        public bool Administrador
        {
            get { return _blnAdmin; }
            set { _blnAdmin = value; }
        }

        public Empleado(string strUsuario, string strContrasena, string strNombre, string strAPP, string strAM, string strTel, string strCorreo, string strDir, bool blnAdmin)
        {
            Usuario = strUsuario;
            Contrasena = strContrasena;
            Nombre = strNombre;
            ApellidoP = strAPP;
            ApellidoM = strAM;
            Telefono = strTel;
            Correo = strCorreo;
            Direccion = strDir;
            Administrador = blnAdmin;
        }

        public Empleado()
        {

        }
    }
}
