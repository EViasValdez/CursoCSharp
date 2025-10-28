using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDulces
{
    public class Dulces : Almacen
    {
        private List<Producto> _Dulces;
        public Golosinas()
        {
            _Dulces = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            _Dulces.Add(producto);
        }
        public override List<Producto> getProducto(string producto)
        {
            var Dulces = new List<Producto>();
            
            if (producto.Equals(""))
            {
                Dulces = _Dulces;
            }
            else
            {
                Dulces = _Dulces.Where(g => g.Nombre.Equals(producto)).ToList();
            }
            return Dulces;
        }
    }
}