using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabDos.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private int elResultadoCount;

        [TestMethod]
        public void TestMethod1()
        {
            var elClienteWcf = new SI.Estacionamiento.LabDos(); //Cambiar

            string FechaIngreso = "2006-03-04 10:48:15.000";
            string FechaSalida = "2007-02-05 12:17:46.000";

            var cantidadDeRegistrosEsperada = 2306;
            var cantidadDeRegistrosReal = 0;
            var elResultado = elClienteWcf.ListarEstacionamientoPorFecha(FechaIngreso, FechaSalida);
            if (elResultado != null)
                cantidadDeRegistrosReal = elResultadoCount;
            Console.WriteLine(string.Format("La cantidad de registros consultados es {0}.", elResultadoCount));
            Console.ReadLine();
            Assert.IsTrue(cantidadDeRegistrosEsperada == cantidadDeRegistrosReal);
        }
    }
}
