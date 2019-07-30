using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.DataBase
{
    public class DB
    {
        TableBuilder clientes = new TableBuilder("clientes","id_cliente VARCHAR(8)," +
                                                            "nombre TEXT," +
                                                            "n_telefono VARCHAR(14)");
        TableBuilder recibidos = new TableBuilder("recibidos", "");
        TableBuilder telefonos = new TableBuilder("telefonos", "");
        TableBuilder problemas = new TableBuilder("problemas", "");
        TableBuilder historial = new TableBuilder("historial", "");
        TableBuilder pendientes = new TableBuilder("pendientes", "");
        TableBuilder pedidos = new TableBuilder("pedidos", "");

        SqlConnection miConexion;
        bool blConexionEstablecida = false;
        DataHost dh;
        
        public DB(DataHost dh, string password)
        {
            string connectionString = @"server=" + dh.Server + ";" + "database=" +
                dh.Database + ";" + "uid=" + dh.UID + ";" + "pwd=" + password + ";";
            this.miConexion = new SqlConnection(connectionString);
            Abrir();
            if (!(miConexion.State == ConnectionState.Open))
            {
                return;
            }
            blConexionEstablecida = true;
            /**
             * Creacion de tablas.
             **/
             Cerrar();
        }
        public void Abrir()
        {
            try
            {
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }
            }
            catch{}
        }
        public void Cerrar()
        {
            if (miConexion.State == ConnectionState.Open)
            {
                miConexion.Close();
            }
        }
        public bool ConexionEstablecida()
        {
            return blConexionEstablecida;
        }
    }
}
