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
    public partial class FrmPrincipal : Form
    {
        private List<Alumno> alumnos;
        private List<Docente> docentes;
        private List<Administrativo> administrativos;
        private List<Responsable> responsables;
        private List<Personal> personal;
        private List <Aula> aulas;
        private Aula aula;

        public int legajo=100;

        public FrmPrincipal()
        {

            InitializeComponent();

            alumnos = new List<Alumno>();
            docentes = new List<Docente>();
            administrativos = new List<Administrativo>();
            responsables = new List<Responsable>();
            personal = new List<Personal>();
            aulas = new List<Aula>();
            //aula = new Aula();
            

        }

      

        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; //este va a ser contenedor de Login
            Form frmLogin = new Form();
            frmLogin.MdiParent = this; //Princ va a ser el padre
            lstBoxPrincipal.Visible = false;       
                              //  frmLogin.Show();
        }

        #region hardcodeos de datos!

        private void btnLoadPruebas_Click(object sender, EventArgs e)
        {
            Random dni = new Random();

            alumnos.Add(new Alumno("emilio", "baez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pablo", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("juana", "lele", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("rodrigo", "bolm", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("soledad", "gonzalez", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("frani", "vermu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("gonza", "benibeo", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("florencia", "teneri", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("juan", "lalerme", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "balome", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("marcela", "skaska", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("matias", "davila", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "nuna", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("sacha", "lepore", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "fernandez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "fernandes", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("keke", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("salome", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("marcelo", "ramirez", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("thalia", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "parci", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "shaki", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("rodrigo", "diaz", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("Ximena", "gomez", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("matias", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("german", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("marcelo", "beebebe", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("ellaNunca", "olvida", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "lepu", dni.Next(40000000, 50000000), false, 1800));


            for (int i = 0; i < alumnos.Count; i++) //asigno legajo a todos los harcodeados
            {
                alumnos[i].Legajo = legajo;
                legajo++;

            }

            //terminar los datetime para calcular los salarios
            DateTime miDia = Convert.ToDateTime("07:30 AM");   //ver de armar un date.now, 
            miDia = miDia.AddHours(5);   //le mandas las horas que queres sumar para el horario de salida, podes hacer.addminutes



            //tendria que hardcodear los 50 responsables la yuta madre
            responsables.Add(new Responsable("Lautaro", "Acosta", 35994837, false, EParentezco.Tio, "1136654545"));
            responsables.Add(new Responsable("Gonzalo", "Bellozo", 31443233, false, EParentezco.Padre, "1132325654"));


            docentes.Add(new Docente("Maria", "Martinez", 29192329, true, Convert.ToDateTime("01/03/2019 07:30 AM"), Convert.ToDateTime("01/03/2019 12:30 PM"), 400));
            docentes.Add(new Docente("Raul", "Diaz", 31195429, true, Convert.ToDateTime("01/03/2019 07:30 AM"), Convert.ToDateTime("01/03/2019 12:30 PM"), 400));
            docentes.Add(new Docente("Jimena", "Perez", 32191269, true, Convert.ToDateTime("01/03/2019 07:30 AM"), Convert.ToDateTime("01/03/2019 12:30 PM"), 400));
            docentes.Add(new Docente("Stella", "Marne", 25191666, true, Convert.ToDateTime("01/03/2019 07:30 AM"), Convert.ToDateTime("01/03/2019 12:30 PM"), 400));
            docentes.Add(new Docente("Stella", "Lurruti", 25191539, true, Convert.ToDateTime("01/03/2019 07:30 AM"), Convert.ToDateTime("01/03/2019 12:30 PM"), 400));

           Aula aula1 = new Aula(Ecolores.Verde, docentes[3], ETurno.Tarde);  //creo el aula, sumo alumnos y los elimino de la otra lista
            aula1.Alumnos.Add(alumnos[0]);
            aula1.Alumnos.Add(alumnos[1]);
            aula1.Alumnos.Add(alumnos[2]);
            aula1.Alumnos.Add(alumnos[3]);
            alumnos.Remove(alumnos[0]);
            alumnos.Remove(alumnos[1]);
            alumnos.Remove(alumnos[2]);
            alumnos.Remove(alumnos[3]);


            Aula aula2 = new Aula(Ecolores.Amarillo, docentes[2], ETurno.Tarde);

            aula2.Alumnos.Add(alumnos[4]);
            aula2.Alumnos.Add(alumnos[5]);
            aula2.Alumnos.Add(alumnos[6]);
            alumnos.Remove(alumnos[4]);
            alumnos.Remove(alumnos[5]);
            alumnos.Remove(alumnos[6]);

            Aula aula3 = new Aula(Ecolores.Rojo, docentes[1], ETurno.Mañana);

            aula3.Alumnos.Add(alumnos[7]);
            aula3.Alumnos.Add(alumnos[8]);
            aula3.Alumnos.Add(alumnos[9]);
            alumnos.Remove(alumnos[7]);
            alumnos.Remove(alumnos[8]);
            alumnos.Remove(alumnos[9]);


            aulas.Add(aula1);  ///ver aca si esta bien??
            aulas.Add(aula2);
            aulas.Add(aula3);


            if (!(alumnos is null) || responsables is null || docentes is null || aulas is null)
            {
                MessageBox.Show("Hardcodeos de prueba cargados!");
                btnLoadPruebas.Enabled = false;
            }
        }

        #endregion

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPersonal frmAltaDocente = new FrmAltaPersonal();
            frmAltaDocente.ShowDialog();
            

        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAlumno = new FrmAltaAlumno();
            frmAlumno.ShowDialog();
         
            if (frmAlumno.DialogResult == DialogResult.OK) 
            {
                frmAlumno.Alumno.Legajo = legajo++;
                this.alumnos.Add(frmAlumno.Alumno); 
            }
            else if (frmAlumno.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }
        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmAltaAula frmAula = new FrmAltaAula();  //accedo con las propiedades hechas en el otro form!
            frmAula.ListaDocentes = docentes;
            frmAula.ListaAlumnos = alumnos;
            frmAula.ListaAulas = aulas;
            
            frmAula.ShowDialog();
             if (frmAula.DialogResult== DialogResult.OK)
            {
                docentes = frmAula.ListaDocentes; //this.aulas.Add(frmAula.Aula);
                alumnos = frmAula.ListaAlumnos;
                aulas = frmAula.ListaAulas;
            }

            else if (frmAula.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

        private void informacionPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
            lstBoxPrincipal.Visible = true;

            for (int i = 0; i < responsables.Count; i++)
            {
                lstBoxPrincipal.Text += responsables[i].ToString();
                                                                 
            }
            

        }


        private void lstBoxPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxPrincipal.Visible = false;
        }


        private void verAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             lstBoxPrincipal.Visible = true;

            lstBoxPrincipal.Items.Clear();

            for (int i = 0; i < aulas.Count; i++)
            {
                lstBoxPrincipal.Items.Add(aulas[i].ToString());
            }
        }


        private void recaudacionJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int recaudacion = 0;
            int valorCuota;

            for (int i = 0; i < aulas.Count; i++)
            {
                for (int j = 0; j < aulas[i].Alumnos.Count; j++)
                {
                    valorCuota = (int)aulas[i].Alumnos[j].PrecioCuota;
                    recaudacion = valorCuota + recaudacion;
                }
            }

            MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
            lstBoxPrincipal.Visible = true;   // MessageBox.Show("La recaudacion total fue de $" + acumulador.ToString());
            lstBoxPrincipal.Items.Add("La recaudacion total fue de $" + recaudacion.ToString());
        }
    }
}
