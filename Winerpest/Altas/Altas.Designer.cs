namespace Winerpest.Altas
{
    partial class Altas
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
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.gbxCampos = new System.Windows.Forms.GroupBox();
            this.cbImei = new System.Windows.Forms.ComboBox();
            this.cbxClaveVenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.idAlta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLTASBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet21 = new Winerpest.WinnerPetDataSet21();
            this.aLTASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet18 = new Winerpest.WinnerPetDataSet18();
            this.aLTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetAlta = new Winerpest.WinnerPetAlta();
            this.aLTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet7 = new Winerpest.WinnerPetDataSet7();
            this.aLTASTableAdapter = new Winerpest.WinnerPetDataSet7TableAdapters.ALTASTableAdapter();
            this.aLTASTableAdapter1 = new Winerpest.WinnerPetAltaTableAdapters.ALTASTableAdapter();
            this.aLTASTableAdapter2 = new Winerpest.WinnerPetDataSet18TableAdapters.ALTASTableAdapter();
            this.aLTASTableAdapter3 = new Winerpest.WinnerPetDataSet21TableAdapters.ALTASTableAdapter();
            this.winnerPetDataSetALTASTAP = new Winerpest.WinnerPetDataSetALTASTAP();
            this.aLTASBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.aLTASTableAdapter4 = new Winerpest.WinnerPetDataSetALTASTAPTableAdapters.ALTASTableAdapter();
            this.gbxOpciones.SuspendLayout();
            this.gbxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetALTASTAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbEliminar);
            this.gbxOpciones.Controls.Add(this.rbRegistro);
            this.gbxOpciones.Location = new System.Drawing.Point(12, 11);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxOpciones.Size = new System.Drawing.Size(706, 100);
            this.gbxOpciones.TabIndex = 24;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones de la base de datos";
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(486, 47);
            this.rbEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.rbRegistro.Location = new System.Drawing.Point(22, 47);
            this.rbRegistro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.gbxCampos.Controls.Add(this.cbImei);
            this.gbxCampos.Controls.Add(this.cbxClaveVenta);
            this.gbxCampos.Controls.Add(this.label3);
            this.gbxCampos.Controls.Add(this.btnEliminar);
            this.gbxCampos.Controls.Add(this.idAlta);
            this.gbxCampos.Controls.Add(this.label1);
            this.gbxCampos.Controls.Add(this.btnAgregar);
            this.gbxCampos.Controls.Add(this.label2);
            this.gbxCampos.Location = new System.Drawing.Point(13, 126);
            this.gbxCampos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCampos.Name = "gbxCampos";
            this.gbxCampos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCampos.Size = new System.Drawing.Size(706, 319);
            this.gbxCampos.TabIndex = 25;
            this.gbxCampos.TabStop = false;
            this.gbxCampos.Text = "Altas";
            this.gbxCampos.Enter += new System.EventHandler(this.gbxCampos_Enter);
            // 
            // cbImei
            // 
            this.cbImei.FormattingEnabled = true;
            this.cbImei.Location = new System.Drawing.Point(174, 96);
            this.cbImei.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbImei.Name = "cbImei";
            this.cbImei.Size = new System.Drawing.Size(162, 21);
            this.cbImei.TabIndex = 18;
            // 
            // cbxClaveVenta
            // 
            this.cbxClaveVenta.FormattingEnabled = true;
            this.cbxClaveVenta.Location = new System.Drawing.Point(174, 67);
            this.cbxClaveVenta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxClaveVenta.Name = "cbxClaveVenta";
            this.cbxClaveVenta.Size = new System.Drawing.Size(162, 21);
            this.cbxClaveVenta.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "IMEI";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 197);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // idAlta
            // 
            this.idAlta.Location = new System.Drawing.Point(174, 42);
            this.idAlta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idAlta.Name = "idAlta";
            this.idAlta.Size = new System.Drawing.Size(162, 20);
            this.idAlta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id_Alta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(586, 149);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clave Venta";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(550, 635);
            this.Volver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(162, 37);
            this.Volver.TabIndex = 26;
            this.Volver.Text = "Cerrar";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaltaDataGridViewTextBoxColumn,
            this.cveventaDataGridViewTextBoxColumn,
            this.imeiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLTASBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 451);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // idaltaDataGridViewTextBoxColumn
            // 
            this.idaltaDataGridViewTextBoxColumn.DataPropertyName = "id_alta";
            this.idaltaDataGridViewTextBoxColumn.HeaderText = "id_alta";
            this.idaltaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idaltaDataGridViewTextBoxColumn.Name = "idaltaDataGridViewTextBoxColumn";
            this.idaltaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cveventaDataGridViewTextBoxColumn
            // 
            this.cveventaDataGridViewTextBoxColumn.DataPropertyName = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.HeaderText = "cve_venta";
            this.cveventaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cveventaDataGridViewTextBoxColumn.Name = "cveventaDataGridViewTextBoxColumn";
            this.cveventaDataGridViewTextBoxColumn.Width = 200;
            // 
            // imeiDataGridViewTextBoxColumn
            // 
            this.imeiDataGridViewTextBoxColumn.DataPropertyName = "imei";
            this.imeiDataGridViewTextBoxColumn.HeaderText = "imei";
            this.imeiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imeiDataGridViewTextBoxColumn.Name = "imeiDataGridViewTextBoxColumn";
            this.imeiDataGridViewTextBoxColumn.Width = 300;
            // 
            // aLTASBindingSource3
            // 
            this.aLTASBindingSource3.DataMember = "ALTAS";
            this.aLTASBindingSource3.DataSource = this.winnerPetDataSet21;
            // 
            // winnerPetDataSet21
            // 
            this.winnerPetDataSet21.DataSetName = "WinnerPetDataSet21";
            this.winnerPetDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTASBindingSource2
            // 
            this.aLTASBindingSource2.DataMember = "ALTAS";
            this.aLTASBindingSource2.DataSource = this.winnerPetDataSet18;
            // 
            // winnerPetDataSet18
            // 
            this.winnerPetDataSet18.DataSetName = "WinnerPetDataSet18";
            this.winnerPetDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTASBindingSource1
            // 
            this.aLTASBindingSource1.DataMember = "ALTAS";
            this.aLTASBindingSource1.DataSource = this.winnerPetAlta;
            // 
            // winnerPetAlta
            // 
            this.winnerPetAlta.DataSetName = "WinnerPetAlta";
            this.winnerPetAlta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTASBindingSource
            // 
            this.aLTASBindingSource.DataMember = "ALTAS";
            this.aLTASBindingSource.DataSource = this.winnerPetDataSet7;
            // 
            // winnerPetDataSet7
            // 
            this.winnerPetDataSet7.DataSetName = "WinnerPetDataSet7";
            this.winnerPetDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTASTableAdapter
            // 
            this.aLTASTableAdapter.ClearBeforeFill = true;
            // 
            // aLTASTableAdapter1
            // 
            this.aLTASTableAdapter1.ClearBeforeFill = true;
            // 
            // aLTASTableAdapter2
            // 
            this.aLTASTableAdapter2.ClearBeforeFill = true;
            // 
            // aLTASTableAdapter3
            // 
            this.aLTASTableAdapter3.ClearBeforeFill = true;
            // 
            // winnerPetDataSetALTASTAP
            // 
            this.winnerPetDataSetALTASTAP.DataSetName = "WinnerPetDataSetALTASTAP";
            this.winnerPetDataSetALTASTAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTASBindingSource4
            // 
            this.aLTASBindingSource4.DataMember = "ALTAS";
            this.aLTASBindingSource4.DataSource = this.winnerPetDataSetALTASTAP;
            // 
            // aLTASTableAdapter4
            // 
            this.aLTASTableAdapter4.ClearBeforeFill = true;
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxCampos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Altas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.Altas_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            this.gbxCampos.ResumeLayout(false);
            this.gbxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetALTASTAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTASBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.GroupBox gbxCampos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox idAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxClaveVenta;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.ComboBox cbImei;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet7 winnerPetDataSet7;
        private System.Windows.Forms.BindingSource aLTASBindingSource;
        private WinnerPetDataSet7TableAdapters.ALTASTableAdapter aLTASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private WinnerPetAlta winnerPetAlta;
        private System.Windows.Forms.BindingSource aLTASBindingSource1;
        private WinnerPetAltaTableAdapters.ALTASTableAdapter aLTASTableAdapter1;
        private WinnerPetDataSet18 winnerPetDataSet18;
        private System.Windows.Forms.BindingSource aLTASBindingSource2;
        private WinnerPetDataSet18TableAdapters.ALTASTableAdapter aLTASTableAdapter2;
        private WinnerPetDataSet21 winnerPetDataSet21;
        private System.Windows.Forms.BindingSource aLTASBindingSource3;
        private WinnerPetDataSet21TableAdapters.ALTASTableAdapter aLTASTableAdapter3;
        private WinnerPetDataSetALTASTAP winnerPetDataSetALTASTAP;
        private System.Windows.Forms.BindingSource aLTASBindingSource4;
        private WinnerPetDataSetALTASTAPTableAdapters.ALTASTableAdapter aLTASTableAdapter4;
    }
}