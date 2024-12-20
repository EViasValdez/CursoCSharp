namespace VariablesEstaticas
{
    class Program
    {
        static void Main()
        {
            var Dato = new Conversor();
            var Dato2 = new Conversor();
            Dato.Velocidad = 3.0;
        }
        class Conversor
        {
            public double Velocidad;
        }
    }
}