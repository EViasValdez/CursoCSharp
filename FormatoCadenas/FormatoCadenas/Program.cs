namespace FormatoCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interpolacion de cadenas.
            var Nombre = (Nombre1: "Arelia", Edad1:20, Nombre2: "Roberto", Edad2:18);

            Console.WriteLine($"Nombre: {Nombre.Nombre1}, Edad: {Nombre.Edad1}");
            Console.WriteLine($"Nombre: {Nombre.Nombre2}, Edad: {Nombre.Edad2}");

            // Formato compuesto.
            Console.WriteLine("Nombres: ", Nombre.Nombre1, Nombre.Nombre2);
        }
    }
}