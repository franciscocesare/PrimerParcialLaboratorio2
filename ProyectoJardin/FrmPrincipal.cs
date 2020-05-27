﻿using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WPFCustomMessageBox;
using ProyectoJardin;

namespace ProyectoJardin
{
    public partial class FrmPrincipal : Form
    {
        private List<Alumno> alumnos;
        private List<Docente> docentes;
        private List<Responsable> responsables;
        private List<Administrativo> personal;
        private List<Aula> aulas;
        private Aula aula;

        public int legajo = 100;

        public FrmPrincipal()
        {

            InitializeComponent();

            alumnos = new List<Alumno>();
            docentes = new List<Docente>();
            responsables = new List<Responsable>();
            personal = new List<Administrativo>();
            aulas = new List<Aula>();
            aula = new Aula();



        }

        

        public Aula Aula
        {
            get { return this.aula; }
            set { this.aula = value; }
        }


        public List<Aula> Aulas
        {
            get { return this.aulas; }
            set { this.aulas = value; }
        }

        public List<Administrativo> Personal
        {
            get { return this.personal; }
            set { this.personal = value; }
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Docente> Docentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }

        public List<Responsable> Responsable
        {
            get { return this.responsables; }
            set { this.responsables = value; }
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
        public void HardocodearAlumResponsables()
        {
            //tendria que hardcodear los 50 responsables la yuta madre?
            responsables.Add(new Responsable("Lautaro", "Acosta", 35994837, false, EParentezco.Tio, "1136654545"));
            responsables.Add(new Responsable("Gonzalo", "Bellozo", 31443233, false, EParentezco.Padre, "1132325654"));

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
            alumnos.Add(new Alumno("pipo", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("matias", "davila", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pancho", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "nuna", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("sacha", "lepore", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "fernandez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pepe", "damino", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("lucas", "fernandes", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("keke", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("salome", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("marcelo", "ramirez", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("gonzalo", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("thalia", "bermudez", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("ezequiel", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("joselo", "parci", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "shaki", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("rodrigo", "diaz", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("brian", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("Ximena", "gomez", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("matias", "legrand", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("josete", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("german", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("pancho", "lepere", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("marcelo", "beebebe", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("ellaNunca", "olvida", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("tomas", "lepu", dni.Next(40000000, 50000000), false, 1800));
            alumnos.Add(new Alumno("jose", "benitez", dni.Next(40000000, 50000000), false, 1500));
            alumnos.Add(new Alumno("jimena", "teas", dni.Next(40000000, 50000000), true, 1500));
            alumnos.Add(new Alumno("juan", "lepu", dni.Next(40000000, 50000000), false, 1800));


            for (int i = 0; i < alumnos.Count; i++) //asigno legajo a todos los harcodeados
            {
                alumnos[i].Legajo = legajo;
                alumnos[i].Responsable = responsables[0]; //a todos el mismo responsable, salvo cuando es un ALTA
                legajo++;

            }

        }

        public void HardcodearNoDocentes()
        {
            int horaEntrada = 7;
            int horaSalida = 13;
            DateTime entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            DateTime salida = new DateTime(01, 01, 01, horaSalida, 00, 00);


            personal.Add(new Administrativo("Mariana", "Martinez", 29192329, true, entrada, salida, ECargo.Cocina));
            personal.Add(new Administrativo("Pepe", "Diaznovi", 33434333, false, entrada, salida, ECargo.Portería));
            personal.Add(new Administrativo("Jazmin", "Perere", 35145269, true, entrada, salida, ECargo.Tesorería));
            personal.Add(new Administrativo("Susana", "Mariani", 34992666, true, entrada, salida, ECargo.Secretaría));
            personal.Add(new Administrativo("Estela", "Carrasco", 31554539, true, entrada, salida, ECargo.Secretaría));
            personal.Add(new Administrativo("Marilu", "Martinez", 29192329, true, entrada, salida, ECargo.Cocina));
            personal.Add(new Administrativo("Rodrigo", "Divi", 33434333, false, entrada, salida, ECargo.Portería));
            personal.Add(new Administrativo("Jacinta", "Peamo", 35145998, true, entrada, salida, ECargo.Tesorería));
            personal.Add(new Administrativo("Mariana", "Miani", 34992326, true, entrada, salida, ECargo.Secretaría));
            personal.Add(new Administrativo("Carolina", "Casco", 30339539, true, entrada, salida, ECargo.Secretaría));

        }

        public void HardcodearDocentes()
        {
            int horaEntrada = 7;
            int horaSalida = 13;
            DateTime entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            DateTime salida = new DateTime(01, 01, 01, horaSalida, 00, 00);

            docentes.Add(new Docente("Maria", "Martinez", 29192329, true, entrada, salida, 400));
            docentes.Add(new Docente("Raul", "Diaz", 31195429, false, entrada, salida, 400));
            docentes.Add(new Docente("Jimena", "Perez", 32191269, true, entrada, salida, 400));
            docentes.Add(new Docente("Stella", "Marne", 25191666, true, entrada, salida, 400));
            docentes.Add(new Docente("Stella", "Lurruti", 25191539, true, entrada, salida, 400));
        }

        public void HardocodearAulas()
        {
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


            aulas.Add(aula1);
            aulas.Add(aula2);
            aulas.Add(aula3);

        }

        private void btnLoadPruebas_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav"); sonido.Play();

            this.HardocodearAlumResponsables();
            this.HardcodearDocentes();
            this.HardcodearNoDocentes();
            this.HardocodearAulas();


            if (!(alumnos is null) || responsables is null || docentes is null || aulas is null)
            {
                if (MessageBox.Show("¿Vamos a hacer unas pruebas ahora?", "Hardcodeos de prueba cargados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    btnLoadPruebas.Enabled = false;
                }
                else
                {

                    this.Close();

                }
            }
        }

        #endregion

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPersonal frmAltaDocente = new FrmAltaPersonal();
            frmAltaDocente.Docentes = docentes;
            frmAltaDocente.SetParaDocentes();
            frmAltaDocente.ShowDialog();

            if (frmAltaDocente.DialogResult == DialogResult.OK)
            {
                docentes = frmAltaDocente.Docentes;
            }
            else if (frmAltaDocente.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }
        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPersonal frmAltaNoDocente = new FrmAltaPersonal();
            frmAltaNoDocente.ListaPersonal = personal;
            frmAltaNoDocente.SetParaPersonal();

            frmAltaNoDocente.ShowDialog();
            if (frmAltaNoDocente.DialogResult == DialogResult.OK)
            {
                personal = frmAltaNoDocente.ListaPersonal;
            }
            else if (frmAltaNoDocente.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }

        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAlumno = new FrmAltaAlumno();
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                frmAlumno.Alumno.Legajo = legajo++;
                this.alumnos.Add(frmAlumno.Alumno);
                this.responsables.Add(frmAlumno.Alumno.Responsable);

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
            if (frmAula.DialogResult == DialogResult.OK)
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
            if (MessageBox.Show("¿Salir del Sistema?", "Chau Pichoncitos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("no te vayas aun, vamos a dar algun alta");

            }

        }

        private void informacionPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
            lstBoxPrincipal.Visible = true;


            for (int i = 0; i < responsables.Count; i++)
            {
                lstBoxPrincipal.Items.Add(responsables[i].ToString());
            }
            // lstBoxPrincipal.SelectedItem


        }

        private void verAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBoxPrincipal.Visible = true;

            lstBoxPrincipal.Items.Clear();

            for (int i = 0; i < aulas.Count; i++)
            {
                lstBoxPrincipal.Items.Add($"Aula: {aulas[i].ColorSala}Docente: {aulas[i].Docente.Apellido}, {aulas[i].Docente.Nombre}Turno: {aulas[i].Turno}");

                foreach (Alumno item in aulas[i].Alumnos)
                {

                    lstBoxPrincipal.Items.Add($"{item.Apellido},{item.Nombre}, {item.Legajo}");

                }

            }
        }

        private void CalcularSueldosDocentes()
        {
            double sueldoTotalDocente=0;
            double sueldoDeUne;

            for (int i = 0; i < docentes.Count; i++)
            {
                sueldoDeUne = docentes[i].CalcularSalario();
                sueldoTotalDocente += sueldoDeUne; 

            }
            
            MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
            lstBoxPrincipal.Visible = true;
            lstBoxPrincipal.Items.Add("La suma de los Salarios Docentes fue de $" + sueldoTotalDocente.ToString());

        }

        private void CalcularSueldosNODocentes()
        {
            double sueldoTotalNODocente = 0;
            double sueldoDeUne;

            for (int i = 0; i < personal.Count; i++)
            {
                sueldoDeUne = personal[i].CalcularSalario();
                sueldoTotalNODocente += sueldoDeUne;

            }

            MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
            lstBoxPrincipal.Visible = true;
            lstBoxPrincipal.Items.Add("La suma de los Salarios Administrativos fue de $ " + sueldoTotalNODocente.ToString());

        }
        /*
         for (int i = 0; i < aulas.Count; i++)
            {
                lstBoxPrincipal.Items.Add($"Aula: {aulas[i].ColorSala}Docente: {aulas[i].Docente.Apellido}, {aulas[i].Docente.Nombre}Turno: {aulas[i].Turno}");

                foreach (Alumno item in aulas[i].Alumnos)
                {

                    lstBoxPrincipal.Items.Add($"{item.Apellido},{item.Nombre}, {item.Legajo}");
                }
            }
         **/
        private void CalcularRecaudacionPorAula()
        {
            float recaudacionPorAula = 0;
          

            if (aulas.Count>0)
            {
                for (int i = 0; i < aulas.Count; i++)
                {
                    for (int j = 0; j < aulas[i].Alumnos.Count; j++)
                    {
                        recaudacionPorAula += aulas[i].Alumnos[j].PrecioCuota;
                        
                    }

                   lstBoxPrincipal.Items.Add($"La recaudacion de la salita {aulas[i].ColorSala},{aulas[i].Docente},{aulas[i].Turno} fue de {recaudacionPorAula.ToString()}");
                   recaudacionPorAula = 0;
                }
                MessageBox.Show("Despues de revisar,\nDoble click para cerrar la lista");
                lstBoxPrincipal.Visible = true;
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
            lstBoxPrincipal.Visible = true;
            //  lstBoxPrincipal.Items.Clear();
            lstBoxPrincipal.Items.Add("La recaudacion total fue de $" + recaudacion.ToString());
        }

        private void lstBoxPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Cerrando la lista");
            lstBoxPrincipal.Items.Clear();
            lstBoxPrincipal.Visible = false;
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CalcularSueldosDocentes();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CalcularSueldosNODocentes();
        }

        private void recaudacionPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CalcularRecaudacionPorAula();
        }
    }
}
