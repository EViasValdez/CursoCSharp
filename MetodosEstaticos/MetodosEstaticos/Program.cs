namespace MetodosEstaticos
{
    class Program
    {
        static void Main()
        {
            var Dato1 = new Conversor();
            var Dato2 = new Conversor();

            Dato1.Conversor2();
            //Dato.Velocidad = 3.0;
            //Conversor.Conversor1();
            //Conversor.Conversor2();
        }
        class Conversor
        {
            public static double Velocidad;

            public void Conversor1()
            {
                Velocidad += 8;
            }
            public void Conversor2()
            {
                Velocidad += 20;
            }
        }
    }
}