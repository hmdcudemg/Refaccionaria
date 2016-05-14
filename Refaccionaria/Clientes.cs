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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refaccionariaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.refaccionariaDataSet.cliente);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

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
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria", "root", "root");
            //configuramos la instruccion
            string instruccion = "INSERT INTO cliente(nombreCliente,apellidoCliente,telefonoCliente,direccionCliente) VALUES('{0}','{1}','{2}','{3}');";
            instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Cliente Añadido Correctamente");
                this.clienteTableAdapter.Fill(this.refaccionariaDataSet.cliente);
            }
            else
            {
                MessageBox.Show("Cliente NO Añadido Correctamente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria", "root", "root");
            //configuramos la instruccion
            string instruccion = "DELETE FROM cliente WHERE idcliente ='{0}';";
            instruccion = string.Format(instruccion, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
                this.clienteTableAdapter.Fill(this.refaccionariaDataSet.cliente);
            }
            else
            {
                MessageBox.Show("Cliente NO Eliminado Correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria", "root", "root");
            //configuramos la instruccion
            string instruccion = "UPDATE cliente SET nombreCliente='{0}', apellidoCliente='{1}', telefonoCliente='{2}', direccionCliente='{3}' WHERE idCliente='{4}';";
            instruccion = string.Format(instruccion, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Cliente Editado Correctamente");
                this.clienteTableAdapter.Fill(this.refaccionariaDataSet.cliente);
            }
            else
            {
                MessageBox.Show("Cliente NO Editado Correctamente");
            }
        }
    }
}
