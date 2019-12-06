using iS_Repair.Clases.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Forms
{
    public partial class Reporte : Form
    {
        public Reporte(int idCliente)
        {
            InitializeComponent();
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            dgvTelefonos.Height = (int) (Size.Height * .80);
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("select * from reporte_cliente ("+idCliente+")", con);
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                txtID.Text = reader[0].ToString();
                txtNombre.Text = reader[1].ToString();
                txtNumTel.Text = reader[2].ToString();
                do
                {
                    if(reader[3] is DBNull)
                        break;
                    dgvTelefonos.Rows.Add(reader[3],reader[4],
                        (reader[5] is DBNull) ? "N/A" : reader[5],
                        (reader[6] is DBNull) ? "N/A" : double.Parse((reader.GetSqlMoney(6).ToString())).ToString("C"),
                        (reader[7] is DBNull) ? "N/A" : reader[7]);
                } while (reader.Read());
                reader.Close();
                con.Close();
            }
        }

        private void Reporte_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
