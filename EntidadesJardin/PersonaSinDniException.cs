using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class PersonaSinDniException : Exception
    {


        public PersonaSinDniException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public PersonaSinDniException(string message)
            :base(message)
        {

        }


    }
}
