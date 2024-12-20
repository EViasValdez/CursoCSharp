namespace EstructuraDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Valor = true;
            var Count = 1;

            while (Valor)
            {
                if (Count == 8)
                {
                    Valor = false;
                }
                Count++;
                Console.WriteLine(Count);
            }

            Console.WriteLine("===========");

            Count = 0;
            Valor = true;
            do
            {
                if (Count == 8)
                {
                    Valor = false;
                }
                Count++;
                Console.Write(Count);
            } while (Valor);
        }
    }
}
