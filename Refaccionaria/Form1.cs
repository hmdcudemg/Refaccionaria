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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.MdiParent = this;
            v.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.MdiParent = this;
            p.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.MdiParent = this;
            c.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Proveedores pr = new Proveedores();
            pr.MdiParent = this;
            pr.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Historial h = new Historial();
            h.MdiParent = this;
            h.Show();
        }
    }
}
