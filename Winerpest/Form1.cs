using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest
{
    public partial class WinnerPet : Form
    {
        public WinnerPet()
        {
            InitializeComponent();
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            Cliente.Opciones_clientes abrir = new Cliente.Opciones_clientes();
            abrir.Show();
            this.Visible = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Mascota_Click(object sender, EventArgs e)
        {
            Imei.Agregar_IMEI NuevoImei = new Imei.Agregar_IMEI();
            NuevoImei.Show();
            this.Visible = false;
        }

        private void btn_Catalogo_Click(object sender, EventArgs e)
        {
            Catalogo.Catalogo Catalogo = new Catalogo.Catalogo();
            Catalogo.Show();
            this.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas.VentasPrincipal Ventas = new Ventas.VentasPrincipal();
            this.Visible = false;
            Ventas.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Facturas.Facturas Factuas = new Facturas.Facturas();
            Factuas.Show();
            this.Visible = false;
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            Altas.Altas FormAltas = new Altas.Altas();
            FormAltas.Show();
            this.Visible = false;
        }

        private void btnBitacoras_Click(object sender, EventArgs e)
        {
            Bitacoras bitacoras = new Bitacoras();
            bitacoras.Show();
            this.Close();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.Opciones_clientes abrir = new Cliente.Opciones_clientes();
            abrir.Show();
            this.Visible = false;

        }

        private void catalogoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo.Catalogo Catalogo = new Catalogo.Catalogo();
            Catalogo.Show();
            this.Visible = false;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.VentasPrincipal Ventas = new Ventas.VentasPrincipal();
            this.Visible = false;
            Ventas.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas.Facturas Factuas = new Facturas.Facturas();
            Factuas.Show();
            this.Visible = false;
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas.Altas FormAltas = new Altas.Altas();
            FormAltas.Show();
            this.Visible = false;
        }

        private void bitacorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacoras bitacoras = new Bitacoras();
            bitacoras.Show();
            this.Close();
        }
    }
}
