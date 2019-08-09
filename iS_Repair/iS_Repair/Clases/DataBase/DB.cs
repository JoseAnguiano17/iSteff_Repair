using iS_Repair.Clases.ClasesTablas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace iS_Repair.Clases.DataBase
{
    public class DB
    {
        #region TABLAS
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
                                                           "id_pedido VARCHAR(8)," +
                                                           "pieza VARCHAR(40)," +
                                                           "costo DOUBLE," +
                                                           "pedido BOOLEAN," +
                                                           "fecha_pedido DATETIME," +
                                                           "fecha_registro DATETIME");
        #endregion
         
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
            Ejecutar(clientes.QueryTable());
            Ejecutar(recibidos.QueryTable());
            Ejecutar(telefonos.QueryTable());
            Ejecutar(problemas.QueryTable());
            Ejecutar(historial.QueryTable());
            Ejecutar(pendientes.QueryTable());
            Ejecutar(pedidos.QueryTable());
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

        void Ejecutar(String query)
        {
            Ejecutar(new MySqlCommand(query, miConexion));
        }

        void Ejecutar(MySqlCommand cmd)
        {
            Abrir();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error al ejecutar el comando en la base de datos.");
            }
            Cerrar();
        }

        public void Modificar(string tabla, string set, string where)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE " + tabla + " SET " + set + " WHERE " + where, miConexion);
            Ejecutar(cmd);
        }

        DataTable Tabla(TableBuilder obj)
        {
            return Tabla(obj, obj.QuerySelect("*"));
        }

        DataTable Tabla(TableBuilder obj, string querySelect)
        {
            Abrir();
            MySqlCommand cmd = new MySqlCommand(querySelect, miConexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter.Dispose();
            Cerrar();
            return tabla;
        }

        #region CLIENTES
        public IEnumerable<Cliente> Clientes()
        {
            DataTable tabla = Tabla(clientes);

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
        public void AgregarCliente(Cliente miCliente)
        {
            MySqlCommand cmd = new MySqlCommand(clientes.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_cliente",miCliente.ID);
            cmd.Parameters.AddWithValue("@nombre",miCliente.Nombre);
            cmd.Parameters.AddWithValue("@n_telefono", miCliente.NumeroTelefono);
            Ejecutar(cmd);
        }
        public void EliminarCliente(string id_cliente)
        {
            MySqlCommand cmd = new MySqlCommand(clientes.QueryDelete("id_cliente=@id_cliente"), miConexion);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            Ejecutar(cmd);
        }
        #endregion

        #region HISTORIALES
        public IEnumerable<Historial> Historiales()
        {
            DataTable tabla = Tabla(historial);

            foreach (DataRow item in tabla.Rows)
            {
                Historial historial = new Historial();
                historial.IdTelefono = item[0].ToString();
                historial.IdProblema = item[1].ToString();
                yield return historial;
            }
            yield break;
        }
        public void AgregarHistorial(Historial miHistorial)
        {
            MySqlCommand cmd = new MySqlCommand(historial.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", miHistorial.IdTelefono);
            cmd.Parameters.AddWithValue("@id_problema", miHistorial.IdProblema);
            Ejecutar(cmd);
        }
        public void EliminarHistorial(string id_telefono,string id_problema)
        {
            MySqlCommand cmd = new MySqlCommand(historial.QueryDelete("id_telefono=@id_telefono AND id_problema=@id_problema"), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", id_telefono);
            cmd.Parameters.AddWithValue("@id_problema", id_problema);
            Ejecutar(cmd);
        }
        #endregion

        #region PEDIDOS
        public IEnumerable<Pedido> Pedidos()
        {
            DataTable tabla = Tabla(pedidos);

            foreach (DataRow item in tabla.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdCliente = item[0].ToString();
                pedido.IdPedido = item[1].ToString();
                pedido.Pieza = item[2].ToString();
                pedido.Costo = (double) item[3];
                pedido.EsPedido = (bool)item[4];
                pedido.FechaPedido = (DateTime)item[5];
                pedido.FechaRegistro = (DateTime)item[6];
                yield return pedido;
            }
            yield break;
        }
        public void AgregarPedido(Pedido miPedido)
        {
            MySqlCommand cmd = new MySqlCommand(pedidos.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_cliente", miPedido.IdCliente);
            cmd.Parameters.AddWithValue("@id_pedido", miPedido.IdPedido);
            cmd.Parameters.AddWithValue("@pieza", miPedido.Pieza);
            cmd.Parameters.AddWithValue("@costo", miPedido.Costo);
            cmd.Parameters.AddWithValue("@pedido", miPedido.EsPedido);
            cmd.Parameters.AddWithValue("@fecha_pedido", miPedido.FechaPedido);
            cmd.Parameters.AddWithValue("@fecha_registro", miPedido.FechaRegistro);
            Ejecutar(cmd);
        }
        public void EliminarPedido(string id_cliente,string id_pedido)
        {
            MySqlCommand cmd = new MySqlCommand(pedidos.QueryDelete("id_cliente=@id_cliente AND id_pedido=@id_pedido"), miConexion);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@id_pedido", id_pedido);
            Ejecutar(cmd);
        }
        #endregion

        #region PENDIENTES
        public IEnumerable<Pendiente> Pendientes()
        {
            DataTable tabla = Tabla(pendientes);

            foreach (DataRow item in tabla.Rows)
            {
                Pendiente pendiente = new Pendiente();
                pendiente.Id = item[0].ToString();
                pendiente.Descripcion = item[1].ToString();
                pendiente.FechaRegistro = (DateTime)item[2];
                yield return pendiente;
            }
            yield break;
        }
        public void AgregarPendiente(Pendiente miPendiente)
        {
            MySqlCommand cmd = new MySqlCommand(pendientes.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_pendientes", miPendiente.Id);
            cmd.Parameters.AddWithValue("@descripcion", miPendiente.Descripcion);
            cmd.Parameters.AddWithValue("@fecha_registro", miPendiente.FechaRegistro);
            Ejecutar(cmd);
        }
        public void EliminarPendientes(string id_pendientes)
        {
            MySqlCommand cmd = new MySqlCommand(pendientes.QueryDelete("id_pendientes=@id_pendientes"), miConexion);
            cmd.Parameters.AddWithValue("@id_pendientes", id_pendientes);
            Ejecutar(cmd);
        }
        #endregion

        #region PROBLEMAS
        public IEnumerable<Problema> Problemas()
        {
            DataTable tabla = Tabla(problemas);

            foreach (DataRow item in tabla.Rows)
            {
                Problema problema = new Problema();
                problema.Id = item[0].ToString();
                problema.Nombre = item[1].ToString();
                problema.Costo = (double)item[2];
                problema.IdEstado = item[3].ToString();
                problema.FechaSolucion = (DateTime)item[4];
                yield return problema;
            }
            yield break;
        }
        public void AgregarProblema(Problema miProblema)
        {
            MySqlCommand cmd = new MySqlCommand(problemas.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_problema", miProblema.Id);
            cmd.Parameters.AddWithValue("@nombre", miProblema.Nombre);
            cmd.Parameters.AddWithValue("@costo", miProblema.Costo);
            cmd.Parameters.AddWithValue("@id_estado", miProblema.IdEstado);
            cmd.Parameters.AddWithValue("@fecha_solucion", miProblema.FechaSolucion);
            Ejecutar(cmd);
        }
        public void EliminarProblema(string id_problema)
        {
            MySqlCommand cmd = new MySqlCommand(problemas.QueryDelete("id_problema=@id_problema"), miConexion);
            cmd.Parameters.AddWithValue("@id_problema", id_problema);
            Ejecutar(cmd);
        }
        #endregion

        #region RECIBIDOS
        public IEnumerable<Recibido> Recibidos()
        {
            DataTable tabla = Tabla(recibidos);

            foreach (DataRow item in tabla.Rows)
            {
                Recibido recibido = new Recibido();
                recibido.IdCliente = item[0].ToString();
                recibido.IdTelefono = item[1].ToString();
                yield return recibido;
            }
            yield break;
        }
        public void AgregarRecibido(Recibido miRecibido)
        {
            MySqlCommand cmd = new MySqlCommand(recibidos.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", miRecibido.IdTelefono);
            cmd.Parameters.AddWithValue("@id_cliente", miRecibido.IdCliente);
            Ejecutar(cmd);
        }
        public void EliminarRecibido(string id_telefono, string id_cliente)
        {
            MySqlCommand cmd = new MySqlCommand(recibidos.QueryDelete("id_telefono=@id_telefono AND id_cliente=@id_cliente"), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", id_telefono);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            Ejecutar(cmd);
        }
        #endregion

        #region TELEFONOS
        public IEnumerable<Telefono> Telefonos()
        {
            DataTable tabla = Tabla(telefonos);

            foreach (DataRow item in tabla.Rows)
            {
                Telefono telefono = new Telefono();
                telefono.IdTelefono = item[0].ToString();
                telefono.Modelo = item[1].ToString();
                telefono.Descripcion = item[2].ToString();
                telefono.FechaLlegada = (DateTime)item[3];
                telefono.IdProblema = item[4].ToString();
                telefono.Armado = (bool)item[5];
                telefono.Imei = item[6].ToString();
                telefono.Contrasena = item[7].ToString();
                yield return telefono;
            }
            yield break;
        }
        public void AgregarTelefono(Telefono miTelefono)
        {
            MySqlCommand cmd = new MySqlCommand(telefonos.QueryInsert(), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", miTelefono.IdTelefono);
            cmd.Parameters.AddWithValue("@modelo", miTelefono.Modelo);
            cmd.Parameters.AddWithValue("@descripcion", miTelefono.Descripcion);
            cmd.Parameters.AddWithValue("@fecha_llegada", miTelefono.FechaLlegada);
            cmd.Parameters.AddWithValue("@id_problema", miTelefono.IdProblema);
            cmd.Parameters.AddWithValue("@armado", miTelefono.Armado);
            cmd.Parameters.AddWithValue("@imei", miTelefono.Imei);
            cmd.Parameters.AddWithValue("@contrasena", miTelefono.Contrasena);
            Ejecutar(cmd);
        }
        public void EliminarTelefono(string id_telefono)
        {
            MySqlCommand cmd = new MySqlCommand(telefonos.QueryDelete("id_telefono=@id_telefono"), miConexion);
            cmd.Parameters.AddWithValue("@id_telefono", id_telefono);
            Ejecutar(cmd);
        }
        #endregion
    }
}