namespace SeleccionSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Dato = "Uno";
            switch (Dato)
            {
                case "Uno":
                    Console.WriteLine("Opcion " + Dato);
                break;
                case "Dos":
                    Console.WriteLine("Opcion " + Dato);
                break;
                case "Tres":
                    Console.WriteLine("Opcion " + Dato);
                break;
                default:
                    Console.WriteLine("No encontrado");
                break;
            }
        }
    }
}