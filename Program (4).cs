namespace gamalier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Inventario TecnoPunto ===");

     
            for (int i = 1; i <= 3; i++)
            {
                bool registrado = false;

                while (!registrado)
                {
                    try
                    {
                        Console.WriteLine("\nProducto " + i);
                        Console.Write("Código: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio: ");
                        double precio = double.Parse(Console.ReadLine());
                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                       
                        Producto producto = new Producto(codigo, nombre, precio, cantidad);

                        Console.WriteLine("\n--- Producto registrado ---");
                        producto.MostrarInfo();
                        registrado = true;
                    }
                    catch (ArgumentException ex)
                    {
                      
                        Console.WriteLine("Error: " + ex.Message + " Intente de nuevo.");
                    }
                    catch (FormatException)
                    {
                       
                        Console.WriteLine("Error: escriba un número válido. Intente de nuevo.");
                    }
                }
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}
