namespace ArrayMultidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] Dobles1 = new double[2, 2] { { 6, 3.0 }, { 6.1, 3.0 } };
            Console.WriteLine(Dobles1[1, 0]);

            double[,,] Dobles2 = new double[2, 2, 3] { { { 3.0, 6.9, 8.9 }, { 6.8, 4.5, 7.6 } }, { { 6.0, 6.8, 2.9 }, { 3.8, 4.5, 10.6 } } };
            Console.WriteLine("Resultado {0}", Dobles2[0, 1, 2]);
        }
    }
}