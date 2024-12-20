namespace TriangulodePascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pisos = 0;
            int[] Arreglo = new int[1];

            Console.WriteLine("Ingrese numero de pisos");
            Pisos = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= Pisos; i++)
            {
                int[] Pascal = new int[i];

                for (int j = Pisos; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    if (k == 0 || k == (i - 1))
                    {
                        Pascal[k] = 1;
                    }
                    else
                    {
                        Pascal[k] = Arreglo[k] + Arreglo[k - 1];
                    }
                    Console.Write("[" + Pascal[k] + "]");
                }
                Arreglo = Pascal;
                Console.WriteLine();
            }
        }
    }
}