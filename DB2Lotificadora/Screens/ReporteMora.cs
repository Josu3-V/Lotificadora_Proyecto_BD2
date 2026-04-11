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
using DB2Lotificadora.Datos;

namespace DB2Lotificadora.Screens
{
    public partial class ReporteMora : Form
    {
        private readonly conexion db;

        public ReporteMora()
        {
            InitializeComponent();
            db = conexion.crarInstacia();
        }

        private void ReporteMora_Load(object sender, EventArgs e)
        {
            EjecutarReporte();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            EjecutarReporte();
        }

        private void EjecutarReporte()
        {
            try
            {
                DataTable dt = db.EjecutarProcedimiento(
                    "sp_ReporteCuotasVencidasPorCliente", null);

                dgvMora.DataSource = dt;
                FormatearColumnas();
                MostrarResumen(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearColumnas()
        {
            var c = dgvMora.Columns;
            if (c.Contains("ClienteID")) c["ClienteID"].HeaderText = "ID";
            if (c.Contains("NombreCliente")) c["NombreCliente"].HeaderText = "Cliente";
            if (c.Contains("CuotasVencidas")) c["CuotasVencidas"].HeaderText = "Cuotas vencidas";
            if (c.Contains("MontoTotalMora")) c["MontoTotalMora"].HeaderText = "Monto en mora";

            dgvMora.ReadOnly = true;
            dgvMora.AllowUserToAddRows = false;
            dgvMora.AllowUserToDeleteRows = false;
            dgvMora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MostrarResumen(DataTable dt)
        {
            int totalClientes = dt.Rows.Count;
            int totalCuotas = 0;
            decimal totalMonto = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (int.TryParse(row["CuotasVencidas"]?.ToString(), out int c))
                    totalCuotas += c;
                if (decimal.TryParse(row["MontoTotalMora"]?.ToString(), out decimal m))
                    totalMonto += m;
            }

            
            tbCMora.Text = totalClientes.ToString();
            btTTCVencida.Text = totalCuotas.ToString();
            tbMTMora.Text = string.Format("L. {0:N2}", totalMonto);
        }

        private void dgwMora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Lopez lotlopez = new Lotificadora_Lopez();
            lotlopez.Show();
            this.Close();
        }
    }
}
