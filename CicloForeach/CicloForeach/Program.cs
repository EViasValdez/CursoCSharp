namespace CicloForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = { "Jorge", "Elias", "Sergio" };
            int[] Edad = { 10, 14, 20 };

            for (int i = 0; i < Nombre.Length; i++) 
            {
                Console.WriteLine("Resultado {0}", Nombre[i] + ", Edad " + Edad[i]);
            }

            Console.WriteLine("======================================================================");

            foreach (var Objeto in Nombre)
            {
                Console.WriteLine("Resultado {0}", Objeto);
            }
        }
    }
}