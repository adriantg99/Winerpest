using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Imei
{
    public partial class Agregar_IMEI : Form
    {
        Conexiones.ConexionesGps.ConexionesGps ConexionGPS = new Conexiones.ConexionesGps.ConexionesGps();
        public Agregar_IMEI()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtImei.Text=="" || txtLatitud.Text=="" || txtLongitud.Text=="")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if(ConexionGPS.GPSRegistrado(Convert.ToInt64(txtImei.Text)) == 0) 
            {
                MessageBox.Show(ConexionGPS.insertar(Convert.ToInt64(txtImei.Text), Convert.ToString(txtLatitud.Text), Convert.ToString(txtLongitud.Text)));
                txtImei.Text = "";
                txtLatitud.Text = "";
                txtLongitud.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar este GPS, ya existe uno en la base de datos");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtImei.Enabled = true;
            txtLatitud.Enabled = true;
            txtLongitud.Enabled = true;

        }

        private void Agregar_IMEI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetGPSTAPSQL.GPS' Puede moverla o quitarla según sea necesario.
            this.gPSTableAdapter6.Fill(this.winnerPetDataSetGPSTAPSQL.GPS);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetGPS.GPS' Puede moverla o quitarla según sea necesario.

            gbxCampos.Enabled = false;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = false;
            txtLatitud.Enabled = false;
            txtLongitud.Enabled = false;
            txtImei.Enabled = true;

        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            txtLatitud.Enabled = true;
            txtLongitud.Enabled = true;
            txtImei.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtImei.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionGPS.GPSRegistrado(Convert.ToInt64(txtImei.Text)) == 1)
            {
                MessageBox.Show(ConexionGPS.EliminarGPS(Convert.ToInt64(txtImei.Text)));
                txtImei.Text = "";

            }
            else
            {
                MessageBox.Show("No existe este usuario");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtImei.Text == "" || txtLatitud.Text == "" || txtLongitud.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionGPS.GPSRegistrado(Convert.ToInt64(txtImei.Text)) == 1)
            {
                MessageBox.Show(ConexionGPS.ActualizarGPS(Convert.ToInt64(txtImei.Text), Convert.ToString(txtLatitud.Text), Convert.ToString(txtLongitud.Text)));
                txtImei.Text = "";

            }
            else
            {
                MessageBox.Show("No existe este usuario");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            WinnerPet Principal = new WinnerPet();
            Principal.Show();
            this.Close();

        }
    }
}
