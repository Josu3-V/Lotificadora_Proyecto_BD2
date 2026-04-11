using DB2Lotificadora.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2Lotificadora.Screens
{
    public partial class Lotificadora_Gomez : Form
    {
        public Lotificadora_Gomez()
        {
            InitializeComponent();
        }
        private void Lotificadora_Lopez_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios userForm = new Usuarios();
            userForm.Show();
            this.Close();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            try
            {
                conexion con = conexion.crarInstacia();
                DataTable dt = con.EjecutarConsulta("SELECT * FROM vLotes_disponibles");
                dgvPrincipal.DataSource = dt;

                // Personalización del DataGridView
                dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvPrincipal.DefaultCellStyle.ForeColor = Color.DarkBlue;
                dgvPrincipal.DefaultCellStyle.BackColor = Color.White;
                dgvPrincipal.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                dgvPrincipal.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPrincipal.EnableHeadersVisualStyles = false;

                dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPrincipal.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lotes disponibles: " + ex.Message);
            }
        }


        private void btnPagos_Click(object sender, EventArgs e)
        {
            Pagos pagosForm = new Pagos();
            pagosForm.Show();
            this.Close();
        }

        private void btnVentas(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de la conexión
                conexion con = conexion.crarInstacia();

                // Ejecutar consulta sobre la vista
                DataTable dt = con.EjecutarConsulta("SELECT * FROM vVentas_por_proyecto");

                // Mostrar resultados en el DataGridView principal
                dgvPrincipal.DataSource = dt;

                // Personalización del DataGridView
                dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvPrincipal.DefaultCellStyle.ForeColor = Color.DarkBlue;
                dgvPrincipal.DefaultCellStyle.BackColor = Color.White;
                dgvPrincipal.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                dgvPrincipal.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPrincipal.EnableHeadersVisualStyles = false;

                dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPrincipal.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas por proyecto: " + ex.Message);
            }
        }

        private void btnplanpagos_Click(object sender, EventArgs e)
        {
            calculo_plandepago homeForm = new calculo_plandepago();
            homeForm.Show();
            this.Close();
        }
    }
}
