using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private bool femenino;

        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;

        }

        protected Persona(string nombre, string apellido, int dni, bool femenino) : this(nombre, apellido, dni)
        {

            this.femenino = femenino;

        }





        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }



        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        public bool Femenino
        {
            get
            {
                return femenino;
            }
            set
            {
                femenino = value;
            }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} ");
            sb.AppendLine($"{this.Apellido}");
            sb.AppendLine($" Dni: {this.Dni} ");
            if (this.femenino)
            {
                sb.AppendLine(" Femenino ");
            }
            else
            {
                sb.AppendLine(" Masculino ");
            }
            
            return sb.ToString();
        }


        public static bool ValidarCargaEnteroForms(string s, int max, int min)
        {
            return int.TryParse(s, out int numeroARetornar) && numeroARetornar > min && numeroARetornar < max;
        }

        public static bool ValidarCargaStringForms(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }






    }
}
