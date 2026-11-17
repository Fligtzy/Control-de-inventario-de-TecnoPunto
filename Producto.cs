namespace gamalier
{
    internal class Producto
    {
        // Campos privados: guardan los datos (no son públicos)
        private string nombre;
        private double precio;
        private int cantidad;

        public string Codigo { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                // El nombre no puede estar vacío
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value;
            }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                // El precio debe ser mayor que 0
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                precio = value;
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                // La cantidad no puede ser negativa
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                cantidad = value;
            }
        }

        // Propiedad de solo lectura: precio por cantidad
        public double ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Constructor: usa las propiedades, así se validan los datos
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Imprime los datos del producto
        public void MostrarInfo()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor total: " + ValorTotal);
        }
    }
}
