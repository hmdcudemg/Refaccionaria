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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refaccionariaDataSet2.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.refaccionariaDataSet2.producto);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            dataGridView1.CurrentRow.Cells[1].Style.BackColor = Color.Beige;
            dataGridView1.CurrentRow.Cells[2].Style.BackColor = Color.Beige;
            dataGridView1.CurrentRow.Cells[3].Style.BackColor = Color.Beige;
            dataGridView1.CurrentRow.Cells[4].Style.BackColor = Color.Beige;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.White;
            dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // probar conexion
                manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
                //configuramos la instruccion
                string instruccion = "INSERT INTO producto(nombreProducto,descripcionProducto,cantidadProducto,precioProducto) VALUES('{0}','{1}',{2},{3});";
                instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, numericUpDown1.Value, Convert.ToDouble(textBox3.Text));
                //ejecutamos la instruccion
                int res = mbd.ejecutar(instruccion);
                // validar si se realizo la operacion
                if (res > 0)
                {
                    MessageBox.Show("Producto Añadido Correctamente");
                    this.productoTableAdapter.Fill(this.refaccionariaDataSet2.producto);
                }
                else
                {
                    MessageBox.Show("Producto NO Añadido Correctamente");
                }
            }catch(Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // probar conexion
                manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
                //configuramos la instruccion
                string instruccion = "UPDATE producto SET nombreProducto='{0}', descripcionProducto='{1}', cantidadProducto={2}, precioProducto={3} WHERE idProducto={4};";
                instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, numericUpDown1.Value, Convert.ToDouble(textBox3.Text), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //ejecutamos la instruccion
                int res = mbd.ejecutar(instruccion);
                // validar si se realizo la operacion
                if (res > 0)
                {
                    MessageBox.Show("Producto Editado Correctamente");
                    this.productoTableAdapter.Fill(this.refaccionariaDataSet2.producto);
                }
                else
                {
                    MessageBox.Show("Producto NO Editado Correctamente");
                }
            }catch(Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // probar conexion
                manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
                //configuramos la instruccion
                string instruccion = "DELETE FROM producto WHERE idProducto ={0};";
                instruccion = string.Format(instruccion, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //ejecutamos la instruccion
                int res = mbd.ejecutar(instruccion);
                // validar si se realizo la operacion
                if (res > 0)
                {
                    MessageBox.Show("Producto Eliminado Correctamente");
                    this.productoTableAdapter.Fill(this.refaccionariaDataSet2.producto);
                }
                else
                {
                    MessageBox.Show("Producto NO Eliminado Correctamente");
                }
            }catch(Exception ex) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown1.Value = Convert.ToDecimal(0);
        }
    }
}
