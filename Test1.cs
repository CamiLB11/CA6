using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmosBusqueda;

namespace AlgoritmosBusquedaTests
{
    [TestClass]
    public class BusquedasTests
    {
        private int[] arreglo;

        [TestInitialize]
        public void Setup()
        {
            arreglo = new int[] { 4, 8, 15, 16, 23, 42, 50, 65, 78, 90 };
        }

        [TestMethod]
        public void BusquedaLineal_ElementoExiste_RetornaIndiceCorrecto()
        {
            int resultado = Busquedas.BusquedaLineal(arreglo, 23);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void BusquedaLineal_ElementoNoExiste_RetornaMenosUno()
        {
            int resultado = Busquedas.BusquedaLineal(arreglo, 100);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoExiste_RetornaIndiceCorrecto()
        {
            int resultado = Busquedas.BusquedaBinaria(arreglo, 42);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoNoExiste_RetornaMenosUno()
        {
            int resultado = Busquedas.BusquedaBinaria(arreglo, 30);
            Assert.AreEqual(-1, resultado);
        }
    }
}
