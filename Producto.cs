namespace gamalier
{
    internal class Producto
    {
       
        private string nombre;
        private double precio;
        private int cantidad;

        public string Codigo { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set
            {
              
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
           
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                cantidad = value;
            }
        }

       
        public double ValorTotal
        {
            get { return Precio * Cantidad; }
        }


        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

      
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
