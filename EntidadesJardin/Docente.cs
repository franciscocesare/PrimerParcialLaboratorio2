using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class Docente : Personal
    {
        private double valorHora;


		public double ValorHora
		{
			get { return this.valorHora; }
			set { this.valorHora = value; }
		}

		//Redefine CalcularSalario multiplicando el valorHora por la cantidad de horas diarias por 20 días hábiles
		//Y un constructor publico que carga todos sus atributos

		public int HorasMensuales
		{
			get 
			{

				double horasDiarias;
				horasDiarias = HoraSalida.Subtract(HoraEntrada).TotalHours;
				return (int)horasDiarias * 20;
			}
		}

		public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
		{
			this.valorHora = valorHora;
			this.HoraEntrada = horaEntrada;
			this.HoraSalida = horaSalida;
		}



		/// <summary>
		/// override ToString para cada entidad calcular su salario
		/// </summary>
		/// <returns></returns> el calcular salario de cada entidad
		public override double CalcularSalario()
		{
			//HoraEntrada = DateTime.Now.AddHours(0600);
			//HoraSalida = new DateTime();


			return this.valorHora *HorasMensuales;
		}

		/// <summary>
		/// override ToString para cada entidad mostrar su datos
		/// </summary>de la base trae atributos de personal
		/// <returns></returns> los datos de Docente
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.Nombre.ToString());
			sb.AppendLine(", ");
			sb.AppendLine(base.Apellido.ToString());

			//sb.AppendLine($"Entra: {this.HoraEntrada} y se retira: {this.HoraSalida}");
			//sb.AppendLine($"El valor de la hora {this.ValorHora}");


			return sb.ToString();
		}




	}
}
