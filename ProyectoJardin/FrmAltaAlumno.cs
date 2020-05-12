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
        private List <Responsable> responsables;

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

        public FrmAltaAlumno(List<Responsable> responsables) //no pasa por aca!
        {
            this.responsables = responsables;
        }



        public FrmAltaAlumno()
        {
            InitializeComponent();
            //this.responsable  = new Responsable();
        }


        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            btnAceptar.Text= "Datos Responsable";
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int dni;

            if (Persona.ValidarCargaStringForms(txtNombre.Text)
                 && Persona.ValidarCargaStringForms(txtApellido.Text)
                 && Int32.TryParse(txtDni.Text, out dni))
            {
                float cuota = float.Parse(txtCuota.Text);
                alumno = new Alumno(nombre: txtNombre.Text, apellido: txtApellido.Text, dni: dni, femenino: rdbNiña.Checked, precioCuota: cuota);


                FrmAltaResponsables frmAltaResponsables = new FrmAltaResponsables(alumno);//tiene sobrecargas para asignar, aca una de responsables
                frmAltaResponsables.ShowDialog();

                if (frmAltaResponsables.DialogResult == DialogResult.OK)
                {
                    btnAceptar.Text = "Finalizar";
                    //alumno.Responsable = frmAltaResponsables.Responsable; //alumno me lelga null!!!!!1
                }
                else if (frmAltaResponsables.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("se canceló con exito");
                }

            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
