using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refaccionariaDataSet3.ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.refaccionariaDataSet3.ventas);

        }
    }
}
