namespace Refaccionaria
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refaccionariaDataSet3 = new Refaccionaria.refaccionariaDataSet3();
            this.ventasTableAdapter = new Refaccionaria.refaccionariaDataSet3TableAdapters.ventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refaccionariaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioVentaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.totalVentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ventasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // folioVentaDataGridViewTextBoxColumn
            // 
            this.folioVentaDataGridViewTextBoxColumn.DataPropertyName = "folioVenta";
            this.folioVentaDataGridViewTextBoxColumn.HeaderText = "Folio de Venta";
            this.folioVentaDataGridViewTextBoxColumn.Name = "folioVentaDataGridViewTextBoxColumn";
            this.folioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "fechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha de Venta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalVentaDataGridViewTextBoxColumn
            // 
            this.totalVentaDataGridViewTextBoxColumn.DataPropertyName = "totalVenta";
            this.totalVentaDataGridViewTextBoxColumn.HeaderText = "Total de Venta";
            this.totalVentaDataGridViewTextBoxColumn.Name = "totalVentaDataGridViewTextBoxColumn";
            this.totalVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.refaccionariaDataSet3;
            // 
            // refaccionariaDataSet3
            // 
            this.refaccionariaDataSet3.DataSetName = "refaccionariaDataSet3";
            this.refaccionariaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 275);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.Text = "Historial - Refaccionaria";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refaccionariaDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private refaccionariaDataSet3 refaccionariaDataSet3;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private refaccionariaDataSet3TableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn;
    }
}