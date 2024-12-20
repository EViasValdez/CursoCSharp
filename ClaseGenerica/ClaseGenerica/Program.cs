namespace ClaseGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> ListaObjeto = new List<object>();

            ListaObjeto.Add("Fernando 1");
            ListaObjeto.Add(12);
            ListaObjeto.Add(true);
            ListaObjeto.Add("Salvador");
            // ListaObjeto.Remove(12);

            // ListaObjeto.ForEach(item => Console.WriteLine(item));
            ListaObjeto.Insert(2, "Rodrigo");
            // ListaObjeto.Clear();

            ListaObjeto.Reverse();
            Console.WriteLine(ListaObjeto.Contains(12));
            ListaObjeto.LastIndexOf("Fernando");

            Console.WriteLine(ListaObjeto.Exists(e => e.Equals("Fernando 2")));
            foreach (var item in ListaObjeto)
            {
                Console.WriteLine(item);
            }
        }
    }
}