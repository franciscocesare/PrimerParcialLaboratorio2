using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        /// <summary>
        /// valida que se haya seleccionado algo para el alta aula
        /// </summary>
        /// <returns></returns>true si se selecciono algo en cada campo
        private bool ValidarDatosSala()
        {

            if (cmbColor.SelectedIndex != -1
                && cmbTurno.SelectedIndex != -1
                && cmbDocente.SelectedIndex != -1)
            {

                return true;
            }

            else
            {
                return false;
            }

        }
        /// <summary>
        /// EVENTO doble click, si cargo datos, suma item AULA a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosSala())
            {
                if (!aulas.Contains(aula)) //sino esta le sumas a la lista el aula creada
                {

                    this.aulas.Add(aula);

                }

            }

            btnGuardar.Enabled = true;
            this.DialogResult = DialogResult.OK;
        }

        //cmbColor.Enabled = true;
        //cmbDocente.Enabled = true;
        //cmbTurno.Enabled = true;
        //existe = false;

        /// <summary>
        /// comprobar si el aula ya existe, y si tiene lugar
        /// </summary>
        /// <returns></returns>
        /// 
        private bool ValidarExistenciaAula()
        {
            foreach (Aula item in aulas)  //recorro el array a ver si ya existe turno color
            {
                if (item.ColorSala == (Ecolores)cmbColor.SelectedItem
                    && item.Docente == (Docente)cmbDocente.SelectedItem
                    && item.Turno == (ETurno)cmbTurno.SelectedItem)
                {
                    return true;
                }

            }
            return false;
        }

        bool existe;

        /// <summary>
        /// devuelve si se pudo guardar un alumno en un aula, si aula existia
        /// </summary>
        /// <returns></returns>
        /// 
        private bool MostrarAulaYaExiste()
        {
            string sexo;

            foreach (Aula item in aulas)  //recorro el array a ver si ya existe turno color
            {
                if (ValidarExistenciaAula())

                {
                    aula = item;
                    foreach (Alumno alumno in item.Alumnos)
                    {
                        if (alumno.Femenino)
                        {
                            sexo = "Femenino";
                        }
                        else
                            sexo = "Masculino";

                        lstAlumnosEn.Items.Add($"{alumno.Apellido},{alumno.Nombre},{sexo},{alumno.Dni},{alumno.Legajo}");

                    }


                    return true;
                }


            }
            return false;
        }



        /// <summary>
        /// agregar un alumno al aula existente
        /// </summary>
        /// <returns></returns>True si pudo agregar el alumno al aula existente
        private void AgregarAlumnosAulaExiste()
        {
          
            
            int indice = lstAlumnosSinSala.SelectedIndex;

            if (this.aula + alumnos[indice])
            {

                lstAlumnosEn.Items.Add(alumnos[indice]);
                alumnos.Remove(alumnos[lstAlumnosSinSala.SelectedIndex]);                //lo borro de la lista original 

                lstAlumnosSinSala.Items.RemoveAt(lstAlumnosSinSala.SelectedIndex);      //lo borro de la lista sinAula
                this.ListaAlumnos = alumnos;                                           //lo seteo para que viaje sin esos alumnos al FrmPrincipal

            }

        }

        private bool CrearAula()
        {
            if (aula is null)
            {

                aula = new Aula((Ecolores)cmbColor.SelectedItem, (Docente)cmbDocente.SelectedItem, (ETurno)cmbTurno.SelectedItem);
               
                existe = true;
                btnGuardar.Enabled = true;

                return true;
            }

            return false;
        }

        /// <summary>
        /// pase un alumno de una lista a la otra,lo elimino. la lista se refresca
        /// </summary>
        /// <param name="sender"></param> mando a FrmPrincipal la lista refrescada de cambios
        /// <param name="e"></param> lista de alumnos
        /// 

        //AgregarAlumnosAulaExiste() Agregar alumno a aula que existe
        //MostrarAulaYaExiste() devuelve si se pudo guardar un alumno en un aula, si aula existia
        //ValidarExistenciaAula()  si ya existe ese color ese turno ese docente

        private void lstAlumnosSinSala_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnGuardar.Enabled = true;

            if (ValidarExistenciaAula()) //si es null crea el aula con
            {
                if(!(existe))
                {
                    MostrarAulaYaExiste();
                    AgregarAlumnosAulaExiste();
                    existe = true;
                }
                else
                {
                    AgregarAlumnosAulaExiste();
                    existe = true;
                }
                                  
            }
            else
            {
                if ((!existe) && CrearAula()  )
                {

                  AgregarAlumnosAulaExiste();

                }
                else
                {
                    AgregarAlumnosAulaExiste();
                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            if (MessageBox.Show("¿Deseas Salir?", "Abandonando Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

            {
               this.Close();
            }

        }
    }
}
