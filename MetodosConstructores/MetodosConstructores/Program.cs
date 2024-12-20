using System.Text;

namespace MetodosConstructores
{
    class Program
    {
        public Program(String Nombre, int Edad)
        {

        }
        // public Program(String Nombre)
        // {
        //      
        // }
        static void Main()
        {
            var Dato = new Program("Roberto", 20);
            new Program("Roberto", 20);
        }
    }
}