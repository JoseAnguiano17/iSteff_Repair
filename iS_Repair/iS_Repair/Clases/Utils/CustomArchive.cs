using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Clases.Utils
{
    public class CustomArchive
    {
        private string _strNombreArchivo;

        public string NombreArchivo {
            get { return _strNombreArchivo; }
            set { _strNombreArchivo = value; }
        }

        public FileStream Flujo()
        {
            flujo = new FileStream(NombreArchivo, FileMode.Open,FileAccess.Read);
            return flujo;
        }

        // Se define el flujo
        private FileStream flujo;

        // Se define el seriador
        private StreamWriter writer;

        // Constructor
        public CustomArchive(string strNombreArchivo)
        {
            NombreArchivo = strNombreArchivo;
        }
        
        // Metodo para cerrar el archivo
        public void Cerrar()
        {
            if (flujo != null)
                flujo.Close();
        }

        // Destructor
        ~CustomArchive()
        {
            this.Cerrar();
        }

        
        //Metodo para grabar un objeto en el archivo
        public void GrabarObjeto(string str)
        {
            writer = new StreamWriter(NombreArchivo);
            writer.Write(str);
            writer.Flush();
            writer.Close();
        }
        public void EliminarAchivo()
        {
            File.Delete(NombreArchivo);
        }
    }
}
