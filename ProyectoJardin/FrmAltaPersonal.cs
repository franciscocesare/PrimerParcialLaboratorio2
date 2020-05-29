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

        private List<Administrativo> listapersonal;
        private List<Docente> docentes;
        private Administrativo personal;
        private Docente docente;

        public FrmAltaPersonal()
        {

            InitializeComponent();

        }



        public Administrativo Personal
        {
            get { return this.personal; }
            set { this.personal = value; }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }


        public List<Administrativo> ListaPersonal
        {
            get { return listapersonal; }
            set { listapersonal = value; }
        }
        public List<Docente> Docentes
        {
            get { return docentes; }
            set { docentes = value; }
        }



        private void DarAltaPersonal()
        {
            string resultado = this.ValidarCargasHechas();

            switch (resultado)
            {
                case "Ok":
                    if (CargarDatosDocente() || CargarDatosNODocente())

                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    break;
                case "Error Horario":
                    MessageBox.Show("Error en el horario ingresado\n");

                    break;
                case "Error Dni":

                    MessageBox.Show($"Error en el Dni:\n *{txtDni.Text}*");

                    break;
                case "Error Nombre":
                    MessageBox.Show("Error en Nombre o Apellido\n");

                    break;

            }
        }


        public string ValidarCargasHechas()
        {
            if (Persona.ValidarCargaStringForms(txtNombre.Text)
                && Persona.ValidarCargaStringForms(txtApellido.Text))
            {
                if (Persona.ValidarCargaEnteroForms(txtDni.Text, 40000000, 5000000))
                {
                    if (numHoraEntrada.Value != 0 // horarioEntrada
                          && numHoraSalida.Value != 0)
                    {
                       
                        return "Ok";
                    }
                    return "Error Horario";
                }
                return "Error Dni";

            }
            return "Error Nombre";
        }


        protected bool CargarDatosNODocente()
        {
            ECargo cargo;
            int dni = int.Parse(txtDni.Text); //tiene que ir adentro

            if (btnAceptar.Text == "Cargar Personal"
                  && Enum.TryParse<ECargo>(cmbCargos.SelectedItem.ToString(), out cargo))
            {
                DateTime entrada = new DateTime(01, 01, 01, int.Parse(numHoraEntrada.Value.ToString()), 00, 00); //si le saco despues de la coma los dos 00????
                DateTime salida = new DateTime(01, 01, 01, int.Parse(numHoraSalida.Value.ToString()), 00, 00);
                personal = new Administrativo(txtApellido.Text, txtNombre.Text, dni, rdbFemenino.Checked,personal.HoraEntrada,salida, cargo);
                ListaPersonal.Add(personal);

                return true;
            }
            return false;
        }


        protected bool CargarDatosDocente()  //llega mal el horario
        {
            double precioxHora;
            int dni = int.Parse(txtDni.Text); 

            if (btnAceptar.Text == "Cargar Docente")
            {
                if (Persona.ValidarCargaEnteroForms(txtbPrecioHora.Text, 1000, 100))
                { 
                    DateTime entrada = new DateTime(01, 01, 01, int.Parse(numHoraEntrada.Value.ToString()), 00, 00); //si le saco despues de la coma los dos 00????
                    DateTime salida = new DateTime(01, 01, 01, int.Parse(numHoraSalida.Value.ToString()), 00, 00);
                    precioxHora = double.Parse(txtbPrecioHora.Text);
                    docente = new Docente(nombre: txtNombre.Text, apellido: txtApellido.Text, dni: dni, femenino: rdbFemenino.Checked, entrada, salida, precioxHora);
                    Docentes.Add(docente);

                    return true;
                }
                else
                {
                    MessageBox.Show("La hora debe valer entre 100 y 1000");
                    txtbPrecioHora.Text = "";
                }


            }
           

            return false;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            this.DarAltaPersonal();

        }

        private void FrmAltaPersonal_Load_1(object sender, EventArgs e)
        {

            cmbCargos.DataSource = Enum.GetValues(typeof(ECargo));
        }

        public void SetParaDocentes()
        {
           
            txtbPrecioHora.Visible = true;
            lblCargo.Visible = false;
            cmbCargos.Visible = false;
            cmbCargos.DataSource = Enum.GetValues(typeof(ECargo));
            cmbCargos.Visible = false;
            btnAceptar.Text = "Cargar Docente";

        }

        public void SetParaPersonal()
        {
            cmbCargos.Enabled = true;
            txtbPrecioHora.Visible = false;
            cmbCargos.Visible = false;
            cmbCargos.Visible = true;
            label1.Visible = false;
            btnAceptar.Text = "Cargar Personal";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Salir?", "Abandonando Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void numHoraEntrada_ValueChanged(object sender, EventArgs e)
        {
            numHoraEntrada.Minimum = 7;
            numHoraEntrada.Maximum = 17;
        }

        private void numHoraSalida_ValueChanged(object sender, EventArgs e)
        {
            numHoraSalida.Minimum = 7;
            numHoraSalida.Maximum = 17;
        }

       
    }


}
