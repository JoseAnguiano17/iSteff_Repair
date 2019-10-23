using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Estado
    {
        public Estado(Int16 intID, string strNombre, string strDescrip, int intColor)
        {
            ID = intID;
            Nombre = strNombre;
            Descripcion = strDescrip;
            Color = intColor;
        }

        private Int16 _intId;

        public Int16 ID
        {
            get { return _intId; }
            set { _intId = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        private int _intColor;

        public int Color
        {
            get { return _intColor; }
            set { _intColor = value; }
        }
    }
}
