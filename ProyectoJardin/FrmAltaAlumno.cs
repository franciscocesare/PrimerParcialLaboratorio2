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
    public partial class FrmAltaAlumno : Form
    {
        private Alumno alumno;
        private List<Responsable> responsables;

        //PROPIEDADDES


        public Alumno Alumno
        {
            get { return this.alumno; }
            set { this.alumno = value; }
        }

        public List<Responsable> Responsable
        {
            get { return this.responsables; }
            set { this.responsables = value; }
        }

        public FrmAltaAlumno(List<Responsable> responsables)
        {
            this.responsables = responsables;
        }



        public FrmAltaAlumno()
        {
            InitializeComponent();

        }


        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            btnAceptar.Text = "Datos Responsable";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.DarAltaAlumnoResponsable();
        }

        public string ValidarCargasHechas()
        {
            if (Persona.ValidarCargaStringForms(txtNombre.Text)
                && Persona.ValidarCargaStringForms(txtApellido.Text))
            {
                if (Persona.ValidarCargaEnteroForms(txtDni.Text, 50000000, 40000000) || Persona.ValidarCargaEnteroForms(txtDni.Text, 99000000, 90000000)) //pa
                {
                    if (Persona.ValidarCargaEnteroForms(txtCuota.Text, 3000, 500))
                    {

                        return "Ok";
                    }
                    return "Error Cuota";
                }
                return "Error Dni";
            }
            return "Error Nombre";
        }


        public void DarAltaAlumnoResponsable()  ///la tuve que poner public para los test
        {
            switch (ValidarCargasHechas())
            {
                case "Ok":

                    alumno = new Alumno(nombre: txtNombre.Text, apellido: txtApellido.Text, dni: int.Parse(txtDni.Text), femenino: rdbNiña.Checked, precioCuota: float.Parse(txtCuota.Text));
                    CompletarAltaResponsable();
                   // this.DialogResult = DialogResult.OK;
                    break;

                case "Error Dni":

                    MessageBox.Show($"Este dato no es Valido como DNI: \n *{txtDni.Text}*");
                    txtDni.Text = "";
                    break;

                case "Error Nombre":

                    MessageBox.Show("Revise los datos del Nombre y Apellido");
                    break;

                case "Error Cuota":

                    MessageBox.Show("Revise datos de la Cuota, entre $500 y $3000");
                    break;
            }




        }


        public void CompletarAltaResponsable()
        {
            FrmAltaResponsables frmAltaResponsables = new FrmAltaResponsables(alumno);
            frmAltaResponsables.ShowDialog();

            if (frmAltaResponsables.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
//                btnAceptar.Text = "Finalizar";

            }
            else if (frmAltaResponsables.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }
        }

       
    }
}
