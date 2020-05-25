using EntidadesJardin;
using System;
using System.Collections.Generic;
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

        
        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            EParentezco parentezco;

            if (Persona.ValidarCargaStringForms(txtBnombre.Text)
                && Persona.ValidarCargaStringForms(txtBapellido.Text)
                && Persona.ValidarCargaEnteroForms(txtBdni.Text, 40000000, 5000000))
            {
                parentezco = (EParentezco)cmbParentezco.SelectedItem;
                dni = int.Parse(txtBdni.Text);
                alumno.Responsable = new Responsable(nombre: txtBnombre.Text, apellido: txtBapellido.Text, dni: dni, femenino: rdBtnFemenino.Checked, parentezco, txtBtelefono.Text) ;
                
            }
           
            this.DialogResult = DialogResult.OK;
        }

    }
}
