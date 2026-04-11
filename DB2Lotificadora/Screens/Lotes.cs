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
    public partial class Lotes : Form
    {
        private readonly conexion db;

        public Lotes()
        {
            InitializeComponent();
            db = conexion.crarInstacia();
            CargarLotes();
            LimpiarCampos();
            cbEstado.Items.AddRange(new string[] { "Disponible", "Vendido", "Reservado" });
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Lopez lotlopezForm = new Lotificadora_Lopez();
            lotlopezForm.Show();
            this.Close();
        }

        private void Lotes_Load(object sender, EventArgs e)
        {

        }

        private void btNuevoLote_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                SqlParameter[] p = {
            new SqlParameter("@bloqueid", int.Parse(tbId.Text)),
            new SqlParameter("@area", decimal.Parse(tbArea.Text)),
            new SqlParameter("@valorbase", decimal.Parse(tbValorBase.Text)),
            new SqlParameter("@estado", cbEstado.SelectedItem?.ToString() ?? "Disponible"),
            new SqlParameter("@ubicacion", tbUbicacion.Text.Trim())
        };

                int r = db.EjecutarComando("crear_lote", p);
                if (r > 0)
                {
                    MessageBox.Show("Lote guardado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarLotes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
            
        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (!int.TryParse(tbId.Text, out int id))
            {
                MessageBox.Show("Seleccione un lote para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@loteid", id),
                    new SqlParameter("@bloqueid", int.Parse(tbId.Text)),
                    new SqlParameter("@area", decimal.Parse(tbArea.Text)),
                    new SqlParameter("@valorbase", decimal.Parse(tbValorBase.Text)),
                    new SqlParameter("@estado", cbEstado.SelectedItem?.ToString() ?? "Disponible"),
                    new SqlParameter("@ubicacion", tbUbicacion.Text.Trim())
                };

                int r = db.EjecutarComando("actualizar_lote", p);
                if (r > 0)
                {
                    MessageBox.Show("Lote actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarLotes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Seleccione un lote para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el lote {tbId.Text}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlParameter[] parametros = { new SqlParameter("@loteid", int.Parse(tbId.Text)) };
                    int resultado = db.EjecutarComando("eliminar_lote", parametros);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Lote eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarLotes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscar.Text))
                BuscarLotes(tbBuscar.Text);
            else
                CargarLotes();
        }

        private void CargarLotes()
        {
            try
            {
                DataTable dt = db.EjecutarConsulta(
                    @"SELECT loteid, bloqueid, area, valorbase, estado, ubicacion
                      FROM lote
                      ORDER BY loteid", null);

                dgvLotes.DataSource = dt;
                FormatearColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lotes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarLotes(string filtro)
        {
            try
            {
                DataTable dt = db.EjecutarConsulta(
                    @"SELECT loteid, bloqueid, area, valorbase, estado, ubicacion
                      FROM lote
                      WHERE ubicacion LIKE @filtro
                      ORDER BY loteid",
                    new[] { new SqlParameter("@filtro", $"%{filtro}%") });

                dgvLotes.DataSource = dt;
                FormatearColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearColumnas()
        {
            if (dgvLotes.Columns["loteid"] != null) dgvLotes.Columns["loteid"].HeaderText = "ID";
            if (dgvLotes.Columns["bloqueid"] != null) dgvLotes.Columns["bloqueid"].HeaderText = "Bloque";
            if (dgvLotes.Columns["area"] != null) dgvLotes.Columns["area"].HeaderText = "Área";
            if (dgvLotes.Columns["valorbase"] != null) dgvLotes.Columns["valorbase"].HeaderText = "Valor Base";
            if (dgvLotes.Columns["estado"] != null) dgvLotes.Columns["estado"].HeaderText = "Estado";
            if (dgvLotes.Columns["ubicacion"] != null) dgvLotes.Columns["ubicacion"].HeaderText = "Ubicación";
        }

        private void LimpiarCampos()
        {
            
            tbId.Text = "";
            tbArea.Text = "";
            tbValorBase.Text = "";
            cbEstado.SelectedIndex = -1;
            tbUbicacion.Text = "";

            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            tbId.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("El bloque es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbArea.Text))
            {
                MessageBox.Show("El área es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbArea.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbValorBase.Text))
            {
                MessageBox.Show("El valor base es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbValorBase.Focus();
                return false;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstado.Focus();
                return false;
            }
            return true;
        }
    }
}
