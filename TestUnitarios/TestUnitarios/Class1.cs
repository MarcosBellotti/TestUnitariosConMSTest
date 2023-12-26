namespace TestUnitarios
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double AplicarDescuento(double precioBase, double porcentajeDescuento)
        {
            if (precioBase < 0 || porcentajeDescuento < 0 || porcentajeDescuento > 100)
            {
                throw new ArgumentException("Los argumentos no son válidos");
            }

            double descuento = precioBase * (porcentajeDescuento / 100);
            double precioConDescuento = precioBase - descuento;

            return precioConDescuento;
        }

    }
}