namespace Winerpest
{
    partial class WinnerPet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1406, 45);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(186, 66);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 63);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1035);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1592, 125);
            this.panel2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.catalogoDeProductosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.altasToolStripMenuItem,
            this.bitacorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1592, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.registroClienteToolStripMenuItem.Text = "Registro cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // catalogoDeProductosToolStripMenuItem
            // 
            this.catalogoDeProductosToolStripMenuItem.Name = "catalogoDeProductosToolStripMenuItem";
            this.catalogoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(212, 29);
            this.catalogoDeProductosToolStripMenuItem.Text = "Catalogo de productos";
            this.catalogoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeProductosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // bitacorasToolStripMenuItem
            // 
            this.bitacorasToolStripMenuItem.Name = "bitacorasToolStripMenuItem";
            this.bitacorasToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.bitacorasToolStripMenuItem.Text = "Bitacoras";
            this.bitacorasToolStripMenuItem.Click += new System.EventHandler(this.bitacorasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winerpest.Properties.Resources.Veterinaria;
            this.pictureBox1.Location = new System.Drawing.Point(0, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1580, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // WinnerPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1592, 1160);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WinnerPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerPet";
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacorasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

