namespace Refaccionaria
{
    partial class Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refaccionariaDataSet1 = new Refaccionaria.refaccionariaDataSet1();
            this.proveedorTableAdapter = new Refaccionaria.refaccionariaDataSet1TableAdapters.proveedorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refaccionariaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.telefonoProveedorDataGridViewTextBoxColumn,
            this.direccionProveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(472, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "Id Proveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoProveedorDataGridViewTextBoxColumn
            // 
            this.telefonoProveedorDataGridViewTextBoxColumn.DataPropertyName = "telefonoProveedor";
            this.telefonoProveedorDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoProveedorDataGridViewTextBoxColumn.Name = "telefonoProveedorDataGridViewTextBoxColumn";
            this.telefonoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionProveedorDataGridViewTextBoxColumn
            // 
            this.direccionProveedorDataGridViewTextBoxColumn.DataPropertyName = "direccionProveedor";
            this.direccionProveedorDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionProveedorDataGridViewTextBoxColumn.Name = "direccionProveedorDataGridViewTextBoxColumn";
            this.direccionProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.refaccionariaDataSet1;
            // 
            // refaccionariaDataSet1
            // 
            this.refaccionariaDataSet1.DataSetName = "refaccionariaDataSet1";
            this.refaccionariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Image = global::Refaccionaria.Properties.Resources.Limpiar;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.Location = new System.Drawing.Point(354, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpiar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Refaccionaria.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(354, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Refaccionaria.Properties.Resources.Editar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(270, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Refaccionaria.Properties.Resources.Guardar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(270, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Añadir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 285);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.Text = "Proveedores - Refaccionaria";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refaccionariaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private refaccionariaDataSet1 refaccionariaDataSet1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private refaccionariaDataSet1TableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}