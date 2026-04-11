using DB2Lotificadora.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB2Lotificadora.Screens
{
    public partial class calculo_plandepago : Form
    {
        public calculo_plandepago()
        {
            InitializeComponent();
        }

        private void calculo_plandepago_Load(object sender, EventArgs e)
        {
            try
            {
                conexion con = conexion.crarInstacia();
                // Cargar todas las ventas al abrir el form
                DataTable dt = con.EjecutarConsulta("EXEC leer_venta2");
                dgvplandepago.DataSource = dt;

                // Configuración visual
                dgvplandepago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvplandepago.MultiSelect = false;
                dgvplandepago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Gomez homeForm = new Lotificadora_Gomez();
            homeForm.Show();
            this.Close();
        }

        private void dgvplandepago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Limpia el Label antes de escribir
                    lblplandepago.Text = string.Empty;
                    // Obtener el VentaID de la fila seleccionada
                    int ventaId = Convert.ToInt32(dgvplandepago.Rows[e.RowIndex].Cells["ventaid"].Value);

                    conexion con = conexion.crarInstacia();

                    // Generar plan de pagos con el SP
                    con.EjecutarConsulta($"EXEC sp_GenerarPlanPagos {ventaId}");

                    // Consultar el plan de pagos generado
                    DataTable dtPlan = con.EjecutarConsulta($"SELECT * FROM planpago WHERE ventaid = {ventaId}");

                    // Mostrar un resumen en el Label
                    lblplandepago.Text = $"Plan de pagos generado para VentaID {ventaId}:\n" +
                                   $"Total de cuotas: {dtPlan.Rows.Count}\n" +
                                   $"Primera cuota: {dtPlan.Rows[0]["totalcuota"]} " +
                                   $"con vencimiento {dtPlan.Rows[0]["fechavencimiento"]}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar plan de pagos: " + ex.Message);
            }
        }

    }
}
