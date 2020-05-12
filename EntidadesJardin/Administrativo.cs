using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    /*
     *Administrativo: Cuenta con un atributo estático SalarioBase. 
     
     * Tambien tiene un constructor estatico que setea el salarioBase = 30000 y
     * uno de instancia por el cual se cargan todos los atributos que tiene un administrativo
     */
      public class Administrativo : Personal
    {
         private ECargo cargo;
         static double salarioBase;

        static Administrativo()
        {
            salarioBase = 30000; //Ctor estatico que setea salario en 30000
        }

        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.cargo = cargo;
            
        }



        /// <summary>
        /// override ToString para cada entidad calcular su salario
        /// </summary>
        /// <returns></returns> el calcular salario de cada entidad
        public override double CalcularSalario()
        {
            return salarioBase * (double)cargo/100;
        }

        /// <summary>
		/// override ToString para cada entidad mostrar su datos
		/// </summary>de la base trae atributos de personal
		/// <returns></returns> los datos de Administrativo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Salario: {this.CalcularSalario()}");
            sb.AppendLine($"cargo:  {this.cargo}");


            return sb.ToString();
        }
    }
}
