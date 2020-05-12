using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class Aula
    {
        private List<Alumno> alumnos;
        private Ecolores colorSala;
        private Docente docente;
        private ETurno turno;

        public Aula()
        {
            
            alumnos = new List<Alumno>(); 


        }


        public Aula(Ecolores colorSala, Docente docente, ETurno turno):this()
        {
            this.colorSala = colorSala;
            this.docente = docente;
            this.turno = turno;
        }


        //PROPIEDADES
        public List<Alumno> Alumnos
        {
            get ///MUCHAS DUDAS DE ESTO
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Ecolores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }


        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }

        public ETurno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El aula {this.ColorSala}");
            sb.AppendLine($" {this.Docente}");
            sb.AppendLine($" {this.Alumnos}");

            return sb.ToString();
        }


        public static bool operator + (Aula aula, Alumno alumno)
        {

            for (int i = 0; i < aula.alumnos.Count; i++)
            {
                if (aula.alumnos[i] == alumno) //si existe, true
                    return false;
            }
            if (aula.alumnos.Count <= 30)
            {
                aula.alumnos.Add(alumno);   //la agrego directamenteeee
                return true;
            }
            return false;
        }
        





    }
}
