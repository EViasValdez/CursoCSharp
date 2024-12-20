namespace ArgumentosOpcionales
{
    internal class Program
    {
        // Argumentos opcionales.
        // static void Main(string[] args)
        // {
        //     var Data = new Program();
        //     Data.Metodo("C#", "Alex", 52);
        // }
        // private void Metodo(String Curso, String Nombre = "Gabriel", int Cantidad = 20)
        // {
        //     Console.WriteLine(Cantidad);
        // }

        // static void Main(string[] args)
        // {
        //     var Data = new Program();
        //     Data.Metodo(null, null);
        // }
        // private void Metodo(String Curso, int? Cantidad, String Nombre = "Gabriel")
        // {
        //     Console.WriteLine($"{Curso} {Cantidad}");
        // }

        readonly int Valor1;
        const int Valor2 = 98;

        public Program() {
            Valor1 = 10;
        }
        static void Main(string[] args)
        {
            var Data = new Program();
            Console.WriteLine($"{Data.Valor1}");
        }
    }
}