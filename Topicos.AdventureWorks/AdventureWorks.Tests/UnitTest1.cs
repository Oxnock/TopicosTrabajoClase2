using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var elClienteWcf = new SI.Products.AdventureWorksProductsClient();

            decimal y = 40;
            decimal x = 10;
            var cantidadDeRegistrosEsperada = 30;
            var cantidadDeRegistrosReal = 0;
            var elResultado = elClienteWcf.ListarProductosPorRangoDePrecio(x, y);
            if (elResultado != null)
                cantidadDeRegistrosReal = elResultado.Count;
            Console.WriteLine(string.Format ("La cantidad de registros consultados es {0}.", elResultado.Count));
            //Console.ReadLine();
            Assert.IsTrue(cantidadDeRegistrosEsperada == cantidadDeRegistrosReal);
        }
    }
}
