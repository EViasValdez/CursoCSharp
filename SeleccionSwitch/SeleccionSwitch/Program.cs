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
                    Console.WriteLine("Opción " + Dato);
                break;
                case "Dos":
                    Console.WriteLine("Opción " + Dato);
                break;
                case "Tres":
                    Console.WriteLine("Opción " + Dato);
                break;
                default:
                    Console.WriteLine("No encontrado");
                break;
            }
        }
    }
}