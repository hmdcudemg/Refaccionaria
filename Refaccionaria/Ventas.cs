using MySql.Data.MySqlClient;
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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            textBox2.Text = thisDay.ToString("d");
            textBox5.Text = Convert.ToString(maxIdVenta());

            // TODO: This line of code loads data into the 'refaccionariaDataSet2.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.refaccionariaDataSet2.producto);

        }

        private int maxIdVenta()
        {
            int maxIdVenta = 0;
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configurar la consulta
            string consulta = "SELECT MAX(folioVenta) AS folioVenta FROM ventas;";
            MySqlDataReader t = mbd.conexionQuery(consulta);
            //verificar si se encontraron resultados
            if (t.Read())
            {
                maxIdVenta = t.GetInt32(0) + 1;
            }
            else
            {
            }

            return maxIdVenta;
        }

        private MySqlDataReader selectProducto(int id)
        {
            MySqlDataReader reader;
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configurar la consulta
            string consulta = "SELECT * FROM producto WHERE idproducto=" + id + ";";
            reader = mbd.conexionQuery(consulta);
            //verificar si se encontraron resultados
            if (reader.Read())
            {
            }
            else
            {
            }

            return reader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = selectProducto(Convert.ToInt32(comboBox1.SelectedValue));

            dataGridView1.Rows.Insert(0, reader.GetInt32(0).ToString(), reader.GetString(1), numericUpDown1.Value, reader.GetDouble(4).ToString());

            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) + (Convert.ToInt32(numericUpDown1.Value) * reader.GetDouble(4)));

            textBox4.Text = textBox3.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double subtotal = 0.0;
            double descuento = 0.0;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    subtotal = Convert.ToDouble(textBox3.Text);
                    descuento = subtotal * .10;
                    textBox4.Text = Convert.ToString(subtotal - descuento);
                    break;
                case 1:
                    subtotal = Convert.ToDouble(textBox3.Text);
                    descuento = subtotal * .15;
                    textBox4.Text = Convert.ToString(subtotal - descuento);
                    break;
                case 2:
                    subtotal = Convert.ToDouble(textBox3.Text);
                    descuento = subtotal * .20;
                    textBox4.Text = Convert.ToString(subtotal - descuento);
                    break;
                case 3:
                    subtotal = Convert.ToDouble(textBox3.Text);
                    descuento = subtotal * .25;
                    textBox4.Text = Convert.ToString(subtotal - descuento);
                    break;
                case 4:
                    subtotal = Convert.ToDouble(textBox3.Text);
                    descuento = subtotal * .30;
                    textBox4.Text = Convert.ToString(subtotal - descuento);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardarVenta();
            guardarDetalleVenta();
            limpiarVenta();
        }

        private void limpiarVenta()
        {
            DateTime thisDay = DateTime.Today;
            textBox2.Text = thisDay.ToString("d");
            textBox5.Text = Convert.ToString(maxIdVenta());

            textBox1.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";

            dataGridView1.Rows.Clear();
        }

        private void guardarVenta()
        {
            // probar conexion
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            //configuramos la instruccion
            string instruccion = "INSERT INTO ventas(nombreCliente,fechaVenta,totalVenta) VALUES('{0}','{1}',{2});";
            instruccion = string.Format(instruccion, textBox1.Text, DateTime.Now, Convert.ToDouble(textBox4.Text));
            //ejecutamos la instruccion
            int res = mbd.ejecutar(instruccion);
            // validar si se realizo la operacion
            if (res > 0)
            {
                MessageBox.Show("Venta Añadida Correctamente");
            }
            else
            {
                MessageBox.Show("Venta NO Añadida Correctamente");
            }
        }

        private void guardarDetalleVenta()
        {
            manejadorBD mbd = new manejadorBD("localhost", "refaccionaria");
            using (MySqlConnection conn = new MySqlConnection(mbd.cadCon()))
            {
                conn.Open();

                string query = "INSERT INTO refaccionaria.venta_detalle (folioVenta, idProducto, cantidad, precioVenta) VALUES (?param1, ?param2, ?param3, ?param4)";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index < row.DataGridView.RowCount - 1)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("?param1", textBox5.Text);
                        cmd.Parameters.AddWithValue("?param2", Convert.ToInt32(row.Cells[0].Value));
                        cmd.Parameters.AddWithValue("?param3", Convert.ToInt32(row.Cells[2].Value));
                        cmd.Parameters.AddWithValue("?param4", Convert.ToInt32(row.Cells[3].Value));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
