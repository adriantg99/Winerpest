using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Facturas
{
    public partial class Facturas : Form
    {
        ConexionFacturas ConexionFactura = new ConexionFacturas();
        OpcionesCombo Combo = new OpcionesCombo();
        public Facturas()
        {
            InitializeComponent();
      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCveFact.Text==""||txtIva.Text==""||txtSubtotal.Text==""||txtTotal.Text=="")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 0)
            {
                MessageBox.Show(ConexionFactura.insertarFactura((txtCveFact.Text), Convert.ToInt32(txtSubtotal.Text), Convert.ToInt32(txtIva.Text),Convert.ToInt32(txtTotal.Text),Convert.ToInt32(cmbxCveVenta.Text),Convert.ToInt32(cmbxClaveCLiente.Text)));
                txtCveFact.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";
                cmbxClaveCLiente.Text = "";
                cmbxCveVenta.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCveFact.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 1)
            {
                MessageBox.Show(ConexionFactura.eliminarFactura(txtCveFact.Text));
                txtCveFact.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";
                cmbxClaveCLiente.Text = "";
                cmbxCveVenta.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCveFact.Text == "" || txtIva.Text == "" || txtSubtotal.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 1)
            {
                MessageBox.Show(ConexionFactura.ActualizarFactura((txtCveFact.Text), Convert.ToInt32(txtSubtotal.Text), Convert.ToInt32(txtIva.Text), Convert.ToInt32(txtTotal.Text), Convert.ToInt32(cmbxCveVenta.Text), Convert.ToInt32(cmbxClaveCLiente.Text)));
                cmbxClaveCLiente.Text = "";
                cmbxCveVenta.Text = "";
                txtCveFact.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetFacturaSQLTAP.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter4.Fill(this.winnerPetDataSetFacturaSQLTAP.FACTURA);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetFactura.FACTURA' Puede moverla o quitarla según sea necesario.

            Combo.seleccionar(cmbxCveVenta);
            Combo.seleccionarImei(cmbxClaveCLiente);

            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet6.FACTURA' Puede moverla o quitarla según sea necesario.
            gbxCampos.Enabled = false;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            WinnerPet Principal = new WinnerPet();
            Principal.Visible = true;
            this.Close();
        }

        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            gbxOpciones.Enabled = true;
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtIva.Enabled = true;
            txtSubtotal.Enabled = true;
            txtTotal.Enabled = true;
            cmbxClaveCLiente.Enabled = true;
            cmbxCveVenta.Enabled = true;

        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            cmbxClaveCLiente.Enabled = false;
            cmbxCveVenta.Enabled = false;
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = false;
            txtIva.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            txtIva.Enabled = true;
            txtSubtotal.Enabled = true;
            txtTotal.Enabled = true;
            cmbxClaveCLiente.Enabled = true;
            cmbxCveVenta.Enabled = true;
        }
    }
}
