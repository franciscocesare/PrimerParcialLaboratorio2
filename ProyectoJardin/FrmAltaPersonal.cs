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

        private List<Administrativo> Listapersonal;
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
            get { return Listapersonal; }
            set { Listapersonal = value; }
        }
        public List<Docente> Docentes
        {
            get { return docentes; }
            set { docentes = value; }
        }


        /*
         *  if (Persona.ValidarCargaStringForms(txtBnombre.Text)
                && Persona.ValidarCargaStringForms(txtBapellido.Text)
                && Persona.ValidarCargaEnteroForms(txtBdni.Text, 40000000, 5000000))
         */


        private bool ValidarCargasHechas()
        {
            if (Persona.ValidarCargaStringForms(txtNombre.Text)
                && Persona.ValidarCargaStringForms(txtApellido.Text)
                && Persona.ValidarCargaEnteroForms(txtDni.Text, 40000000, 5000000) //entre 5 millones y 40 millones
                && Int32.TryParse(txtbHoraEntrada.Text, out horarioEntrada)
                && Int32.TryParse(txtbHoraSalida.Text, out horarioSalida))
            {
                return true;

            }
            return false;
        }

        int horarioEntrada;
        int horarioSalida;


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ECargo cargo;
            int dni = int.Parse(txtDni.Text);


            double precioxHora;

            if (ValidarCargasHechas() && btnAceptar.Text == "Cargar Docente"
                                       && double.TryParse(txtbPrecioHora.Text, out precioxHora))
            {
                DateTime entrada = new DateTime(01, 01, 01, horarioEntrada, 00, 00); //si le saco despues de la coma los dos 00????
                DateTime salida = new DateTime(01, 01, 01, horarioSalida, 00, 00);

                docente = new Docente(nombre: txtNombre.Text, apellido: txtApellido.Text, dni: dni, femenino: rdbFemenino.Checked, entrada, salida, precioxHora);
                Docentes.Add(docente);  //sumo a la lista el docente, despues mando la lista completa por dialog
                                        //solucionar falla en el alta docente
                this.DialogResult = DialogResult.OK;


            }

            else if (ValidarCargasHechas() && btnAceptar.Text == "Cargar Personal"
                   && Enum.TryParse<ECargo>(cmbCargos.SelectedItem.ToString(), out cargo))
            {
                DateTime entrada = new DateTime(01, 01, 01, horarioEntrada, 00, 00);
                DateTime salida = new DateTime(01, 01, 01, horarioSalida, 00, 00);
                personal = new Administrativo(txtApellido.Text, txtNombre.Text, dni, rdbFemenino.Checked, entrada, salida, cargo);
                ListaPersonal.Add(personal);
                MessageBox.Show("alta exitosa \n" + personal.Apellido);

                this.DialogResult = DialogResult.OK;

            }

        }





        private void FrmAltaPersonal_Load_1(object sender, EventArgs e)
        {

            cmbCargos.DataSource = Enum.GetValues(typeof(ECargo));
        }

        public void SetParaDocentes()
        {
            txtbHoraEntrada.Visible = true;
            txtbHoraSalida.Visible = true;
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
            txtbHoraEntrada.Visible = true;
            txtbHoraSalida.Visible = true;
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


    }


}
