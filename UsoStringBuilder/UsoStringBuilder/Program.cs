using System;
using System.Text;

namespace UsoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Nombres = new StringBuilder("Francisco Arevalo");
            // Nombres[0] = a;
            Nombres.Append(" ");
            Nombres.Append("Filberto").Append(" ").Append("Escobar").Append(" ");
            Nombres.AppendFormat("Edad ", 20);
            // Nombres.Capacity = 2;

            Console.WriteLine(Nombres.ToString());
        }
    }
}