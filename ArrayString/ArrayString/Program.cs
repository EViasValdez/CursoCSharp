namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Cadenas = new string[4];
            Cadenas[0] = "A";
            Cadenas[1] = "B";
            Cadenas[2] = "C";
            Cadenas[3] = "D";
            string[] Nombre = { "E", "F", "G", "H" };

            Console.WriteLine(Cadenas[0] + " " + Cadenas[1] + " " + Cadenas[2] + " " + Cadenas[3]);
            Console.WriteLine(Nombre[0] + " " + Nombre[1] + " " + Nombre[2] + " " + Nombre[3]);
        }
    }
}