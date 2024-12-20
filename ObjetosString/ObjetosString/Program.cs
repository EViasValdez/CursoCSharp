namespace ObjetosString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre1 = "Arelia";
            string Nombre2 = "Roberto";
            string Nombre3 = Nombre2;

            Nombre1 += Nombre2;
            Console.WriteLine("Nombre: ", Nombre1);

            Console.WriteLine("=====================================");

            var Texto = "Prueba realizada para el curso de .Net";
            // var Textos = "Prueba realizada para el curso de .Net";
            // var Sub = Texto.Remove(5, 11);

            // Console.WriteLine("Cadena: ", Texto.Substring(9, 11));
            // Console.WriteLine(Sub);

            // var Datos = Texto.Equals(Textos);
            // Console.WriteLine(Datos);
            foreach (var item in Texto)
            {
                Console.WriteLine(item);
            }
        }
    }
}