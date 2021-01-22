namespace Winerpest
{
    partial class Bitacoras
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
            this.winnerPetDataSet9 = new Winerpest.WinnerPetDataSet9();
            this.bitacorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitacorasTableAdapter = new Winerpest.WinnerPetDataSet9TableAdapters.BitacorasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.queryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bitacorasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // winnerPetDataSet9
            // 
            this.winnerPetDataSet9.DataSetName = "WinnerPetDataSet9";
            this.winnerPetDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacorasBindingSource
            // 
            this.bitacorasBindingSource.DataMember = "Bitacoras";
            this.bitacorasBindingSource.DataSource = this.winnerPetDataSet9;
            // 
            // bitacorasTableAdapter
            // 
            this.bitacorasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // queryDataGridViewTextBoxColumn
            // 
            this.queryDataGridViewTextBoxColumn.DataPropertyName = "Query";
            this.queryDataGridViewTextBoxColumn.HeaderText = "Query";
            this.queryDataGridViewTextBoxColumn.Name = "queryDataGridViewTextBoxColumn";
            this.queryDataGridViewTextBoxColumn.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitacoras";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(640, 401);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(148, 37);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Bitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bitacoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacoras";
            this.Load += new System.EventHandler(this.Bitacoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPetDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacorasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WinnerPetDataSet9 winnerPetDataSet9;
        private System.Windows.Forms.BindingSource bitacorasBindingSource;
        private WinnerPetDataSet9TableAdapters.BitacorasTableAdapter bitacorasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
    }
}