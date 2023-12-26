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

        public double CalcularTotalFactura(List<FacturaItem> items)
        {
            if (items == null || items.Count == 0)
            {
                throw new ArgumentException("La factura debe tener al menos un ítem");
            }

            double total = 0;

            foreach (var item in items)
            {
                if (item.Cantidad < 0 || item.PrecioUnitario < 0)
                {
                    throw new ArgumentException("La cantidad y el precio unitario deben ser valores positivos");
                }

                total += item.Cantidad * item.PrecioUnitario;
            }

            return total;
        }

    }

    public class FacturaItem
    {
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public FacturaItem(string descripcion, int cantidad, double precioUnitario)
        {
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
    }
}