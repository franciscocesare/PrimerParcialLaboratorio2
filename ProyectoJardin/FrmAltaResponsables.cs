using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Windows.Forms;


namespace ProyectoJardin
{
    public partial class FrmAltaResponsables : Form  //NO HACER INSTANCIAS 
    {
        private Responsable responsable;
        private Alumno alumno;


        public Responsable Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public FrmAltaResponsables(Alumno alumno) //Ctor sin parametros
        {

            InitializeComponent();
            this.alumno = alumno;

        }



        protected void FrmAltaResponsables_Load(object sender, EventArgs e)
        {
            this.cmbParentezco.Visible = true;
            this.lblResponsable.Text = "Parentezco";
            this.lblTelefono.Text = "Telefono";
            this.btnAceptar.Text = "Alta Responsable";
            this.cmbParentezco.DataSource = Enum.GetValues(typeof(EParentezco));
        }


        protected virtual void btnCancelar_Click(object sender, EventArgs e) //hacer el override en ALtas, como el aceptar
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string ValidarCargasHechas()
        {
            if (Persona.ValidarCargaStringForms(txtBnombre.Text)
                && Persona.ValidarCargaStringForms(txtBapellido.Text))
            {
                if (Persona.ValidarCargaEnteroForms(txtBdni.Text, 40000000, 5000000) || Persona.ValidarCargaEnteroForms(txtBdni.Text, 99999999, 90000000))
                {
                    if (Persona.ValidarCargaEnteroForms(txtBtelefono.Text, 999999999, 999999))
                    { 
                        return "Ok";
                    }
                    return "Error Tel";
                }
                return "Error Dni";
            }
            return "Error Nombre";
        }


        public void CompletarDatosResp()
        { 
            switch (ValidarCargasHechas())
            {
                case "Ok":

                    MessageBox.Show($"Alta Responsable del alumne:\n {alumno.Apellido}, {alumno.Nombre}");
                    alumno.Responsable = new Responsable(nombre: txtBnombre.Text, apellido: txtBapellido.Text, dni: int.Parse(txtBdni.Text), femenino: rdBtnFemenino.Checked, (EParentezco)cmbParentezco.SelectedItem, txtBtelefono.Text);

                    this.DialogResult = DialogResult.OK;

                    break;

                case "Error Dni":

                    MessageBox.Show($"Este dato no es Valido como DNI: \n *{txtBdni.Text}*");
                    txtBdni.Text = "";
                    break;

                case "Error nombre":

                    MessageBox.Show("Revise los datos del Nombre y Apellido");
                    break;

                case "Error Tel":

                    MessageBox.Show($"Revise Telefono:\n*{txtBtelefono.Text}*");
                    break;
            }

        }


        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {

            this.CompletarDatosResp();

        }



    }
}
