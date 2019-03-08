using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2.Wfc.Dominio.Repositorio.Tests
{
    [TestClass()]
    public class EstacionamientosTests
    {
        [TestMethod()]
        public void EstacionamientosTest()
        {
            //Arrange
            var unitTest = new WfcTests.EstacionamientosService.Service1Client();
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
