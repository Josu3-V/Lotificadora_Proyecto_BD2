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
using DB2Lotificadora.Datos;

namespace DB2Lotificadora.Screens
{
    public partial class Usuarios : Form
    {
        
        private readonly conexion db;

        public Usuarios()
        {
            InitializeComponent();
            db = conexion.crarInstacia();
            CargarClientes();
            LimpiarCampos();
        }

        private void btNuevoUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActua_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            if (!int.TryParse(tbId.Text, out int id))
            {
                MessageBox.Show("Seleccione un cliente para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(tbIngresoMensual.Text) &&
                !decimal.TryParse(tbIngresoMensual.Text.Trim(), out _))
            {
                MessageBox.Show("El ingreso mensual debe ser un número válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIngresoMensual.Focus();
                return;
            }

            try
            {
                decimal.TryParse(tbIngresoMensual.Text.Trim(), out decimal ingreso);

                SqlParameter[] p = {
                    new SqlParameter("@clienteid",      id),
                    new SqlParameter("@nombre",         tbNombre.Text.Trim()),
                    new SqlParameter("@direccion",      tbDireccion.Text.Trim()),
                    new SqlParameter("@telefono",       string.IsNullOrEmpty(tbTelefono.Text)
                                                        ? (object)DBNull.Value
                                                        : tbTelefono.Text.Trim()),
                    new SqlParameter("@empresa",        string.IsNullOrEmpty(tbEmpresa.Text)
                                                        ? (object)DBNull.Value
                                                        : tbEmpresa.Text.Trim()),
                    new SqlParameter("@ingresomensual", string.IsNullOrEmpty(tbIngresoMensual.Text)
                                                        ? (object)DBNull.Value
                                                        : ingreso)
                };

                int r = db.EjecutarComando("actualizar_cliente", p);
                if (r > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = db.EjecutarConsulta(
                    @"SELECT clienteid, nombre, direccion, telefono,
                             empresa, ingresomensual
                      FROM cliente
                      ORDER BY nombre", null);

                dgvClientesf.DataSource = dt;
                FormatearColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearColumnas()
        {
            var c = dgvClientesf.Columns;
            if (c.Contains("clienteid")) c["clienteid"].HeaderText = "ID";
            if (c.Contains("nombre")) c["nombre"].HeaderText = "Nombre";
            if (c.Contains("direccion")) c["direccion"].HeaderText = "Dirección";
            if (c.Contains("telefono")) c["telefono"].HeaderText = "Teléfono";
            if (c.Contains("empresa")) c["empresa"].HeaderText = "Empresa";
            if (c.Contains("ingresomensual")) c["ingresomensual"].HeaderText = "Ingreso mensual";
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de eliminar al cliente {tbNombre.Text}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlParameter[] parametros = { new SqlParameter("@clienteid", int.Parse(tbId.Text)) };
                    int resultado = db.EjecutarComando("eliminar_cliente", parametros);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarClientes();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("no se puede eliminar cliente con ventas activas"))
                        MessageBox.Show("No se puede eliminar el cliente porque tiene ventas asociadas", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscarClientes(string filtro)
        {
            try
            {
                DataTable dt = db.EjecutarConsulta(
                    @"SELECT clienteid, nombre, direccion, telefono,
                             empresa, ingresomensual
                      FROM cliente
                      WHERE nombre LIKE @filtro
                      ORDER BY nombre",
                    new[] { new SqlParameter("@filtro", $"%{filtro}%") });

                dgvClientesf.DataSource = dt;
                FormatearColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txBuscar.Text))
                BuscarClientes(txBuscar.Text);
            else
                CargarClientes();
        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBuscar.Text))
                CargarClientes();
            else
                BuscarClientes(txBuscar.Text);
        }

        private void dgvClientesf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientesf.CurrentRow == null) return;

            var row = dgvClientesf.CurrentRow;

            tbId.Text = row.Cells["clienteid"]?.Value?.ToString() ?? "";
            tbNombre.Text = row.Cells["nombre"]?.Value?.ToString() ?? "";
            tbDireccion.Text = row.Cells["direccion"]?.Value?.ToString() ?? "";
            tbTelefono.Text = row.Cells["telefono"]?.Value?.ToString() ?? "";
            tbEmpresa.Text = row.Cells["empresa"]?.Value?.ToString() ?? "";
            tbIngresoMensual.Text = row.Cells["ingresomensual"]?.Value?.ToString() ?? "";
            tbDeuda.Text = deuda != null ? string.Format("L. {0:N2}", deuda) : "L. 0.00";
            

            if (int.TryParse(tbId.Text, out int cid))
            {
                try
                {
                    object deuda = db.EjecutarEscalar(
                        "SELECT dbo.fn_deuda_cliente(@clienteid)",
                        new[] { new SqlParameter("@clienteid", cid) });
                    tbDeuda.Text = deuda != null
                        ? string.Format("L. {0:N2}", deuda)
                        : "L. 0.00";
                }
                catch { tbDeuda.Text = "—"; }

                try
                {
                    object eval = db.EjecutarEscalar(
                        "SELECT dbo.fn_evaluar_pago(@clienteid, 0)",
                        new[] { new SqlParameter("@clienteid", cid) });
                    tbEvaluacion.Text = eval?.ToString() ?? "sin datos";
                }
                catch { tbEvaluacion.Text = "—"; }
            }

            btnGuar.Enabled = false;
            btnActua.Enabled = true;
            btnElim.Enabled = true;
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            decimal ingreso = 0;
            if (!string.IsNullOrEmpty(tbIngresoMensual.Text) &&
                !decimal.TryParse(tbIngresoMensual.Text.Trim(), out ingreso))
            {
                MessageBox.Show("El ingreso mensual debe ser un número válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIngresoMensual.Focus();
                return;
            }

            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@nombre",        tbNombre.Text.Trim()),
                    new SqlParameter("@direccion",     tbDireccion.Text.Trim()),
                    new SqlParameter("@telefono",      string.IsNullOrEmpty(tbTelefono.Text)
                                                       ? (object)DBNull.Value
                                                       : tbTelefono.Text.Trim()),
                    new SqlParameter("@empresa",       string.IsNullOrEmpty(tbEmpresa.Text)
                                                       ? (object)DBNull.Value
                                                       : tbEmpresa.Text.Trim()),
                    new SqlParameter("@ingresomensual", string.IsNullOrEmpty(tbIngresoMensual.Text)
                                                       ? (object)DBNull.Value
                                                       : ingreso)
                };

                int r = db.EjecutarComando("crear_cliente", p);
                if (r > 0)
                {
                    MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tbId.Text = "";
            tbNombre.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            tbEmpresa.Text = "";
            tbIngresoMensual.Text = "";
            tbDeuda.Text = "";
            tbEvaluacion.Text = "";

            btnGuar.Enabled = true;
            btnActua.Enabled = false;
            btnElim.Enabled = false;

            tbNombre.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDireccion.Focus();
                return false;
            }
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Lopez lotlopez = new Lotificadora_Lopez();
            lotlopez.Show();
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
