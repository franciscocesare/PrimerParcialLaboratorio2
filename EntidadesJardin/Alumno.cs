using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class Alumno : Persona
    {
        private Ecolores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;




        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota) : base(nombre: nombre, apellido: apellido, dni: dni, femenino: femenino)
        {
            // this.colorSala = colorSala;
            //this.legajo = legajo;
            this.precioCuota = precioCuota;
            //this.responsable = responsable;
            
        }

        public float PrecioCuota
        {
            get { return precioCuota; }
            set { precioCuota = value; }
        }


        public Ecolores ColorSala
        {
            get { return colorSala; }
            set { colorSala = value; }
        }


        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public Responsable Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        //Dos Alumnos son iguales si comparten legajo y al castearlo a Responsable, devuelve a su Responsable
        public static bool operator ==(Alumno alum1, Alumno alum2)
        {
            if (!(alum1 is null))
            {                                                                                           //muchas dudas si esto es lo de castear
                return alum1.legajo == alum2.legajo && (Responsable)alum1 == (Responsable)alum2; //&& Responsable.ALGO ACA NO CIERRA
            }

            return false;
        }


        public static bool operator !=(Alumno alum1, Alumno alum2)
        {

            return !(alum1 == alum2);
        }

        public static implicit operator Responsable(Alumno alumno)
        {

            return alumno.responsable;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Legajo: {this.legajo}");
            //sb.AppendLine($"{this.Responsable}");
           // sb.AppendLine("Valor Cuota: " + this.precioCuota);


            return sb.ToString();
        }

       

    }
}
