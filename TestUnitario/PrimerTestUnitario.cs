using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesJardin;
using ProyectoJardin;
using System.Windows.Forms;

namespace TestUnitario
{
    [TestClass] //identifica la clase como metodo de test
    public class PrimerTestUnitario

    {
        [TestMethod] //va con cada metodo de test
        [ExpectedException(typeof(PersonaSinDniException))] //espera una excepcion del tipo que creamos

        public void PersonaSinDni()
        {
            Alumno a1 = new Alumno("pepe", "peposo", 0, false, 1200); 

        }

        [TestMethod] 
        public void PersonaDniValido()
        {
            Alumno a1 = new Alumno("pepe", "peposo", 24424242, false, 1200);
            Assert.IsNotNull(a1); 
        }

        [TestMethod] 
        public void ValueTestCargaHardocodeoAlumnos()
        {
            FrmPrincipal menuPrin = new FrmPrincipal(); //crear una instancia del FRMprinc
            menuPrin.HardocodearAlumResponsables();   //hacerle metodo de instancia de ese FRM
            Assert.IsTrue(menuPrin.Alumnos.Count == 54 && menuPrin.Responsable.Count==2);  //solo verifica que no sea null el obj
        }

        [TestMethod] 
        public void ValueTestCargaHardocodeoDocentes()
        {

            FrmPrincipal menuPrin = new FrmPrincipal(); 
            menuPrin.HardcodearDocentes();   

            Assert.IsTrue(menuPrin.Docentes.Count==5); 
        }

        [TestMethod]
        public void CompararIgualdad() //DUDAS SI ESTA BIEN
        {
            FrmPrincipal menuPrin = new FrmPrincipal(); //  ESTO ES EL ARANGE?? crear una instancia del FRMprin
            menuPrin.HardocodearAlumResponsables(); //ESTO ES ACT??  hacerle metodo de instancia de ese FRM
            Assert.IsTrue(!(menuPrin.Alumnos[0] == menuPrin.Alumnos[1]));  //tb puede ser isFalse

        }





    }
}
