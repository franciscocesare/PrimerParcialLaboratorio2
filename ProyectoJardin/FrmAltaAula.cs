using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesJardin;

namespace ProyectoJardin
{
    public partial class FrmAltaAula : Form
    {
        private List<Alumno> alumnos;
        private List<Docente> docentes;
        private List<Aula> aulas;
        private Aula aula;



        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        public List<Docente> ListaDocentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }

        public List<Alumno> ListaAlumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Aula> ListaAulas
        {
            get { return this.aulas; }
            set { this.aulas = value; }
        }


        public FrmAltaAula()
        {
            InitializeComponent();
            // this.alumnos = alumnos;  //los traigo del otro FRMprincipal, como argumentos
            // this.docentes = docentes;
            // this.aulas = aulas;
            //
        }



        private void FrmAltaAula_Load(object sender, EventArgs e)
        {
            cmbColor.DataSource = Enum.GetValues(typeof(Ecolores));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cmbDocente.DataSource = docentes;


            for (int i = 0; i < alumnos.Count; i++)   ///VER CON UN FOREACH
            {
                lstAlumnosSinSala.Items.Add(alumnos[i].ToString());
            }


            if (lstAlumnosEn.Items.Count == 0)
            {
                btnGuardar.Enabled = false;
            }


        }

        private bool ValidarDatosSala()
        {


            if (cmbColor.SelectedIndex != -1
                && cmbTurno.SelectedIndex != -1
                && cmbDocente.SelectedIndex != -1)
            {
                btnGuardar.Enabled = true;
                return true;
            }

            else
            {
                return false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosSala())
            {
                if (!aulas.Contains(aula)) //sino esta, la creas
                {

                    this.aulas.Add(aula);

                }

            }

            btnGuardar.Enabled = true;
            cmbColor.Enabled = true;
            cmbDocente.Enabled = true;
            cmbTurno.Enabled = true;
            existe = false;

            this.DialogResult = DialogResult.OK;
        }

        bool existe = false;

        private bool AgregarAlumnosAlAula()
        {
            if (!existe)
            {

                foreach (Aula item in aulas)  //recorro el array a ver si ya existe turno color
                {
                    if (item.ColorSala == (Ecolores)cmbColor.SelectedItem
                        && item.Docente == (Docente)cmbDocente.SelectedItem
                        && item.Turno == (ETurno)cmbTurno.SelectedItem)

                    {
                        aula = item;

                        foreach (Alumno alumno in item.Alumnos)
                        {

                            lstAlumnosEn.Items.Add($"{alumno.Apellido},{alumno.Nombre}");

                        }
                        btnGuardar.Enabled = true;
                        cmbColor.Enabled = false;
                        cmbDocente.Enabled = false;
                        cmbTurno.Enabled = false;
                        existe = true;
                        return false;
                    }


                }
            }
            if (aula is null)
            {

                aula = new Aula((Ecolores)cmbColor.SelectedItem, (Docente)cmbDocente.SelectedItem, (ETurno)cmbTurno.SelectedItem);
                existe = true;
                btnGuardar.Enabled = true;


            }

            if (!(aula is null))
            {
                // int indice = lstAlumnosSinSala.SelectedIndex;  //ACA TENGO PROBLEMASS CUANDO HAGO MAS DE 1

                if (this.aula + alumnos[lstAlumnosSinSala.SelectedIndex])
                {


                    lstAlumnosEn.Items.Add(alumnos[lstAlumnosSinSala.SelectedIndex]);       //pasarlo de una lista a la otra, borrarlo de la vieja                                           



                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }



        private void lstAlumnosSinSala_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (AgregarAlumnosAlAula())
            {

                alumnos.Remove(alumnos[lstAlumnosSinSala.SelectedIndex]);                //lo borro de la lista original 
                lstAlumnosSinSala.Items.RemoveAt(lstAlumnosSinSala.SelectedIndex);      //lo borro de la lista sinAula
                this.ListaAlumnos = alumnos;                                           //lo seteo para que viaje sin esos alumnos al FrmPrincipal
            }


        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbColor.SelectedIndex;

            switch (cmbColor.SelectedIndex)
            {
                case 0:

                    BackColor = Color.Orange;
                    break;

                case 1:

                    BackColor = Color.Red;
                    break;

                case 2:

                    BackColor = Color.Yellow;
                    break;

                case 3:
                    BackColor = Color.Green; ;
                    break;

                default:
                    BackColor = Color.DarkTurquoise;
                    break;
            }

        }
    }
}
