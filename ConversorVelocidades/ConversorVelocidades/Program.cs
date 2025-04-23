using System;
using System.Text;

namespace ConversorVelocidades
{
    class Program
    {

        static void Main()
        {
            int Opcion, Repetir = 0;
            var Con = new Conversor();
            
            do
            {
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1 - Convertir m/s a km/h");
                Console.WriteLine("2 - Convertir km/h a m/s");
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Con.Conversor1();
                        break;
                    case 2:
                        Con.Conversor2();
                        break;
                    default:
                        Console.WriteLine("Opción errónea");
                        break;
                }
                Console.WriteLine("Si desea repetir coloque el valor de 1 o cualquier tecla para salir");
                Repetir = Convert.ToInt32(Console.ReadLine());
            } while (Repetir == 1);

        }
        class Conversor
        {

            private double Velocidad;

            public void Conversor1()
            {
                Console.WriteLine("Introduzca una Velocidad en m/s");
                Velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Velocidad} m/s = {Velocidad * 3600 / 1000} km/h");
            }
            public void Conversor2()
            {
                Console.WriteLine("Introduzca una Velocidad en km/h");
                Velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Velocidad} km/h = {Velocidad * 1000 / 3600} m/s");
            }
        }
    }
}