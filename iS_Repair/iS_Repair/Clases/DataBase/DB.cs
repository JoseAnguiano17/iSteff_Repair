using iS_Repair.Clases.ClasesTablas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace iS_Repair.Clases.DataBase
{
    public class DB
    {
        TableBuilder clientes = new TableBuilder("clientes", "id_cliente VARCHAR(8)," +
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
            catch { }
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
            MySqlCommand cmd = new MySqlCommand(query, miConexion);
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
                cliente.NumeroTelefono = item[2].ToString();
                yield return cliente;
            }
            yield break;
        }

        public IEnumerable<Historial> Historiales()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(historial.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Historial historial = new Historial();
                historial.IdTelefono = item[0].ToString();
                historial.IdProblema = item[1].ToString();
                yield return historial;
            }
            yield break;
        }

        public IEnumerable<Pedido> Pedidos()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(pedidos.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdCliente = item[0].ToString();
                pedido.Pieza = item[1].ToString();
                pedido.Costo = double.Parse(item[2].ToString());
                pedido.EsPedido = (item[3].ToString() == "1") ? true : false;
                pedido.FechaPedido = DateTime.Parse(item[4].ToString());
                pedido.FechaRegistro = DateTime.Parse(item[5].ToString());
                yield return pedido;
            }
            yield break;
        }

        public IEnumerable<Pendiente> Pendientes()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(pendientes.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Pendiente pendiente = new Pendiente();
                pendiente.Id = item[0].ToString();
                pendiente.Descripcion = item[1].ToString();
                pendiente.FechaRegistro = DateTime.Parse(item[2].ToString());
                yield return pendiente;
            }
            yield break;
        }

        public IEnumerable<Problema> Problemas()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(problemas.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Problema problema = new Problema();
                problema.Id = item[0].ToString();
                problema.Nombre = item[1].ToString();
                problema.Costo = double.Parse(item[2].ToString());
                problema.IdEstado = item[3].ToString();
                problema.FechaSolucion = DateTime.Parse(item[4].ToString());
                yield return problema;
            }
            yield break;
        }

        public IEnumerable<Recibido> Recibidos()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(recibidos.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Recibido recibido = new Recibido();
                recibido.IdCliente = item[0].ToString();
                recibido.IdTelefono = item[1].ToString();
                yield return recibido;
            }
            yield break;
        }

        public IEnumerable<Telefono> Telefonos()
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(telefonos.QuerySelect("*"), miConexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();

            foreach (DataRow item in tabla.Rows)
            {
                Telefono telefono = new Telefono();
                telefono.IdTelefono = item[0].ToString();
                telefono.Modelo = item[1].ToString();
                telefono.Descripcion = item[2].ToString();
                telefono.FechaLlegada = DateTime.Parse(item[3].ToString());
                telefono.IdProblema = item[4].ToString();
                telefono.Armado = (item[5].ToString() == "1") ? true : false;
                telefono.Imei = item[6].ToString();
                telefono.Contrasena = item[7].ToString();
                yield return telefono;
            }
            yield break;
        }
    }
}
