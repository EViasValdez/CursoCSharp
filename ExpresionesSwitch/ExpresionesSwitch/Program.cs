namespace ExpresionesSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  var Dato = 4;
            //  var Resultado = Dato switch
            //  {
            //      1 => "Dato 1",
            //      2 => "Dato 2",
            //      3 => "Dato 3",
            //      4 => "Dato 4"
            //  };

            //Console.WriteLine(Resultado);

            var (A, B, Opcion) = (2, 6, "+");
            var Resultado = Opcion switch
            {
                "+" => A == B,
                "-" => A < B,
                "*" => B > A
            };

            Console.Write("Resultado ", Resultado);
        }
    }
}