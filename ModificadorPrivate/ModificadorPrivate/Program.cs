namespace ModificadorPrivate
{
    class Program
    {
        static void Main()
        {
            var Dato = new Program();
            Dato.MetodoPrivado();
        }
        private void MetodoPrivado()
        {
            Console.WriteLine("Metodo privado");
            Console.ReadLine();
        }
    }
}