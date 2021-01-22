using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winerpest.Altas
{
    public partial class Altas : Form
    {
        ConexionAltas Conexion = new ConexionAltas();
        ComboBoxs Items = new ComboBoxs();
        public Altas()
        {
            InitializeComponent();
            Items.seleccionar(cbxClaveVenta);
            Items.seleccionarImei(cbImei);
        }

        private void gbxCampos_Enter(object sender, EventArgs e)
        {

        }

        private void Altas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetALTASTAP.ALTAS' Puede moverla o quitarla según sea necesario.
            this.aLTASTableAdapter4.Fill(this.winnerPetDataSetALTASTAP.ALTAS);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet21.ALTAS' Puede moverla o quitarla según sea necesario.

            gbxCampos.Enabled = false;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            
            idAlta.Enabled = false;
            cbImei.Enabled = false;
            cbxClaveVenta.Enabled = false;

        }

        private void Volver_Click(object sender, EventArgs e)
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
            
            idAlta.Enabled = true;
            cbImei.Enabled = true;
            cbxClaveVenta.Enabled = true;

        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            
            idAlta.Enabled = true;
            cbImei.Enabled = false;
            cbxClaveVenta.Enabled = false;


        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            
            idAlta.Enabled = true;
            cbImei.Enabled = true;
            cbxClaveVenta.Enabled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idAlta.Text==""||cbImei.Text== "--- Selecciona un item---"||cbxClaveVenta.Text== "--- Selecciona un item---")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (Conexion.AltaRegistrada((Convert.ToInt32(idAlta.Text))) == 0)
            {
                MessageBox.Show(Conexion.insertarAlta(Convert.ToInt32(idAlta.Text),Convert.ToInt32(cbxClaveVenta.Text), cbImei.Text));
                idAlta.Text = "";
                cbxClaveVenta.Text = "--- Selecciona un item---";
                cbImei.Text = "--- Selecciona un item---";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }
        }
    }
}
