using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace EntidadesJardin
{
    public abstract class Personal:Persona
    {
		
		private DateTime horaEntrada;
		private DateTime horaSalida;

		protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(nombre, apellido, dni, femenino)
		{

			 this.horaEntrada = horaEntrada;
			 this.horaSalida = horaSalida;

		}

		public DateTime HoraSalida
		{
			get { return horaSalida; }
			set { horaSalida = value; }
		}

		public DateTime  HoraEntrada
		{
			get { return horaEntrada; }
			set { horaEntrada = value; }
		}

		public double Salario
		{
			get { return this.CalcularSalario(); }
		}

		public abstract double CalcularSalario();

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.ToString());
			sb.AppendLine($"Entra: {this.horaEntrada} y Sale:{this.horaSalida}");
			sb.AppendLine($"{this.CalcularSalario()}");

			return sb.ToString();
		}




	}
}
