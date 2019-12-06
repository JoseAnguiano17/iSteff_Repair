using iS_Repair.Clases.ClasesTablas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.DataBase
{
    public abstract class ConexionBD
    {
        public static string strConexion;
        public static SqlConnection ObtenerConexion()
        {
            if(strConexion==null)
            {
                List<SqlConnection> sqlLista = ObtenerListaConexiones();
                foreach (SqlConnection connection in sqlLista)
                {
                    try
                    {
                        connection.Open();
                        strConexion = connection.ConnectionString;
                        return connection;
                    }
                    catch (Exception) { }
                }
                throw new Exception("No se logró ninguna conexión.");
            }
            else
            {
                SqlConnection con = new SqlConnection(strConexion);
                con.Open();
                return con;
            }
        }
        public static List<SqlConnection> ObtenerListaConexiones()
        {
            List<SqlConnection> sqlLista = new List<SqlConnection>();
            sqlLista.Add(new SqlConnection(CrearCadenaConexion("ANGUIANO-PC", "SERVER")));
            sqlLista.Add(new SqlConnection(CrearCadenaConexion("Maro", "")));
            sqlLista.Add(new SqlConnection(CrearCadenaConexion("Anguiano", "")));
            return sqlLista;
        }

        public static string CrearCadenaConexion(string strHostName, string strInstancia)
        {
            return "Data Source = "+strHostName+"; Initial Catalog = iSteff; Server = "+strHostName+ @"\"+strInstancia+ "; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True";
        }

        #region Cliente
        public static List<Cliente> CargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE", con);
                SqlDataReader Clientes = comando.ExecuteReader();
                while (Clientes.Read())
                {
                    listaClientes.Add(new Cliente(Clientes.GetInt32(0), Clientes.GetString(1), 
                        Clientes.GetString(2), Clientes.GetString(3), Clientes.GetString(4)));
                }
                Clientes.Close();
                con.Close();
            }
            return listaClientes;
        }

        public static void InsertarCliente(Cliente cliente)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO CLIENTE (NOMBRE, APELLIDOP, APELLIDOM, NUMTELEFONO)" +
                                         " VALUES (@nombre, @apellidoP, @apellidom, @numtelefono)", con);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellidop", cliente.ApellidoP);
                comando.Parameters.AddWithValue("@apellidom", cliente.ApellidoM);
                comando.Parameters.AddWithValue("@numtelefono", cliente.NumeroTelefono);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion
        
        #region Empleado
        public static List<Empleado> CargarEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADO", con);
                SqlDataReader Empleados = comando.ExecuteReader();
                while (Empleados.Read())
                {
                    listaEmpleados.Add(new Empleado(Empleados.GetString(0), Empleados.GetString(1), Empleados.GetString(2), Empleados.GetString(3), Empleados.GetString(4), Empleados.GetString(5), Empleados.GetString(6), Empleados.GetString(7), Empleados.GetBoolean(8)));
                }
                Empleados.Close();
                con.Close();
            }
            return listaEmpleados;
        }

        public static void InsertarEmpleado(Empleado emp)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO EMPLEADO (USUARIO, CONTRASENA, NOMBRE, APELLIDOP" +
                                                    " APELLIDOM, NUMTELEFONO, CORREO, DIRECCION)" +
                                         " VALUES (@usuario, @contrasena, @nombre, @apellidoP, @apellidom, @numtelefono" +
                                         " @correo, @direccion, @administrador)", con);
                comando.Parameters.AddWithValue("@usuario", emp.Usuario);
                comando.Parameters.AddWithValue("@contrasena", emp.Contrasena);
                comando.Parameters.AddWithValue("@nombre", emp.Nombre);
                comando.Parameters.AddWithValue("@apellidop", emp.ApellidoP);
                comando.Parameters.AddWithValue("@apellidom", emp.ApellidoM);
                comando.Parameters.AddWithValue("@numtelefono", emp.Telefono);
                comando.Parameters.AddWithValue("@correo", emp.Correo);
                comando.Parameters.AddWithValue("@direccion", emp.Direccion);
                comando.Parameters.AddWithValue("@administrador", emp.Administrador);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        #region Estado
        public static List<Estado> CargarEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ESTADO", con);
                SqlDataReader Estados = comando.ExecuteReader();
                while (Estados.Read())
                {
                    listaEstados.Add(new Estado(Estados.GetInt16(0), Estados.GetString(1), Estados.GetString(2), Estados.GetInt32(3)));
                }
                Estados.Close();
                con.Close();
            }
            return listaEstados;
        }

        public static void InsertarEstado(Estado est)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ESTADO (NOMBREESTADO, DESCRIPESTADO, COLOR)" +
                                         " VALUES (@nombreestado, @descripestado, @color)", con);
                comando.Parameters.AddWithValue("@nombreestado", est.Nombre);
                comando.Parameters.AddWithValue("@descripestado", est.Descripcion);
                comando.Parameters.AddWithValue("@color", est.Color);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        #region Pedido
        public static List<Pedido> CargarPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PEDIDO", con);
                SqlDataReader Pedidos = comando.ExecuteReader();
                while (Pedidos.Read())
                {
                    listaPedidos.Add(new Pedido(Pedidos.GetInt32(0), Pedidos.GetString(1), double.Parse(Pedidos.GetSqlMoney(2).ToString()), Pedidos.GetBoolean(3), (Pedidos["fechapedido"] is DBNull)? DateTime.MinValue : Pedidos.GetDateTime(4), Pedidos.GetDateTime(5), Pedidos.GetInt32(6), Pedidos.GetString(7)));
                }
                Pedidos.Close();
                con.Close();
            }
            return listaPedidos;
        }

        public static void InsertarPedido(Pedido pedido)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PEDIDO (PIEZA, COSTO, YAPEDIDO" +
                                                    " FECHAPEDIDO, FECHAREGISTRADO, IDCLIENTE, USUARIO)" +
                                                    " VALUES (@pieza, @costo, @yapedido, @fechapedido, @fecharegistrado, @idcliente, @usuario)", con);
                comando.Parameters.AddWithValue("@pieza", pedido.Pieza);
                comando.Parameters.AddWithValue("@costo", pedido.Costo);
                comando.Parameters.AddWithValue("@yapedido", pedido.YaPedido);
                comando.Parameters.AddWithValue("@fechapedido", pedido.FechaPedido);
                comando.Parameters.AddWithValue("@fecharegistrado", pedido.FechaRegistro);
                comando.Parameters.AddWithValue("@idcliente", pedido.IDCliente);
                comando.Parameters.AddWithValue("@usuario", pedido.Usuario);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion
        
        #region Pendiente
        public static List<Pendiente> CargarPendientes()
        {
            List<Pendiente> listaPendientes = new List<Pendiente>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PENDIENTE", con);
                SqlDataReader Pendientes = comando.ExecuteReader();
                while (Pendientes.Read())
                {
                    listaPendientes.Add(new Pendiente(Pendientes.GetInt32(0), Pendientes.GetString(1), Pendientes.GetDateTime(2), Pendientes.GetString(3)));
                }
                Pendientes.Close();
                con.Close();
            }
            return listaPendientes;
        }

        public static void InsertarPendiente(Pendiente pend)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PENDIENTE (DESCRIPPENDIENTE, FECHAREGISTRO, USUARIO)"+
                                                    " VALUES (@descrippendiente, @fecharegistro, @usuario)", con);
                comando.Parameters.AddWithValue("@descrippendiente", pend.Descripcion);
                comando.Parameters.AddWithValue("@fecharegistro", pend.FechaRegistro);
                comando.Parameters.AddWithValue("@usuario", pend.Usuario);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        #region Problema
        public static List<Problema> CargarProblemas()
        {
            List<Problema> listaProblemas = new List<Problema>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PROBLEMA", con);
                SqlDataReader Problemas = comando.ExecuteReader();
                while (Problemas.Read())
                {
                    listaProblemas.Add(new Problema(Problemas.GetInt16(0), Problemas.GetString(1), Problemas.GetDouble(2)));
                }
                Problemas.Close();
                con.Close();
            }
            return listaProblemas;
        }

        public static void InsertarProblema(Problema prob)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PROBLEMA (DESCRIPPROBLEMA, COSTO)" +
                                                    " VALUES (@descripproblema, @costo)", con);
                comando.Parameters.AddWithValue("@descripproblema", prob.Descripcion);
                comando.Parameters.AddWithValue("@costo", prob.Costo);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        #region Telefono
        public static List<Telefono> CargarTelefonos()
        {
            List<Telefono> listaTelefonos = new List<Telefono>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM TELEFONO", con);
                SqlDataReader Telefonos = comando.ExecuteReader();
                while (Telefonos.Read())
                {
                    listaTelefonos.Add(new Telefono(Telefonos.GetInt32(0),
                        Telefonos.GetString(1),
                        (Telefonos[2] is DBNull) ? null : Telefonos.GetString(2),
                        Telefonos.GetBoolean(3),
                        (Telefonos[4] is DBNull) ? null : Telefonos.GetString(4),
                        (Telefonos[5] is DBNull) ? null : Telefonos.GetString(5),
                        char.Parse(Telefonos.GetString(6)),
                        Telefonos.GetDateTime(7),
                        Telefonos.GetInt16(8),
                        Telefonos.GetInt32(9)));
                }
                Telefonos.Close();
                con.Close();
            }
            return listaTelefonos;
        }

        public static void InsertarTelefono(Telefono tel)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO TELEFONO (MODELO, DESCRIPTELEFONO, ARMADO" +
                                                    " IMEI, CONTRASENA, RANGO, FECHALLEGADA, IDESTADO, IDCLIENTE)" +
                                                    " VALUES (@modelo, @descriptelefono, @armado," +
                                                    " @imei, @contrasena, @rango, @fechallegada, @idestado, @idcliente)", con);
                comando.Parameters.AddWithValue("@modelo", tel.Modelo);
                comando.Parameters.AddWithValue("@descriptelefono", tel.Descripcion);
                comando.Parameters.AddWithValue("@armado", tel.Armado);
                comando.Parameters.AddWithValue("@imei", tel.IMEI);
                comando.Parameters.AddWithValue("@contrasena", tel.Contrasena);
                comando.Parameters.AddWithValue("@rango", tel.Rango);
                comando.Parameters.AddWithValue("@fechallegada", tel.FechaLlegada);
                comando.Parameters.AddWithValue("@idestado", tel.IDEstado);
                comando.Parameters.AddWithValue("@idcliente", tel.IDCliente);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        #region Telprob
        public static List<Telprob> CargarTelprobs()
        {
            List<Telprob> listaTelprobs = new List<Telprob>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM TELPROB", con);
                SqlDataReader Telprobs = comando.ExecuteReader();
                while (Telprobs.Read())
                {
                    listaTelprobs.Add(new Telprob(Telprobs.GetInt32(0), Telprobs.GetInt16(1), Telprobs.GetDateTime(2)));
                }
                Telprobs.Close();
                con.Close();
            }
            return listaTelprobs;
        }

        public static void InsertarTelProb(Telprob telp)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO TELPROB (IDTELEFONO, IDPROBLEMA, FECHASOLUCION)" +
                                                    " VALUES (@idtelefono, @idproblema, @fechasolucion)", con);
                comando.Parameters.AddWithValue("@idtelefono", telp.ID);
                comando.Parameters.AddWithValue("@idproblema", telp.IDProblema);
                comando.Parameters.AddWithValue("@fechasolucion", telp.FechaSolucion);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        #endregion

        public static int ObtenerID()
        {
            int intID = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('CLIENTE')", con);
                SqlDataReader intValor = comando.ExecuteReader();
                intValor.Read();
                intID = (int)intValor.GetDecimal(0) + 1;
                intValor.Close();
                con.Close();
            }
            return intID;
        }

        public static Empleado DetectarAdmin()
        {
            Empleado empleado = null;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADO WHERE ADMINISTRADOR = 1", con);
                SqlDataReader sqlEmpleado = comando.ExecuteReader();
                while (sqlEmpleado.Read())
                {
                    empleado = new Empleado(sqlEmpleado.GetString(0), sqlEmpleado.GetString(1), sqlEmpleado.GetString(2), sqlEmpleado.GetString(3), sqlEmpleado.GetString(4), sqlEmpleado.GetString(5), sqlEmpleado.GetString(6), sqlEmpleado.GetString(7), sqlEmpleado.GetBoolean(8));
                }
                sqlEmpleado.Close();
                con.Close();
            }
            return empleado;
        }

        public static Empleado DetectarEmpleado(string strUsuario, string strContrasena)
        {
            Empleado empleado = null;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADO WHERE USUARIO = '" + strUsuario + "' AND CONTRASENA = '" + strContrasena + "'", con);
                SqlDataReader sqlEmpleado = comando.ExecuteReader();
                while (sqlEmpleado.Read())
                {
                    empleado = new Empleado(sqlEmpleado.GetString(0), sqlEmpleado.GetString(1), sqlEmpleado.GetString(2), sqlEmpleado.GetString(3), sqlEmpleado.GetString(4), sqlEmpleado.GetString(5), sqlEmpleado.GetString(6), sqlEmpleado.GetString(7), sqlEmpleado.GetBoolean(8));
                }
                sqlEmpleado.Close();
            }
            return empleado;
        }
    }
}
