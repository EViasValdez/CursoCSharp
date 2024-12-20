namespace ParametrosMetodos
{
    class Program
    {
        static void Main()
        {
            int Edad = 20;
            int Dato = 8;
            new Program().Metodo(Dato);
        }
        private void Metodo(in int Valor)
        {
            // Valor = 40;
            Console.WriteLine(Valor);
        }
    }
}