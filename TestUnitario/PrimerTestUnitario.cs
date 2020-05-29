using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesJardin;
using ProyectoJardin;
using System.Windows.Forms;

namespace TestUnitario  //tiene que servir para revisar las malas validaciones
{
    [TestClass] //identifica la clase como metodo de test
    public class PrimerTestUnitario

    {
        [TestMethod] //va con cada metodo de test
        [ExpectedException(typeof(PersonaSinDniException))] //espera una excepcion del tipo que creamos

        public void PersonaSinDni()
        {

            Alumno a1 = new Alumno("pepe", "peposo", 0, false, 1200);
            this.CompararIgualdad();
        }

        [TestMethod] 
        public void PersonaDniValido()
        {
            Alumno a1 = new Alumno("pepe", "peposo", 24424242, false, 1200);
            Assert.IsNotNull(a1); 
        }

        [TestMethod] 
        public void TestCargaHardocodeoAlumnos()
        {
            FrmPrincipal menuPrin = new FrmPrincipal(); //crear una instancia del FRMprinc
            menuPrin.HardocodearAlumResponsables();   //hacerle metodo de instancia de ese FRM
            Assert.IsTrue(menuPrin.Alumnos.Count == 54 && menuPrin.Responsable.Count==2);  //ver si es cierto que alumno0s=54 y resp =2
        }

        [TestMethod]
        public void TestCargaHardocodeoAulas()  //para el hardcodeo de aulas preciso hardcodear tb alumnos y docentes
        {

            FrmPrincipal menuPrin = new FrmPrincipal();
            menuPrin.HardcodearDocentes();
            menuPrin.HardocodearAlumResponsables();
            menuPrin.HardocodearAulas();

            Assert.IsTrue(menuPrin.Aulas.Count == 3);
        }

        [TestMethod] 
        public void TestCargaHardocodeoDocentes()
        {

            FrmPrincipal menuPrin = new FrmPrincipal(); 
            menuPrin.HardcodearDocentes();   

            Assert.IsTrue(menuPrin.Docentes.Count==5); 
        }

        [TestMethod]
        public void TestCargaHardocodeoNoDocentes()
        {

            FrmPrincipal menuPrin = new FrmPrincipal();
            menuPrin.HardcodearNoDocentes();

            Assert.IsTrue(menuPrin.Personal.Count == 10);
        }



        [TestMethod]
        public void CompararIgualdad() //DUDAS SI ESTA BIEN
        {
            FrmPrincipal menuPrin = new FrmPrincipal(); //  ESTO ES EL ARANGE?? crear una instancia del FRMprin
            menuPrin.HardocodearAlumResponsables(); //ESTO ES ACT??  hacerle metodo de instancia de ese FRM
            Assert.IsFalse(menuPrin.Alumnos[0] == menuPrin.Alumnos[1]);  //tb puede ser isFalse

        }

        /*
         * tiene que haber test de alta alumno, alta responsable, que ande el mas y el ==
         * hacer una verificacion con carga de alumno
         */
        [TestMethod]
        public void ValidarCargaConResponsable()
        {
            FrmAltaAlumno altaAlumno = new FrmAltaAlumno();
           
            if(altaAlumno.ValidarCargasHechas()=="Ok");   //yo tengo que probar las validaciones de lo que hay dentro de este metodo, van a ser muchas

            //aca hardcodear para comprobar esas cargas 
            {
                Assert.IsNull(altaAlumno.Alumno);
            }  //hacer un alumno nuevo sin resp por ej
        }

        [TestMethod]
        public void TestIgualacion()
        {

            FrmPrincipal menuPrin = new FrmPrincipal();
            menuPrin.HardcodearNoDocentes();
           
            Assert.IsTrue(menuPrin.Personal.Count == 10);
        }




    }
}
