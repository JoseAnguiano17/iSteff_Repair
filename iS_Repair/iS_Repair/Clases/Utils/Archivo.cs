﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Clases.Utils
{
    public class Archivo<Tipo> where Tipo : IEquatable<Tipo>
    {
        static string appName = "iSteff_Repair";
        static string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + appName;
        string path = folder;
        private string _strNombreArchivo;

        public string NombreArchivo {
            get { return _strNombreArchivo; }
            set { _strNombreArchivo = value; }
        }

        public FileStream Flujo()
        {
            return flujo;
        }

        // Se define el flujo
        private FileStream flujo;

        // Se define el seriador
        private BinaryFormatter seriador;

        // Constructor
        public Archivo(string strNombreArchivo)
        {
            NombreArchivo = strNombreArchivo;
            path = folder + "\\" + NombreArchivo;
        }

        // Metodo para crear el archivo
        private void Crear()
        {
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            flujo = new FileStream(path, FileMode.Create);
            seriador = new BinaryFormatter();
        }
        // Metodo para cerrar el archivo
        public void Cerrar()
        {
            if (flujo != null)
                flujo.Close();
        }

        // Destructor
        ~Archivo()
        {
            this.Cerrar();
        }

        // Metodo para abrir el archivo en modo escritura
        private void AbrirEnModoEscritura()
        {
            if (File.Exists(path))
            {
                flujo = new FileStream(path, FileMode.Append);
                seriador = new BinaryFormatter();
            }
            else
                this.Crear();
        }

        // Metodo para abrir en modo lectura
        private void AbrirEnModoLectura()
        {
            if (File.Exists(path))
            {
                flujo = new FileStream(path, FileMode.Open);
                seriador = new BinaryFormatter();
            }
            else
                Crear();
        }

        //Metodo para grabar un objeto en el archivo
        public void GrabarObjeto(Tipo miObjeto)
        {
            try
            {
                AbrirEnModoEscritura();
                seriador.Serialize(flujo, miObjeto);
                Cerrar();
            }
            catch (Exception)
            {
                Cerrar();
            }
        }

        // Metodo para leer un objeto del archivo
        public IEnumerable<Tipo> LeerObjetos()
        {
            AbrirEnModoLectura();
            Tipo miObjeto;
            try
            {
                miObjeto = (Tipo)seriador.Deserialize(flujo);
            }
            catch (Exception)
            {
                Cerrar();
                yield break;
            }

            while (miObjeto != null)
            {
                yield return miObjeto;
                try
                {
                    miObjeto = (Tipo)seriador.Deserialize(flujo);
                }
                catch (Exception)
                {
                    break;
                }
            }
            Cerrar();
            yield break;
        }

        public void Eliminar(Tipo miObjeto)
        {
            try
            {
                Archivo<Tipo> aux = new Archivo<Tipo>(path + "aux");
                foreach (Tipo item in LeerObjetos())
                {
                    if (!item.Equals(miObjeto))
                    {
                        aux.GrabarObjeto(item);
                    }
                }
                this.EliminarAchivo();
                if (File.Exists(aux.NombreArchivo))
                {
                    File.Copy(aux.NombreArchivo, path, true);
                    aux.EliminarAchivo();
                }
            }
            catch (Exception)
            {
                Cerrar();
            }
        }

        public void EliminarAchivo()
        {
            File.Delete(path);
        }
    }
}
