namespace PalabrasClaves
{
    class Program
    {
        static void Main()
        {
            int Dato = 20;
            new Program().Metodo(out Dato);
            Console.WriteLine(Dato);
        }
        private void Metodo(out int Valor)
        {
            Valor = 40 + 8;
        }
    }
}