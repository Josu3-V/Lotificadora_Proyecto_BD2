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
    public partial class Lotificadora_Lopez : Form
    {
        public Lotificadora_Lopez()
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
            Lotes lotesForm = new Lotes();
            lotesForm.Show();
            this.Close();
        }


        private void btnPagos_Click(object sender, EventArgs e)
        {
            ReporteMora ReporteMoraForm = new ReporteMora();
            ReporteMoraForm.Show();
            this.Close();
        }

        private void btnVentas(object sender, EventArgs e)
        {
            GastosDeProyecto GDProyectoForm = new GastosDeProyecto();
            GDProyectoForm.Show();
            this.Close();
        }
    }
}
