using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyMetodosAbstract
{
    public class Menu : Principal
    {
        private string s;

        public Menu(String s)
        {
            this.s = s;
        }
        public override void getProducto()
        {
            Console.WriteLine(s);
        }
    }
}