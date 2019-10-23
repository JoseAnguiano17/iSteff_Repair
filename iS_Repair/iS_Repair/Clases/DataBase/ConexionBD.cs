using iS_Repair.Clases.ClasesTablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
            sqlLista.Add(new SqlConnection(CrearCadenaConexion("Maro", "")));
            sqlLista.Add(new SqlConnection(CrearCadenaConexion("ANGUIANO-PC", "SERVER")));
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
                    listaClientes.Add(new Cliente(Clientes.GetInt32(0), Clientes.GetString(1), Clientes.GetString(2), Clientes.GetString(3), Clientes.GetString(4)));
                }
            }
            return listaClientes;
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
                    listaEmpleados.Add(new Empleado(Empleados.GetString(0), Empleados.GetString(1), Empleados.GetString(2), Empleados.GetString(3), Empleados.GetString(4), Empleados.GetString(5), Empleados.GetString(6), Empleados.GetString(7)));
                }
            }
            return listaEmpleados;
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
            }
            return listaEstados;
        }
        #endregion
        #region Pedido
        public static List<Pedido> CargarPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PEDIDO", con);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                adaptador.Dispose();
                comando.Dispose();
                foreach (DataRow row in tabla.Rows)
                {
                    listaPedidos.Add(
                        new Pedido(
                        (int) row[0], 
                        row[1].ToString(), 
                        double.Parse(row[2].ToString()),
                        (bool) row[3],
                        (row[4] is DBNull) ? DateTime.MinValue : (DateTime)row[4],
                        ((DateTime)row[5]),
                        (int)row[6], 
                        row[7].ToString()));
                }
            }
            return listaPedidos;
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
            }
            return listaPendientes;
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
            }
            return listaProblemas;
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
                    listaTelefonos.Add(new Telefono(Telefonos.GetInt32(0), Telefonos.GetString(1), Telefonos.GetString(2), Telefonos.GetBoolean(3), Telefonos.GetString(4), Telefonos.GetString(5), char.Parse(Telefonos.GetString(6)), Telefonos.GetDateTime(7), Telefonos.GetInt16(8), Telefonos.GetInt32(9)));
                }
            }
            return listaTelefonos;
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
            }
            return listaTelprobs;
        }
        #endregion
    }
}
