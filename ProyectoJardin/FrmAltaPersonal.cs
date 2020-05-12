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
    public partial class FrmAltaPersonal : Form
    {

        private Personal personal;
        private Docente docente;  

        public FrmAltaPersonal() 
        {

            InitializeComponent();
           
        }



        public Personal Personal
        {
            get { return personal; }
            set { personal = value; }
        }
        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }

      

        protected  void btnAceptar_Click(object sender, EventArgs e)
        {
            
            int dni;
            int horarioEntrada;
            int horarioSalida;
            int precioxHora;


            if (Persona.ValidarCargaStringForms(txtNombre.Text)
                 && Persona.ValidarCargaStringForms(txtApellido.Text)
                 && Int32.TryParse(txtDni.Text, out dni)
                 && Int32.TryParse(txtbHoraEntrada.Text, out horarioEntrada)
                 && Int32.TryParse(txtbHoraEntrada.Text, out horarioSalida)
                 && Int32.TryParse(txtbPrecioHora.Text, out precioxHora))

           
            {
                DateTime entrada = new DateTime(01, 01, 01, horarioEntrada, 00, 00);
                DateTime salida = new DateTime(01, 01, 01, horarioSalida, 00, 00);
                docente = new Docente(nombre: txtNombre.Text, apellido: txtApellido.Text, dni: dni, femenino: rdbFemenino.Checked, entrada, salida, precioxHora); 
            }

        }

        private void FrmAltaPersonal_Load_1(object sender, EventArgs e)
        {

            txtbHoraEntrada.Visible = true;
            txtbHoraSalida.Visible = true;
            txtbPrecioHora.Visible = true;
            cmbCargos.Enabled = false;
            cmbCargos.DataSource = Enum.GetValues(typeof(ECargo));

        }


      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
