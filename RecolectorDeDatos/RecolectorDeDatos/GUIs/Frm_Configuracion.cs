using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecolectorDeDatos.GUIs
{
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Frm_Configuracion_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar()
        {
            txbServidorFB.Text = Properties.Settings.Default.ServidorFB;
            txbBaseDeDatosFB.Text = Properties.Settings.Default.BaseDeDatosFB;
            txbUsuarioFB.Text = Properties.Settings.Default.UsuarioFB;
            txbPasswordFB.Text = Properties.Settings.Default.ContraseñaFB;
            numbPuertoFB.Value = Properties.Settings.Default.PuertoFB;

            txbServidorMySQL.Text = Properties.Settings.Default.ServidorMySQL;
            txbBaseDeDatosMySQL.Text = Properties.Settings.Default.BaseDeDatosMySQL;
            txbUsuarioMySQL.Text = Properties.Settings.Default.UsuarioMySQL;
            txbPasswordMySQL.Text = Properties.Settings.Default.ContraseñaMySQL;
            numbPuertoMySQL.Value = Properties.Settings.Default.PuertoMySQL;
        }
        private void Guardar()
        {
            Properties.Settings.Default.ServidorFB = txbServidorFB.Text;
            Properties.Settings.Default.BaseDeDatosFB = txbBaseDeDatosFB.Text;
            Properties.Settings.Default.UsuarioFB = txbUsuarioFB.Text;
            Properties.Settings.Default.ContraseñaFB = txbPasswordFB.Text;
            Properties.Settings.Default.PuertoFB = Convert.ToInt32(numbPuertoFB.Value);

            Properties.Settings.Default.ServidorMySQL = txbServidorMySQL.Text;
            Properties.Settings.Default.BaseDeDatosMySQL = txbBaseDeDatosMySQL.Text;
            Properties.Settings.Default.UsuarioMySQL = txbUsuarioMySQL.Text;
            Properties.Settings.Default.ContraseñaMySQL = txbPasswordMySQL.Text;
            Properties.Settings.Default.PuertoMySQL = Convert.ToInt32(numbPuertoMySQL.Value);

            Properties.Settings.Default.Save();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                MessageBox.Show("");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
