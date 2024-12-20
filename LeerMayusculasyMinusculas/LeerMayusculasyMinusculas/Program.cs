using System;
using System.Text;

namespace LeerMayusculasyMinusculas
{
    class Program
    {
        //private String cadena;
        //private String verMayusculas = "";
        //private String verMinusculas = "";
        //private int n;
        //private string[] Mayusculas;
        //private string[] Minusculas;
        //private string[] tempMy;
        //private string[] tempMn;

        //public Program(String cadena)
        //{
        //    this.cadena = cadena;
        //    n = cadena.Length;
        //    Mayusculas = new string[n];
        //    Minusculas = new string[n];
        //    tempMy = new string[n];
        //    tempMn = new string[n];
        //}
        //private String maysculas()
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (Char.IsUpper(cadena[i]))
        //        {
        //            tempMy[i] = Convert.ToString(cadena[i]);
        //        }
        //    }
        //    for (int i = 0; i < tempMy.Length; i++)
        //    {
        //        if (tempMy[i] != null)
        //        {
        //            Mayusculas[i] = tempMy[i];
        //            verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
        //        }
        //    }
        //    return verMayusculas;
        //}
        //public string minusculas()
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        // IsLower Indica si un carácter Unicode está categorizado como una letra minúscula.
        //        if (Char.IsLower(cadena[i]))
        //        {
        //            tempMn[i] = Convert.ToString(cadena[i]);
        //        }
        //    }
        //    for (int i = 0; i < tempMn.Length; i++)
        //    {
        //        if (tempMn[i] != null)
        //        {
        //            Minusculas[i] = tempMn[i];
        //            verMinusculas = $"{verMinusculas},{Minusculas[i]}";
        //        }
        //    }
        //    return verMinusculas;
        //}
        //static void Main()
        //{
        //    var cadena = Console.ReadLine();
        //    var data = new Program(cadena);

        //    Console.ReadLine();
        //}

        private String cadena;
        private String verMayusculas = "";
        private String verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;

        public Program(String cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMy = new string[n];
            tempMn = new string[n];
        }
        private String maysculas()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
                }
            }
            return verMayusculas;
        }
        public string minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsLower Indica si un carácter Unicode está categorizado como una letra minúscula.
                if (Char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMn[i];
                    verMinusculas = $"{verMinusculas},{Minusculas[i]}";
                }
            }
            return verMinusculas;
        }
        static void Main()
        {
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.WriteLine("Las letras Mayusculas son : " + data.maysculas()
                + "\n\n" + "Las letras Minusculas son : " + data.minusculas());
            Console.ReadLine();
        }
    }
}
