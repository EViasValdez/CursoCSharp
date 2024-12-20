namespace ClasesyMetodosAbstract
{
    public class Program : Menu
    {

        public Program(String s) : base(s)
        {

        }
        static void Main(string[] args)
        {
            new Program("Texto de ejemplo").getProducto();
        }
        //protected override void getProducto()
        //{
        //    Console.WriteLine("Otro texto de ejemplo");
        //}
    }
}