using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enteros
            int Numero1 = 2;
            int Numero2 = Convert.ToInt16("4");
            Console.WriteLine(Numero1);
            Console.WriteLine(Numero2);

            // Cadena
            String Cadena = "as";
            Console.WriteLine(Cadena);

            // Double
            double Doble = 2.0;
            Console.WriteLine(Doble);

            // Decimal
            decimal Decimal = 4.0M;
            Console.WriteLine(Decimal);

            // Boolean
            bool Booleano = true;
            Console.WriteLine(Booleano);

            // Char
            char Letra = 'A';
            Console.WriteLine(Letra);
        }
    }
}