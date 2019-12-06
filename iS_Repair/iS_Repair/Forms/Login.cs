using iS_Repair.Clases.ClasesTablas;
using iS_Repair.Clases.DataBase;
using iS_Repair.Clases.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iS_Repair.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            try
            {
                if (ConexionBD.DetectarAdmin() == null)
                {
                    lblLogin.Text = "Registrar un administrador";
                    btnRegistrar.ButtonText = "Registrar";
                }
            }
            catch (Exception)
            {
                MessageUtil.Error("Se presento un error con la base de datos.\nContacte con un administrador.");
            }
        }

        private void IniciarSistema(Empleado emp)
        {
            this.Hide();
            new MainForm(this).Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "")
            {
                return;
            }
            if (lblLogin.Text != "LOGIN")
            {
                try
                {
                    //se inicia sesion con admin nuevo
                    Empleado emp;
                    ConexionBD.InsertarEmpleado(emp=new Empleado(txtUsuario.Text, txtContrasena.Text, "Admin", " ", " ", " ", "reparacionesisteff@gmail.com", "Morelos #610 Col Centro Nuevo Laredo", true));
                    IniciarSistema(emp);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                Empleado emp = ConexionBD.DetectarEmpleado(txtUsuario.Text, txtContrasena.Text);
                if(emp == null)
                {
                    MessageUtil.Error("El empleado no existe o la contraseña es incorrecta.");
                    return;
                }
                if (emp.Usuario.Equals(txtUsuario.Text)
                && emp.Contrasena.Equals(txtContrasena.Text))
                {
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    IniciarSistema(emp);
                }
            }
        }
        

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 4 && e.KeyData != Keys.Back)
            {
                e.SuppressKeyPress = true;
            } 
            if(txt.Equals(txtContrasena) && e.KeyData == Keys.Enter)
            {
                btnRegistrar_Click(sender, e);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageUtil.Confirmation("¿Desea cerrar el programa?"))
            {
                this.Close();
            }
        }
    }
}
