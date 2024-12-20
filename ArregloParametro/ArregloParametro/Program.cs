namespace ArregloParametro
{
    class Program
    {
        static void Main()
        {
            Object[] Parametros = { "Dario", 20, true };
            new Program().Metodo(Parametros);
        }
        private void Metodo(Object[] Parametros)
        {
            String Nombre = (string)Parametros[0];
            int Edad = (int)Parametros[1];
            bool Valor = (bool)Parametros[2];
        }
    }
}