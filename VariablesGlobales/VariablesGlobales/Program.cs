namespace VariablesGlobales
{
    class Program
    {
        private String Cadena;
        private String VerMayusculas = "";
        private String VerMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] TempMy;
        private string[] TempMi;

        public String Mayus()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(Cadena[i]))
                {
                    TempMy[i] = Convert.ToString(Cadena[i]);
                }
            }
            for (int i = 0; i < TempMy.Length; i++)
            {
                if (TempMy[i] != null)
                {
                    Mayusculas[i] = TempMy[i];
                    VerMayusculas = $"{VerMayusculas}, {Mayusculas[i]}";
                }
            }
            return VerMayusculas;
        }

        static void Main()
        {
            var Dato = new Program();
        }
    }
}