using DB2Lotificadora.Datos;
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

namespace DB2Lotificadora.Screens
{
    public partial class frConectar : Form
    {
        public frConectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon = conexion.crarInstacia().CrearConexion();

            try
            {
                sqlcon.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);

            }
        }
    }
}   
