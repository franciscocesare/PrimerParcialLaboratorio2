using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class Responsable : Persona
    {
        private EParentezco parentezco;
        private string telefono;

        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentezco parentezco, string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.parentezco = parentezco;
            this.telefono = telefono;
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public EParentezco Parentezco
        {
            get { return this.parentezco; }
            set { this.parentezco = value; }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Apellido.ToString()+""+ base.Nombre.ToString());
            sb.AppendLine($" {this.parentezco}");
            sb.AppendLine($" Tel: {this.telefono}");


            return sb.ToString();
        }

       

    }
}
