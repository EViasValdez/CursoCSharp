namespace EstructuraIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor1 = 2;
            int Valor2 = 8;
            double Valor3 = 2;
            double Valor4 = 4;
            string Nombre;
            var Data = Valor1 != Valor2;

            if (Data)
            {
                Nombre = "Alex";
            }
            else
            {
                Nombre = "Natalia";
            }
            Nombre = Data ? "Alex" : "Natalia";

            Console.WriteLine("Resultado {0}", Nombre);
        }
    }
}