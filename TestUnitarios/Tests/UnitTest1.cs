using TestUnitarios;

namespace Tests
{
    [TestClass]
    public class CalculadoraSumaTest
    {
        [TestMethod]
        public void Sumar_DeberiaDevolverLaSuma()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Sumar(3, 4);

            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        public void Sumar_CuandoSeSumaCero_DeberiaDevolverElMismoNumero()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Sumar(42, 0);

            Assert.AreEqual(42, resultado);
        }

        [TestMethod]
        public void Sumar_CuandoSeSumaNumerosNegativos_DeberiaDevolverLaSumaCorrecta()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Sumar(-5, -7);

            Assert.AreEqual(-12, resultado);
        }

    }

    [TestClass]
    public class CalculadoraDescuentoTest
    {

        [TestMethod]
        public void Descuento_DeberiaDescontarCorrectamente()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(100, 7);

            Assert.AreEqual(93, resultado);
        }

        [TestMethod]
        public void Descuento_CuandoElPrecioBaseEsCero_DeberiaDevolverCero()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(0, 7);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Descuento_CuandoElDescuentoEsCien_DeberiaDevolverCero()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(574, 100);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Descuento_CuandoElDescuentoEsNegativo_DeberiaLanzarExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(22, -80);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Descuento_CuandoElDescuentoEsMayorACien_DeberiaLanzarExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(100, 185);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Descuento_CuandoElPrcioBaseEsNegativo_DeberiaLanzarExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.AplicarDescuento(-100, 185);
        }
    }

    [TestClass]
    public class CalculadoraFacturaTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factura_CantidadDeItemNegativa_DeberiaDevolverExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.CalcularTotalFactura(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factura_PrecioNegativoDeItem_DeberiaDevolverExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            List<FacturaItem> facturaItems = new List<FacturaItem>() { new FacturaItem("Item", 1, -20) };

            double resultado = calculadora.CalcularTotalFactura(facturaItems);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factura_CantidadNegativaDeItem_DeberiaDevolverExcepcion()
        {
            Calculadora calculadora = new Calculadora();

            List<FacturaItem> facturaItems = new List<FacturaItem>() { new FacturaItem("Item", -4, 20) };

            double resultado = calculadora.CalcularTotalFactura(facturaItems);
        }

        [TestMethod]
        public void Factura_CalculoCorrecto()
        {
            Calculadora calculadora = new Calculadora();

            List<FacturaItem> facturaItems = new List<FacturaItem>() { 
                new FacturaItem("Item1", 1, 20),
                new FacturaItem("Item2", 2, 10),
                new FacturaItem("Item3", 4, 5)
            };

            double resultado = calculadora.CalcularTotalFactura(facturaItems);

            Assert.AreEqual(60, resultado);
        }
    }
}