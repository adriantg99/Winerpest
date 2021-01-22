using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Catalogo
{
    public partial class Catalogo : Form
    {
        ConexionCatalogo ConexionCatalogo = new ConexionCatalogo();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetSQLTAP.CATALOGO' Puede moverla o quitarla según sea necesario.
            this.cATALOGOTableAdapter5.Fill(this.winnerPetDataSetSQLTAP.CATALOGO);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetCatalogo.CATALOGO' Puede moverla o quitarla según sea necesario.
            cbxTip.DataSource = Enum.GetValues(typeof(ConexionCatalogo.Productos));
            gbxCampos.Enabled = false;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtClasificacion.Enabled = false;
            txtClaveProducto.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecioProducto.Enabled = false;
            gbxOpciones.Enabled = true;
        }

        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            txtClasificacion.Enabled = true;
            txtClaveProducto.Enabled = true;
            txtNombreProducto.Enabled = true;
            txtPrecioProducto.Enabled = true;
            gbxCampos.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice = cbxTip.SelectedIndex;
            indice += 1;
            if(txtClasificacion.Text=="" || txtClaveProducto.Text=="" || txtNombreProducto.Text=="" ||txtPrecioProducto.Text=="")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionCatalogo.ProductoRegistrado(Convert.ToInt32(txtClaveProducto.Text)) == 0)
            {
                MessageBox.Show(ConexionCatalogo.InsertarCatalogo(Convert.ToInt32(txtClaveProducto.Text), indice, txtNombreProducto.Text, Convert.ToSingle(txtPrecioProducto.Text), txtClasificacion.Text));
                ///MessageBox.Show(ConexionGPS.insertar(Convert.ToInt64(txtImei.Text), Convert.ToString(txtLatitud.Text), Convert.ToString(txtLongitud.Text)));
                txtClasificacion.Text = "";
                txtClaveProducto.Text = "";
                txtNombreProducto.Text = "";
                txtPrecioProducto.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar este producto, ya existe uno en la base de datos");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            WinnerPet Principal = new WinnerPet();
            Principal.Visible = true;
            this.Close();
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtClasificacion.Enabled = false;
            txtClaveProducto.Enabled = true;
            txtNombreProducto.Enabled = false;
            txtPrecioProducto.Enabled = false;
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = cbxTip.SelectedIndex;
            indice += 1;
            if (txtClasificacion.Text == "" || txtClaveProducto.Text == "" || txtNombreProducto.Text == "" || txtPrecioProducto.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionCatalogo.ProductoRegistrado(Convert.ToInt32(txtClaveProducto.Text)) == 1)
            {
                MessageBox.Show(ConexionCatalogo.ActualizarProducto(Convert.ToInt32(txtClaveProducto.Text), indice, Convert.ToString(txtNombreProducto.Text), Convert.ToInt32(txtPrecioProducto.Text), txtClasificacion.Text));
                txtClasificacion.Text = "";
                txtClaveProducto.Text = "";
                txtNombreProducto.Text = "";
                txtPrecioProducto.Text = "";

            }
            else
            {
                MessageBox.Show("No existe este usuario");
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtClasificacion.Enabled = true;
            txtClaveProducto.Enabled = true;
            txtNombreProducto.Enabled = true;
            txtPrecioProducto.Enabled = true;
            gbxCampos.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClaveProducto.Text=="")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionCatalogo.ProductoRegistrado(Convert.ToInt32(txtClaveProducto.Text)) == 1)
            {
                MessageBox.Show(ConexionCatalogo.EliminarCatalogo(Convert.ToInt32(txtClaveProducto.Text)));
                txtClaveProducto.Text = "";

            }
            else
            {
                MessageBox.Show("No existe este usuario");
            }
        }

        private void gbxCampos_Enter(object sender, EventArgs e)
        {

        }

        private void gbxOpciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
