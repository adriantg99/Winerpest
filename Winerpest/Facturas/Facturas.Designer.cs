namespace Winerpest.Facturas
{
    partial class Facturas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cvefacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURABindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSetFacturaSQLTAP = new Winerpest.WinnerPetDataSetFacturaSQLTAP();
            this.fACTURABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSetFactura = new Winerpest.WinnerPetDataSetFactura();
            this.fACTURABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet13 = new Winerpest.WinnerPetDataSet13();
            this.fACTURABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetFacturas = new Winerpest.WinnerPetFacturas();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet6 = new Winerpest.WinnerPetDataSet6();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.cmbxClaveCLiente = new System.Windows.Forms.ComboBox();
            this.cmbxCveVenta = new System.Windows.Forms.ComboBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCveFact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.fACTURATableAdapter = new Winerpest.WinnerPetDataSet6TableAdapters.FACTURATableAdapter();
            this.fACTURATableAdapter1 = new Winerpest.WinnerPetFacturasTableAdapters.FACTURATableAdapter();
            this.fACTURATableAdapter2 = new Winerpest.WinnerPetDataSet13TableAdapters.FACTURATableAdapter();
            this.fACTURATableAdapter3 = new Winerpest.WinnerPetDataSetFacturaTableAdapters.FACTURATableAdapter();
            this.fACTURATableAdapter4 = new Winerpest.WinnerPetDataSetFacturaSQLTAPTableAdapters.FACTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetFacturaSQLTAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet6)).BeginInit();
            this.gbxOpciones.SuspendLayout();
            this.gbxCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvefacturaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.cveventaDataGridViewTextBoxColumn,
            this.cveclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fACTURABindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // cvefacturaDataGridViewTextBoxColumn
            // 
            this.cvefacturaDataGridViewTextBoxColumn.DataPropertyName = "cve_factura";
            this.cvefacturaDataGridViewTextBoxColumn.HeaderText = "cve_factura";
            this.cvefacturaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cvefacturaDataGridViewTextBoxColumn.Name = "cvefacturaDataGridViewTextBoxColumn";
            this.cvefacturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            this.ivaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // cveventaDataGridViewTextBoxColumn
            // 
            this.cveventaDataGridViewTextBoxColumn.DataPropertyName = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.HeaderText = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cveventaDataGridViewTextBoxColumn.Name = "cveventaDataGridViewTextBoxColumn";
            this.cveventaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cveclienteDataGridViewTextBoxColumn
            // 
            this.cveclienteDataGridViewTextBoxColumn.DataPropertyName = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.HeaderText = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cveclienteDataGridViewTextBoxColumn.Name = "cveclienteDataGridViewTextBoxColumn";
            this.cveclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // fACTURABindingSource4
            // 
            this.fACTURABindingSource4.DataMember = "FACTURA";
            this.fACTURABindingSource4.DataSource = this.winnerPetDataSetFacturaSQLTAP;
            // 
            // winnerPetDataSetFacturaSQLTAP
            // 
            this.winnerPetDataSetFacturaSQLTAP.DataSetName = "WinnerPetDataSetFacturaSQLTAP";
            this.winnerPetDataSetFacturaSQLTAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource3
            // 
            this.fACTURABindingSource3.DataMember = "FACTURA";
            this.fACTURABindingSource3.DataSource = this.winnerPetDataSetFactura;
            // 
            // winnerPetDataSetFactura
            // 
            this.winnerPetDataSetFactura.DataSetName = "WinnerPetDataSetFactura";
            this.winnerPetDataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource2
            // 
            this.fACTURABindingSource2.DataMember = "FACTURA";
            this.fACTURABindingSource2.DataSource = this.winnerPetDataSet13;
            // 
            // winnerPetDataSet13
            // 
            this.winnerPetDataSet13.DataSetName = "WinnerPetDataSet13";
            this.winnerPetDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource1
            // 
            this.fACTURABindingSource1.DataMember = "FACTURA";
            this.fACTURABindingSource1.DataSource = this.winnerPetFacturas;
            // 
            // winnerPetFacturas
            // 
            this.winnerPetFacturas.DataSetName = "WinnerPetFacturas";
            this.winnerPetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.winnerPetDataSet6;
            // 
            // winnerPetDataSet6
            // 
            this.winnerPetDataSet6.DataSetName = "WinnerPetDataSet6";
            this.winnerPetDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(604, 557);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 44);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbModificar);
            this.gbxOpciones.Controls.Add(this.rbEliminar);
            this.gbxOpciones.Controls.Add(this.rbRegistro);
            this.gbxOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Size = new System.Drawing.Size(706, 100);
            this.gbxOpciones.TabIndex = 22;
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
            this.gbxCampos.Controls.Add(this.cmbxClaveCLiente);
            this.gbxCampos.Controls.Add(this.cmbxCveVenta);
            this.gbxCampos.Controls.Add(this.txtIva);
            this.gbxCampos.Controls.Add(this.label5);
            this.gbxCampos.Controls.Add(this.label4);
            this.gbxCampos.Controls.Add(this.txtTotal);
            this.gbxCampos.Controls.Add(this.label3);
            this.gbxCampos.Controls.Add(this.btnModificar);
            this.gbxCampos.Controls.Add(this.btnEliminar);
            this.gbxCampos.Controls.Add(this.txtCveFact);
            this.gbxCampos.Controls.Add(this.label1);
            this.gbxCampos.Controls.Add(this.btnAgregar);
            this.gbxCampos.Controls.Add(this.label2);
            this.gbxCampos.Controls.Add(this.txtSubtotal);
            this.gbxCampos.Controls.Add(this.lblName);
            this.gbxCampos.Location = new System.Drawing.Point(12, 126);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Size = new System.Drawing.Size(706, 319);
            this.gbxCampos.TabIndex = 23;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "Facturas";
            // 
            // cmbxClaveCLiente
            // 
            this.cmbxClaveCLiente.FormattingEnabled = true;
            this.cmbxClaveCLiente.Location = new System.Drawing.Point(173, 175);
            this.cmbxClaveCLiente.Name = "cmbxClaveCLiente";
            this.cmbxClaveCLiente.Size = new System.Drawing.Size(163, 21);
            this.cmbxClaveCLiente.TabIndex = 21;
            // 
            // cmbxCveVenta
            // 
            this.cmbxCveVenta.FormattingEnabled = true;
            this.cmbxCveVenta.Location = new System.Drawing.Point(173, 148);
            this.cmbxCveVenta.Name = "cmbxCveVenta";
            this.cmbxCveVenta.Size = new System.Drawing.Size(163, 21);
            this.cmbxCveVenta.TabIndex = 20;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(173, 93);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(163, 20);
            this.txtIva.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Clave Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Clave Venta";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(173, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(163, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(587, 243);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 41);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(587, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCveFact
            // 
            this.txtCveFact.Location = new System.Drawing.Point(173, 42);
            this.txtCveFact.Name = "txtCveFact";
            this.txtCveFact.Size = new System.Drawing.Size(163, 20);
            this.txtCveFact.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clave Factura";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(587, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(173, 67);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(163, 20);
            this.txtSubtotal.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "IVA";
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // fACTURATableAdapter1
            // 
            this.fACTURATableAdapter1.ClearBeforeFill = true;
            // 
            // fACTURATableAdapter2
            // 
            this.fACTURATableAdapter2.ClearBeforeFill = true;
            // 
            // fACTURATableAdapter3
            // 
            this.fACTURATableAdapter3.ClearBeforeFill = true;
            // 
            // fACTURATableAdapter4
            // 
            this.fACTURATableAdapter4.ClearBeforeFill = true;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxCampos);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetFacturaSQLTAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet6)).EndInit();
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCveFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private WinnerPetDataSet6 winnerPetDataSet6;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private WinnerPetDataSet6TableAdapters.FACTURATableAdapter fACTURATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvefacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbxClaveCLiente;
        private System.Windows.Forms.ComboBox cmbxCveVenta;
        private WinnerPetFacturas winnerPetFacturas;
        private System.Windows.Forms.BindingSource fACTURABindingSource1;
        private WinnerPetFacturasTableAdapters.FACTURATableAdapter fACTURATableAdapter1;
        private WinnerPetDataSet13 winnerPetDataSet13;
        private System.Windows.Forms.BindingSource fACTURABindingSource2;
        private WinnerPetDataSet13TableAdapters.FACTURATableAdapter fACTURATableAdapter2;
        private WinnerPetDataSetFactura winnerPetDataSetFactura;
        private System.Windows.Forms.BindingSource fACTURABindingSource3;
        private WinnerPetDataSetFacturaTableAdapters.FACTURATableAdapter fACTURATableAdapter3;
        private WinnerPetDataSetFacturaSQLTAP winnerPetDataSetFacturaSQLTAP;
        private System.Windows.Forms.BindingSource fACTURABindingSource4;
        private WinnerPetDataSetFacturaSQLTAPTableAdapters.FACTURATableAdapter fACTURATableAdapter4;
    }
}