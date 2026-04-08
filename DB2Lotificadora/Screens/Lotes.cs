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
    public partial class Lotes : Form
    {
        public Lotes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Lotificadora_Lopez lotlopezForm = new Lotificadora_Lopez();
            lotlopezForm.Show();
            this.Close();
        }
    }
}
