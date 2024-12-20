namespace FuncionesStatic
{
    class Program
    {
        static void Main()
        {
            int Dato = 20;
            String Nombre;
            new Program().Metodo(out Dato);

            void Mensaje() => Nombre = "Ramiro";
            Mensaje();
        }
        private void Metodo(out int Valor)
        {
            Valor = Funcion();

            static int Funcion() => 40 + 8;
        }
    }
}