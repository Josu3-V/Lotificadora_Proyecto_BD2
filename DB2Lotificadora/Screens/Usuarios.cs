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
        private TextBox txtClienteId;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtEmpresa;
        private TextBox txtIngresoMensual;
        private DataGridView dgvClientes;
        private Button btnNuevo, btnGuardar, btnActualizar, btnEliminar, btnCancelar, btnBuscar;
        private TextBox txtBuscar;

        private conexion db;
        private bool isEditing = false;


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

            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Seleccione un cliente para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlParameter[] parametros = {
                    new SqlParameter("@clienteid", int.Parse(tbId.Text)),
                    new SqlParameter("@nombre", tbNombre.Text.Trim()),
                    new SqlParameter("@direccion", tbDireccion.Text.Trim()),
                    
                    new SqlParameter("@empresa", string.IsNullOrEmpty(tbEmpresa.Text) ? (object)DBNull.Value : tbEmpresa.Text.Trim()),
                    new SqlParameter("@ingresomensual", string.IsNullOrEmpty(tbIngresoMensual.Text) ? 0 : decimal.Parse(tbIngresoMensual.Text))
                };

                int resultado = db.EjecutarComando("actualizar_cliente", parametros);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = db.CrearConexion())
                {
                    string query = "SELECT clienteid, nombre, direccion, empresa, ingresomensual FROM cliente ORDER BY nombre";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                dgvClientes.DataSource = dt;

                // Formatear columnas
                if (dgvClientes.Columns.Contains("clienteid"))
                    dgvClientes.Columns["clienteid"].HeaderText = "ID";
                if (dgvClientes.Columns.Contains("nombre"))
                    dgvClientes.Columns["nombre"].HeaderText = "Nombre";
                if (dgvClientes.Columns.Contains("direccion"))
                    dgvClientes.Columns["direccion"].HeaderText = "Dirección";
                if (dgvClientes.Columns.Contains("empresa"))
                    dgvClientes.Columns["empresa"].HeaderText = "Empresa";
                if (dgvClientes.Columns.Contains("ingresomensual"))
                {
                    dgvClientes.Columns["ingresomensual"].HeaderText = "Ingreso Mensual";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Seleccione un cliente para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BuscarClientes(string filtro)
        {
            try
            {
                string query = @"SELECT clienteid, nombre, direccion, empresa, ingresomensual 
                                 FROM cliente 
                                 WHERE nombre LIKE @filtro LIKE @filtro
                                 ORDER BY nombre";

                SqlParameter[] parametros = { new SqlParameter("@filtro", $"%{filtro}%") };
                DataTable dt = db.EjecutarConsulta(query, parametros);
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tbId.Text = "";
            tbNombre.Text = "";
            tbDireccion.Text = "";
            tbEmpresa.Text = "";
            tbIngresoMensual.Text = "";
            isEditing = false;
            btnGuar.Enabled = true;
            btnActua.Enabled = false;
            btnElim.Enabled = false;

            tbNombre.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
