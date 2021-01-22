namespace Winerpest.Cliente
{
    partial class Cliente
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
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet = new Winerpest.WinnerPetDataSet();
            this.cLIENTETableAdapter = new Winerpest.WinnerPetDataSetTableAdapters.CLIENTETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cveclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSetClienteSQLTAP = new Winerpest.WinnerPetDataSetClienteSQLTAP();
            this.cLIENTEBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet19 = new Winerpest.WinnerPetDataSet19();
            this.cLIENTEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet14 = new Winerpest.WinnerPetDataSet14();
            this.cLIENTEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetClienteAgregar = new Winerpest.WinnerPetClienteAgregar();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.winnerPetDataSet1 = new Winerpest.WinnerPetDataSet1();
            this.cLIENTETableAdapter1 = new Winerpest.WinnerPetDataSet1TableAdapters.CLIENTETableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cLIENTETableAdapter2 = new Winerpest.WinnerPetClienteAgregarTableAdapters.CLIENTETableAdapter();
            this.cLIENTETableAdapter3 = new Winerpest.WinnerPetDataSet14TableAdapters.CLIENTETableAdapter();
            this.cLIENTETableAdapter4 = new Winerpest.WinnerPetDataSet19TableAdapters.CLIENTETableAdapter();
            this.cLIENTETableAdapter5 = new Winerpest.WinnerPetDataSetClienteSQLTAPTableAdapters.CLIENTETableAdapter();
            this.gbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetClienteSQLTAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetClienteAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.AutoSize = true;
            this.gbx1.Controls.Add(this.txtbid);
            this.gbx1.Controls.Add(this.label1);
            this.gbx1.Controls.Add(this.btnAgregar);
            this.gbx1.Controls.Add(this.label2);
            this.gbx1.Controls.Add(this.dataGridView1);
            this.gbx1.Controls.Add(this.txtTelefono);
            this.gbx1.Controls.Add(this.lblName);
            this.gbx1.Controls.Add(this.txtbNombre);
            this.gbx1.Location = new System.Drawing.Point(12, 55);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(754, 601);
            this.gbx1.TabIndex = 0;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Cliente";
            this.gbx1.Enter += new System.EventHandler(this.gbx1_Enter);
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(173, 88);
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(163, 20);
            this.txtbid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(452, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 39);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(173, 152);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre Completo";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(173, 124);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(163, 20);
            this.txtbNombre.TabIndex = 2;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.winnerPetDataSet;
            // 
            // winnerPetDataSet
            // 
            this.winnerPetDataSet.DataSetName = "WinnerPetDataSet";
            this.winnerPetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(6, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // cveclienteDataGridViewTextBoxColumn
            // 
            this.cveclienteDataGridViewTextBoxColumn.DataPropertyName = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.HeaderText = "cve_cliente";
            this.cveclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cveclienteDataGridViewTextBoxColumn.Name = "cveclienteDataGridViewTextBoxColumn";
            this.cveclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLIENTEBindingSource5
            // 
            this.cLIENTEBindingSource5.DataMember = "CLIENTE";
            this.cLIENTEBindingSource5.DataSource = this.winnerPetDataSetClienteSQLTAP;
            // 
            // winnerPetDataSetClienteSQLTAP
            // 
            this.winnerPetDataSetClienteSQLTAP.DataSetName = "WinnerPetDataSetClienteSQLTAP";
            this.winnerPetDataSetClienteSQLTAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource4
            // 
            this.cLIENTEBindingSource4.DataMember = "CLIENTE";
            this.cLIENTEBindingSource4.DataSource = this.winnerPetDataSet19;
            // 
            // winnerPetDataSet19
            // 
            this.winnerPetDataSet19.DataSetName = "WinnerPetDataSet19";
            this.winnerPetDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource3
            // 
            this.cLIENTEBindingSource3.DataMember = "CLIENTE";
            this.cLIENTEBindingSource3.DataSource = this.winnerPetDataSet14;
            // 
            // winnerPetDataSet14
            // 
            this.winnerPetDataSet14.DataSetName = "WinnerPetDataSet14";
            this.winnerPetDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource2
            // 
            this.cLIENTEBindingSource2.DataMember = "CLIENTE";
            this.cLIENTEBindingSource2.DataSource = this.winnerPetClienteAgregar;
            // 
            // winnerPetClienteAgregar
            // 
            this.winnerPetClienteAgregar.DataSetName = "WinnerPetClienteAgregar";
            this.winnerPetClienteAgregar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.winnerPetDataSet1;
            // 
            // winnerPetDataSet1
            // 
            this.winnerPetDataSet1.DataSetName = "WinnerPetDataSet1";
            this.winnerPetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter1
            // 
            this.cLIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(565, 650);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 58);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 36);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 36);
            this.panel2.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(464, 537);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 36);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Regresar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // cLIENTETableAdapter2
            // 
            this.cLIENTETableAdapter2.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter3
            // 
            this.cLIENTETableAdapter3.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter4
            // 
            this.cLIENTETableAdapter4.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter5
            // 
            this.cLIENTETableAdapter5.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbx1);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSetClienteSQLTAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetClienteAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbNombre;
        private WinnerPetDataSet winnerPetDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private WinnerPetDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbid;
        private System.Windows.Forms.Label label1;
        private WinnerPetDataSet1 winnerPetDataSet1;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private WinnerPetDataSet1TableAdapters.CLIENTETableAdapter cLIENTETableAdapter1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVolver;
        private WinnerPetClienteAgregar winnerPetClienteAgregar;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource2;
        private WinnerPetClienteAgregarTableAdapters.CLIENTETableAdapter cLIENTETableAdapter2;
        private WinnerPetDataSet14 winnerPetDataSet14;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource3;
        private WinnerPetDataSet14TableAdapters.CLIENTETableAdapter cLIENTETableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private WinnerPetDataSet19 winnerPetDataSet19;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource4;
        private WinnerPetDataSet19TableAdapters.CLIENTETableAdapter cLIENTETableAdapter4;
        private WinnerPetDataSetClienteSQLTAP winnerPetDataSetClienteSQLTAP;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource5;
        private WinnerPetDataSetClienteSQLTAPTableAdapters.CLIENTETableAdapter cLIENTETableAdapter5;
    }
}