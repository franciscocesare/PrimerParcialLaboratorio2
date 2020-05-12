using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //protected string _legajo;
 //protected EPuestoJerarquico _puesto;
 //protected int _salario;

 //public Empleado(Persona persona, string legajo, EPuestoJerarquico puesto, int salario)
 //	: this(persona.Nombre, persona.Apellido, legajo, puesto, salario)
 //{
 //}

 //public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
 //	: base(nombre, apellido)
 //{
 //	this._legajo = legajo;
 //	this._puesto = puesto;
 //	this._salario = salario;
 //}

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
