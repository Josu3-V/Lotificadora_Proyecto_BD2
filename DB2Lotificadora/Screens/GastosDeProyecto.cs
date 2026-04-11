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
    public partial class GastosDeProyecto : Form
    {
        private readonly conexion db;

        public GastosDeProyecto()
        {
            InitializeComponent();
            db = conexion.crarInstacia();
            dgvGastos.ReadOnly = true;
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;
            dgvGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Lopez lotlopez = new Lotificadora_Lopez();
            lotlopez.Show();
            this.Close();
        }

        private void GastosDeProyecto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txProyectoId.Text.Trim(), out int proyectoId))
            {
                MessageBox.Show("Ingrese un ID de proyecto válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txProyectoId.Focus();
                return;
            }
            try
            {

                object nombre = db.EjecutarEscalar(
                    "SELECT nombre FROM proyecto WHERE proyectoid = @id",
                    new[] { new SqlParameter("@id", proyectoId) });

                if (nombre == null)
                {
                    MessageBox.Show("No existe un proyecto con ese ID.", "Sin resultados",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tbNombreProyecto.Text = nombre.ToString();


                DataTable dt = db.EjecutarConsulta(
                    "SELECT * FROM dbo.fn_gastos_proyecto(@proyectoid) ORDER BY fecha DESC",
                    new[] { new SqlParameter("@proyectoid", proyectoId) });

                dgvGastos.DataSource = dt;
                FormatearColumnas();
                MostrarResumen(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormatearColumnas()
        {
            var c = dgvGastos.Columns;
            if (c.Contains("proyecto")) c["proyecto"].HeaderText = "Proyecto";
            if (c.Contains("banco")) c["banco"].HeaderText = "Banco";
            if (c.Contains("numerocuenta")) c["numerocuenta"].HeaderText = "No. Cuenta";
            if (c.Contains("tipogasto")) c["tipogasto"].HeaderText = "Tipo gasto";
            if (c.Contains("monto")) c["monto"].HeaderText = "Monto";
            if (c.Contains("fecha")) c["fecha"].HeaderText = "Fecha";
        }

        private void MostrarResumen(DataTable dt)
        {
            int totalGastos = dt.Rows.Count;
            decimal montoTotal = 0;

            foreach (DataRow row in dt.Rows)
                if (decimal.TryParse(row["monto"]?.ToString(), out decimal m))
                    montoTotal += m;

            tbTotalGastos.Text = totalGastos.ToString();
            tbMontoTotal.Text = string.Format("L. {0:N2}", montoTotal);
        }

        private void txProyectoId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, e);
        }
    }
}
