using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases
{
    public class Cliente
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }

        private string _strNombre;

        public string Nombre
        {
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

        private string _strNumeroTelefono;

        public string NumeroTelefono
        {
            get { return _strNumeroTelefono; }
            set { _strNumeroTelefono = value; }
        }

        public Cliente(int intID, string strNombre, string strAP, string strAM, string strTel)
        {
            ID = intID;
            Nombre = strNombre;
            ApellidoP = strAP;
            ApellidoM = strAM;
            NumeroTelefono = strTel;
        }
    }
}
