using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public enum ETipoForm
    {
        AltaDocente,
        AltaNoDocente,
        AltaAlumno,
        AltaResponsable
    }

    public enum Ecolores
    {
        Naranja,
        Rojo,
        Amarillo,
        Verde

    }

    public enum ETurno
    {
        Mañana,
        Tarde
    }

    public enum EParentezco
    {
        Madre,
        Padre,
        Tia,
        Tio,
        Abuela,
        Abuelo,
        Otro
    }

    public enum ECargo
    {
        Portería = 100,
        Cocina = 110,
        Secretaría = 140,
        Tesorería = 240,
        Dirección = 180

    }


}
