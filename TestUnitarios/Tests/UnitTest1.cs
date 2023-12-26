using TestUnitarios;

namespace Tests
{
    [TestClass]
    public class CalculadoraTest
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
    }
}