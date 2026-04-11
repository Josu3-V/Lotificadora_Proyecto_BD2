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
    public partial class lotesporetapas : Form
    {
        public lotesporetapas()
        {
            InitializeComponent();
        }


        private void lotesporetapas_Load(object sender, EventArgs e)
        {
            try
            {
                conexion con = conexion.crarInstacia();
                DataTable dt = con.EjecutarConsulta("EXEC leer_etapa2");
                dgvletapas.DataSource = dt;

                dgvletapas.ReadOnly = false;
                dgvletapas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvletapas.MultiSelect = false;
                dgvletapas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvletapas.Columns["etapaid"].HeaderText = "ID Etapa";
                dgvletapas.Columns["proyectoid"].HeaderText = "Proyecto";
                dgvletapas.Columns["areatotal"].HeaderText = "Área total";
                dgvletapas.Columns["arealotificacion"].HeaderText = "Área lotificación";
                dgvletapas.Columns["areaverde"].HeaderText = "Área verde";
                dgvletapas.Columns["areacomun"].HeaderText = "Área común";
                dgvletapas.Columns["preciovaracuadrada"].HeaderText = "Precio m²";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar etapas: " + ex.Message);
            }
        }

        private void dgvletapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener el ID de la etapa seleccionada
                    int etapaId = Convert.ToInt32(dgvletapas.Rows[e.RowIndex].Cells["etapaid"].Value);

                    // Conexión y consulta de lotes por etapa
                    conexion con = conexion.crarInstacia();
                    DataTable dtLotes = con.EjecutarConsulta($"SELECT * FROM dbo.fn_lotes_etapa({etapaId});");

                    // Mostrar los lotes en el segundo DataGridView
                    dgvlotesporetapas.DataSource = dtLotes;

                    // Configuración visual básica
                    dgvlotesporetapas.ReadOnly = true;
                    dgvlotesporetapas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvlotesporetapas.MultiSelect = false;
                    dgvlotesporetapas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lotes: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lotificadora_Gomez homeForm = new Lotificadora_Gomez();
            homeForm.Show();
            this.Close();
        }
    }
}
