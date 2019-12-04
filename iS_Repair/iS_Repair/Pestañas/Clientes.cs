using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iS_Repair.Clases;
using System.Data.SqlClient;
using iS_Repair.Clases.DataBase;
using iS_Repair.Clases.ClasesTablas;

namespace iS_Repair.Pestañas
{
    public partial class Clientes : UserControl
    {
        Filtro miFiltro = new Filtro();

        public Clientes()
        {
            InitializeComponent();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FiltrarDGV();
            lblID.Text = "ID: " + ConexionBD.ObtenerID();
        }

        void ActualizarDGV()
        {
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in ConexionBD.CargarClientes())
            {
                dgvClientes.Rows.Add(cliente.ID, cliente.Nombre, cliente.ApellidoP, cliente.ApellidoM, cliente.NumeroTelefono);
            }
        }

        private void Clientes_SizeChanged(object sender, EventArgs e)
        {
            if(MainForm.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                cardDatosCLiente.Location = new Point(pnTop.Width / 3, cardDatosCLiente.Location.Y); 
            } else{

                cardDatosCLiente.Location = new Point((int)(pnTop.Width / 3.5), cardDatosCLiente.Location.Y);
            }
            sepDivisor.Width = (int)(pnContenido.Width * .96);
        }

        private void btnDownTopPanel_Click(object sender, EventArgs e)
        {
            if(pnTop.Height <= 50)
            {
                pnTop.Height = cardDatosCLiente.Height + sepDivisor.Height + 60;
            }
            else
            {
                pnTop.Height = 50;
            }
        }

        private void ChkNombre_OnChange(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                txtFNombre.Enabled = true;
                txtFNombre.BackColor = Color.Thistle;
                miFiltro.Nombre = true;
            }
            else
            {
                txtFNombre.Enabled = false;
                txtFNombre.Text = "";
                txtFNombre.BackColor = Color.LightGray;
                miFiltro.Nombre = false;
                FiltrarDGV();
            }
        }

        private void ChkApellidoP_OnChange(object sender, EventArgs e)
        {
            if (chkApellidoP.Checked)
            {
                txtFApeP.Enabled = true;
                txtFApeP.BackColor = Color.Thistle;
                miFiltro.ApellidoP = true;
            }
            else
            {
                txtFApeP.Enabled = false;
                txtFApeP.Text = "";
                txtFApeP.BackColor = Color.LightGray;
                miFiltro.ApellidoP = false;
                FiltrarDGV();
            }
        }

        private void ChkApellidoM_OnChange(object sender, EventArgs e)
        {
            if (chkApellidoM.Checked)
            {
                txtFApeM.Enabled = true;
                txtFApeM.BackColor = Color.Thistle;
                miFiltro.ApellidoM = true;
            }
            else
            {
                txtFApeM.Enabled = false;
                txtFApeM.Text = "";
                txtFApeM.BackColor = Color.LightGray;
                miFiltro.ApellidoM = false;
                FiltrarDGV();
            }
        }

        private void ChkNumTel_OnChange(object sender, EventArgs e)
        {
            if (chkNumTel.Checked)
            {
                txtFNumTel.Enabled = true;
                txtFNumTel.BackColor = Color.Thistle;
                miFiltro.NumTel = true;
            }
            else
            {
                txtNumTel.Enabled = false;
                txtFNumTel.Text = "";
                txtFNumTel.BackColor = Color.LightGray;
                miFiltro.NumTel = false;
                FiltrarDGV();
            }
        }

        private void TxtFNombre_TextChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                if (txtFNombre.Text != "")
                {
                    miFiltro.Nombre = true;
                    miFiltro.NombreValor = txtFNombre.Text;
                    FiltrarDGV();
                    return;
                }
                miFiltro.Nombre = false;
                FiltrarDGV();
            }
        }

        private void TxtFApeP_TextChanged(object sender, EventArgs e)
        {
            if (chkApellidoP.Checked)
            {
                if (txtFApeP.Text != "")
                {
                    miFiltro.ApellidoP = true;
                    miFiltro.ApellidoPValor = txtFApeP.Text;
                    FiltrarDGV();
                    return;
                }
                miFiltro.ApellidoP = false;
                FiltrarDGV();
            }
        }

        private void TxtFApeM_TextChanged(object sender, EventArgs e)
        {
            if (chkApellidoM.Checked)
            {
                if (txtFApeM.Text != "")
                {
                    miFiltro.ApellidoM = true;
                    miFiltro.ApellidoMValor = txtFApeM.Text;
                    FiltrarDGV();
                    return;
                }
                miFiltro.ApellidoM = false;
                FiltrarDGV();
            }
        }

        private void TxtFNumTel_TextChanged(object sender, EventArgs e)
        {
            if (chkNumTel.Checked)
            {
                if (txtFNumTel.Text != "")
                {
                    miFiltro.NumTel = true;
                    miFiltro.NumTelValor = txtFNumTel.Text;
                    FiltrarDGV();
                    return;
                }
                miFiltro.NumTel = false;
                FiltrarDGV();
            }
        }

        private void ChkID_OnChange(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                txtFID.Enabled = true;
                txtFID.BackColor = Color.Thistle;
                miFiltro.IDUno32 = true;
            }
            else
            {
                txtFID.Enabled = false;
                txtFID.Text = "";
                txtFID.BackColor = Color.LightGray;
                miFiltro.IDUno32 = false;
                FiltrarDGV();
            }
        }

        public List<Cliente> FiltrarClientes()
        {
            if (miFiltro.GenerarCondicion("CLIENTE") == "")
            {
                return ConexionBD.CargarClientes();
            }

            List<Cliente> listaClientes = new List<Cliente>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE WHERE" 
                                                    + miFiltro.GenerarCondicion("CLIENTE"), con);
                SqlDataReader Clientes = comando.ExecuteReader();
                while (Clientes.Read())
                {
                    listaClientes.Add(new Cliente(Clientes.GetInt32(0), 
                                      Clientes.GetString(1), 
                                      Clientes.GetString(2), Clientes.GetString(3), 
                                      Clientes.GetString(4)));
                }
            }
            return listaClientes;
        }

        public void FiltrarDGV()
        {
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in FiltrarClientes())
            {
                dgvClientes.Rows.Add(cliente.ID, cliente.Nombre, 
                                     cliente.ApellidoP, cliente.ApellidoM, 
                                     cliente.NumeroTelefono);
            }
        }

        private void TxtFID_TextChanged(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                if(txtFID.Text != "")
                {
                    miFiltro.IDUno32 = true;
                    miFiltro.IDUno32Valor = int.Parse(txtFID.Text);
                    FiltrarDGV();
                    return;
                }
                miFiltro.IDUno32 = false;
                FiltrarDGV();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Cliente miCliente = new Cliente(0, txtNombre.Text, txtApeP.Text, 
                                            txtApeM.Text, txtNumTel.Text);
            ConexionBD.InsertarCliente(miCliente);
            FiltrarDGV();
        }
    }
}
