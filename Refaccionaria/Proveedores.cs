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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refaccionariaDataSet1.proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.refaccionariaDataSet1.proveedor);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            dataGridView1.CurrentRow.Cells[1].Style.BackColor = Color.Beige;
            dataGridView1.CurrentRow.Cells[2].Style.BackColor = Color.Beige;
            dataGridView1.CurrentRow.Cells[3].Style.BackColor = Color.Beige;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configuramos la instruccion
            string instruccion = "INSERT INTO proveedor(nombreProveedor,telefonoProveedor,direccionProveedor) VALUES('{0}','{1}','{2}');";
            instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, textBox3.Text);
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Proveedor Añadido Correctamente");
                this.proveedorTableAdapter.Fill(this.refaccionariaDataSet1.proveedor);
            }
            else
            {
                MessageBox.Show("Proveedor NO Añadido Correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configuramos la instruccion
            string instruccion = "UPDATE proveedor SET nombreProveedor='{0}', telefonoProveedor='{1}', direccionProveedor='{2}' WHERE idProveedor='{3}';";
            instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, textBox3.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Proveedor Editado Correctamente");
                this.proveedorTableAdapter.Fill(this.refaccionariaDataSet1.proveedor);
            }
            else
            {
                MessageBox.Show("Proveedor NO Editado Correctamente");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configuramos la instruccion
            string instruccion = "DELETE FROM proveedor WHERE idProveedor ='{0}';";
            instruccion = string.Format(instruccion, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Proveedor Eliminado Correctamente");
                this.proveedorTableAdapter.Fill(this.refaccionariaDataSet1.proveedor);
            }
            else
            {
                MessageBox.Show("Proveedor NO Eliminado Correctamente");
            }
        }
    }
}
