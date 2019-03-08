using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trabajo2_Test
{
    [TestClass()]
    public class EstacionamientosTests
    {
        [TestMethod()]
        public void EstacionamientosTest()
        {
            //Arrange
            var unitTest = new Trabajo2_Test.EstacionamientoServices.Service1Client();
            var provincia = "Guanacaste";
            var cantidadDeRegistrosEsperada = 5;
            var cantidadDeRegistrosReal = 0;
            var elResultado = unitTest.ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(provincia);

            //Action
            if (elResultado != null)
                cantidadDeRegistrosReal = elResultado.Count();
            Console.WriteLine(string.Format("La cantidad de registros consultados es {0}.", elResultado.Count()));

            //Assert
            Assert.IsTrue(cantidadDeRegistrosEsperada == cantidadDeRegistrosReal);
        }

    }
}
