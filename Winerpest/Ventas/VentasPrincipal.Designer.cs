namespace Winerpest.Ventas
{
    partial class VentasPrincipal
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.cbxClave = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtClaveVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cveventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENTASBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSetVentas = new Winerpest.WinnerPetDataSetVentas();
            this.vENTASBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet12 = new Winerpest.WinnerPetDataSet12();
            this.vENTASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetVentas = new Winerpest.WinnerPetVentas();
            this.vENTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet5 = new Winerpest.WinnerPetDataSet5();
            this.vENTASTableAdapter = new Winerpest.WinnerPetDataSet5TableAdapters.VENTASTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vENTASTableAdapter1 = new Winerpest.WinnerPetVentasTableAdapters.VENTASTableAdapter();
            this.vENTASTableAdapter2 = new Winerpest.WinnerPetDataSet12TableAdapters.VENTASTableAdapter();
            this.vENTASTableAdapter3 = new Winerpest.WinnerPetDataSetVentasTableAdapters.VENTASTableAdapter();
            this.winnerPetDataSetVentasSQLTAP = new Winerpest.WinnerPetDataSetVentasSQLTAP();
            this.vENTASBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASTableAdapter4 = new Winerpest.WinnerPetDataSetVentasSQLTAPTableAdapters.VENTASTableAdapter();
            this.gbxOpciones.SuspendLayout();
            this.gbxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetVentasSQLTAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(670, -10);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 44);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbModificar);
            this.gbxOpciones.Controls.Add(this.rbEliminar);
            this.gbxOpciones.Controls.Add(this.rbRegistro);
            this.gbxOpciones.Location = new System.Drawing.Point(12, 55);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Size = new System.Drawing.Size(706, 100);
            this.gbxOpciones.TabIndex = 18;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones de la base de datos";
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(467, 47);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 3;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(219, 47);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 2;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // rbRegistro
            // 
            this.rbRegistro.AutoSize = true;
            this.rbRegistro.Location = new System.Drawing.Point(21, 47);
            this.rbRegistro.Name = "rbRegistro";
            this.rbRegistro.Size = new System.Drawing.Size(67, 17);
            this.rbRegistro.TabIndex = 1;
            this.rbRegistro.TabStop = true;
            this.rbRegistro.Text = "Registrar";
            this.rbRegistro.UseVisualStyleBackColor = true;
            this.rbRegistro.CheckedChanged += new System.EventHandler(this.rbRegistro_CheckedChanged);
            // 
            // gbxCampos
            // 
            this.gbxCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.gbxCampos.Controls.Add(this.cbxClave);
            this.gbxCampos.Controls.Add(this.nudCantidad);
            this.gbxCampos.Controls.Add(this.label3);
            this.gbxCampos.Controls.Add(this.btnModificar);
            this.gbxCampos.Controls.Add(this.btnEliminar);
            this.gbxCampos.Controls.Add(this.txtClaveVenta);
            this.gbxCampos.Controls.Add(this.label1);
            this.gbxCampos.Controls.Add(this.btnAgregar);
            this.gbxCampos.Controls.Add(this.label2);
            this.gbxCampos.Controls.Add(this.txtImporte);
            this.gbxCampos.Controls.Add(this.lblName);
            this.gbxCampos.Location = new System.Drawing.Point(12, 163);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Size = new System.Drawing.Size(706, 222);
            this.gbxCampos.TabIndex = 19;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "GPS";
            // 
            // cbxClave
            // 
            this.cbxClave.FormattingEnabled = true;
            this.cbxClave.Location = new System.Drawing.Point(173, 120);
            this.cbxClave.Name = "cbxClave";
            this.cbxClave.Size = new System.Drawing.Size(163, 21);
            this.cbxClave.TabIndex = 16;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(173, 93);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(54, 20);
            this.nudCantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Clave del producto";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(582, 161);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 41);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(582, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 41);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtClaveVenta
            // 
            this.txtClaveVenta.Location = new System.Drawing.Point(173, 42);
            this.txtClaveVenta.Name = "txtClaveVenta";
            this.txtClaveVenta.Size = new System.Drawing.Size(163, 20);
            this.txtClaveVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clave de venta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(582, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 41);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(173, 67);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(163, 20);
            this.txtImporte.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveventaDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.cveproductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vENTASBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(672, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // cveventaDataGridViewTextBoxColumn
            // 
            this.cveventaDataGridViewTextBoxColumn.DataPropertyName = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.HeaderText = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cveventaDataGridViewTextBoxColumn.Name = "cveventaDataGridViewTextBoxColumn";
            this.cveventaDataGridViewTextBoxColumn.Width = 150;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // cveproductoDataGridViewTextBoxColumn
            // 
            this.cveproductoDataGridViewTextBoxColumn.DataPropertyName = "cve_producto";
            this.cveproductoDataGridViewTextBoxColumn.HeaderText = "cve_producto";
            this.cveproductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cveproductoDataGridViewTextBoxColumn.Name = "cveproductoDataGridViewTextBoxColumn";
            this.cveproductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // vENTASBindingSource4
            // 
            this.vENTASBindingSource4.DataMember = "VENTAS";
            this.vENTASBindingSource4.DataSource = this.winnerPetDataSetVentas;
            // 
            // winnerPetDataSetVentas
            // 
            this.winnerPetDataSetVentas.DataSetName = "WinnerPetDataSetVentas";
            this.winnerPetDataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASBindingSource3
            // 
            this.vENTASBindingSource3.DataMember = "VENTAS";
            this.vENTASBindingSource3.DataSource = this.winnerPetDataSet12;
            // 
            // winnerPetDataSet12
            // 
            this.winnerPetDataSet12.DataSetName = "WinnerPetDataSet12";
            this.winnerPetDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASBindingSource2
            // 
            this.vENTASBindingSource2.DataMember = "VENTAS";
            this.vENTASBindingSource2.DataSource = this.winnerPetVentas;
            // 
            // winnerPetVentas
            // 
            this.winnerPetVentas.DataSetName = "WinnerPetVentas";
            this.winnerPetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASBindingSource1
            // 
            this.vENTASBindingSource1.DataMember = "VENTAS";
            this.vENTASBindingSource1.DataSource = this.winnerPetVentas;
            // 
            // vENTASBindingSource
            // 
            this.vENTASBindingSource.DataMember = "VENTAS";
            this.vENTASBindingSource.DataSource = this.winnerPetDataSet5;
            // 
            // winnerPetDataSet5
            // 
            this.winnerPetDataSet5.DataSetName = "WinnerPetDataSet5";
            this.winnerPetDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASTableAdapter
            // 
            this.vENTASTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 37);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 35);
            this.panel2.TabIndex = 22;
            // 
            // vENTASTableAdapter1
            // 
            this.vENTASTableAdapter1.ClearBeforeFill = true;
            // 
            // vENTASTableAdapter2
            // 
            this.vENTASTableAdapter2.ClearBeforeFill = true;
            // 
            // vENTASTableAdapter3
            // 
            this.vENTASTableAdapter3.ClearBeforeFill = true;
            // 
            // winnerPetDataSetVentasSQLTAP
            // 
            this.winnerPetDataSetVentasSQLTAP.DataSetName = "WinnerPetDataSetVentasSQLTAP";
            this.winnerPetDataSetVentasSQLTAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASBindingSource5
            // 
            this.vENTASBindingSource5.DataMember = "VENTAS";
            this.vENTASBindingSource5.DataSource = this.winnerPetDataSetVentasSQLTAP;
            // 
            // vENTASTableAdapter4
            // 
            this.vENTASTableAdapter4.ClearBeforeFill = true;
            // 
            // VentasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxCampos);
            this.Name = "VentasPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasPrincipal";
            this.Load += new System.EventHandler(this.VentasPrincipal_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetVentasSQLTAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtClaveVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet5 winnerPetDataSet5;
        private System.Windows.Forms.BindingSource vENTASBindingSource;
        private WinnerPetDataSet5TableAdapters.VENTASTableAdapter vENTASTableAdapter;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxClave;
        private WinnerPetVentas winnerPetVentas;
        private System.Windows.Forms.BindingSource vENTASBindingSource1;
        private WinnerPetVentasTableAdapters.VENTASTableAdapter vENTASTableAdapter1;
        private System.Windows.Forms.BindingSource vENTASBindingSource2;
        private WinnerPetDataSet12 winnerPetDataSet12;
        private System.Windows.Forms.BindingSource vENTASBindingSource3;
        private WinnerPetDataSet12TableAdapters.VENTASTableAdapter vENTASTableAdapter2;
        private WinnerPetDataSetVentas winnerPetDataSetVentas;
        private System.Windows.Forms.BindingSource vENTASBindingSource4;
        private WinnerPetDataSetVentasTableAdapters.VENTASTableAdapter vENTASTableAdapter3;
        private WinnerPetDataSetVentasSQLTAP winnerPetDataSetVentasSQLTAP;
        private System.Windows.Forms.BindingSource vENTASBindingSource5;
        private WinnerPetDataSetVentasSQLTAPTableAdapters.VENTASTableAdapter vENTASTableAdapter4;
    }
}