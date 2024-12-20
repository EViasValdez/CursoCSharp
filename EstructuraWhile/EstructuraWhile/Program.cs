namespace EstructuraWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Valor = true;
            var Count = 1;

            while (Valor)
            {
                if (Count == 6)
                {
                    Valor = false;
                }
                Count++;
                Console.WriteLine(Count);
            }
        }
    }
}