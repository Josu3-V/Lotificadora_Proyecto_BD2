using DB2Lotificadora.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2Lotificadora.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //inicializamos la conexion a la base de datos
                SqlConnection nc = conexion.crarInstacia().CrearConexion();
                nc.Open();

                String consulta = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Contrasenia = @Contrasenia";
                SqlCommand cmd = new SqlCommand(consulta, nc);
                cmd.Parameters.AddWithValue("@Usuario", tbUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@Contrasenia", tbContrasenia.Text.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {

                    Home homeForm = new Home();
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion :" + ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
