namespace ModificadorPublic
{
    class Program
    {
        static void Main()
        {
            var Dato = new Program();
            var Nombre = Dato.MetodoPublico();
            // Dato.MetodoPublico();

            Console.WriteLine(Dato.MetodoPublico());
            Console.ReadLine();
        }
        private string MetodoPublico()
        {
            return $"Ramirez {12}";
        }
    }
}
