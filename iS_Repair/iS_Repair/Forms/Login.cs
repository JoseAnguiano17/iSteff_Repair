using iS_Repair.Clases.DataBase;
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
                if (ConexionBD.DetectarAdmin().Administrador)
                {
                    txtUsuario.Text = ConexionBD.DetectarAdmin().Usuario;
                }
                else
                {
                    lblLogin.Text = "Registrar un administrador";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (lblLogin.Text != "LOGIN")
            {
                try
                {
                    ConexionBD.InsertarEmpleado(new Clases.ClasesTablas.Empleado(txtUsuario.Text, txtContrasena.Text, "Admin",
                                               "", "", "", "reparacionesisteff@gmail.com", "Morelos #610 Col Centro Nuevo Laredo", true));
                    //se inicia sesion con admin nuevo
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                if(ConexionBD.DetectarEmpleado(txtUsuario.Text, txtContrasena.Text).Usuario.Equals(txtUsuario.Text)
                && ConexionBD.DetectarEmpleado(txtUsuario.Text, txtContrasena.Text).Contrasena.Equals(txtContrasena.Text))
                {
                    if (ConexionBD.DetectarEmpleado(txtUsuario.Text, txtContrasena.Text).Administrador)
                    {
                        //inicia admin
                    }
                    else
                    {
                        //inicia user
                    }
                }
            }
        }
    }
}
