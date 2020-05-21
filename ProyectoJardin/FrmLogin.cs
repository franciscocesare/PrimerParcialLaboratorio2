using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJardin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem.ToString() == "Cocina" || cmbUsuario.SelectedItem.ToString() == "Portería")
            {
                txtPassW.Enabled = false;
                MessageBox.Show("Sector sin acceso");
            }
            else
            {
                txtPassW.Enabled = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cmbUsuario.Items.Clear();
            cmbUsuario.DataSource = Enum.GetValues(typeof(ECargo));
            
            
           
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem.ToString() == ECargo.Secretaría.ToString()
                || cmbUsuario.SelectedItem.ToString() == ECargo.Dirección.ToString()
                || cmbUsuario.SelectedItem.ToString() == ECargo.Tesorería.ToString())
            {
                if (txtPassW.Text == "abc123")
                {
                    MessageBox.Show("Bienvenido a Jardin Pichoncitos!");
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.Show(this);
                    this.Hide();
                }
                else if (MessageBox.Show("¿Intentar con otra clave?", "ACCESO DENEGADO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                 == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    txtPassW.Text = string.Empty;
                }
            }
            else if (cmbUsuario.SelectedItem.ToString() == ECargo.Cocina.ToString()
                || cmbUsuario.SelectedItem.ToString() == ECargo.Portería.ToString())
                 
            {


            }


        }
    }
}
