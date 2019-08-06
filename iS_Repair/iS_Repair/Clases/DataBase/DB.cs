using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace iS_Repair.Clases.DataBase
{
    public class DB
    {
        TableBuilder clientes = new TableBuilder("clientes","id_cliente VARCHAR(8)," +
                                                            "nombre TEXT," +
                                                            "n_telefono VARCHAR(14)");
        TableBuilder recibidos = new TableBuilder("recibidos", "id_cliente VARCHAR(8)," +
                                                               "id_telefono VARCHAR(10)");
        TableBuilder telefonos = new TableBuilder("telefonos", "id_telefono VARCHAR(10)," +
                                                               "modelo VARCHAR(40)," +
                                                               "descripcion TEXT," +
                                                               "fecha_llegada DATETIME," +
                                                               "id_problema VARCHAR(14)," +
                                                               "armado BOOLEAN," +
                                                               "imei VARCHAR(15)," +
                                                               "contrasena VARCHAR(40)");
        TableBuilder problemas = new TableBuilder("problemas", "id_problema VARCHAR(14)," +
                                                               "nombre VARCHAR(40)," +
                                                               "costo DOUBLE," +
                                                               "id_estado VARCHAR(5)," +
                                                               "fecha_solucion DATETIME");
        TableBuilder historial = new TableBuilder("historial", "id_telefono VARCHAR(10)," +
                                                               "id_problema VARCHAR(14)");
        TableBuilder pendientes = new TableBuilder("pendientes", "id_pendientes varchar(8)," +
                                                                 "descripcion TEXT," +
                                                                 "fecha_registro DATETIME");
        TableBuilder pedidos = new TableBuilder("pedidos", "id_cliente VARCHAR(8)," +
                                                           "pieza VARCHAR(40)," +
                                                           "costo DOUBLE," +
                                                           "pedido BOOLEAN," +
                                                           "fecha_pedido DATETIME," +
                                                           "fecha_registro DATETIME");

        MySqlConnection miConexion;
        bool blConexionEstablecida = false;
        
        public DB(DataHost dh, string password)
        {
            string connectionString = @"server=" + dh.Server + ";" + "database=" +
                dh.Database + ";" + "uid=" + dh.UID + ";" + "pwd=" + password + ";";
            this.miConexion = new MySqlConnection(connectionString);
            Abrir();
            if (!(miConexion.State == ConnectionState.Open))
            {
                throw new Exception("No se pudo conectar a la base de datos.");
            }
            blConexionEstablecida = true;
            /**
             * Creacion de tablas.
             **/
            Executar(clientes.QueryTable());
            Executar(recibidos.QueryTable());
            Executar(telefonos.QueryTable());
            Executar(problemas.QueryTable());
            Executar(historial.QueryTable());
            Executar(pendientes.QueryTable());
            Executar(pedidos.QueryTable());
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

        //Executa Querys solo si la conexion esta abierta.
        void Executar(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,miConexion);
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Cliente> Clientes()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(clientes.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.ID = item[0].ToString();
                cliente.Nombre = item[1].ToString();
                cliente.NumeroTelefono= item[2].ToString();
                yield return cliente;
            }
            yield break;
        }
    }
}
