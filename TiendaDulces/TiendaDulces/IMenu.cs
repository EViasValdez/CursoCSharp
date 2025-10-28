using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDulces
{
    interface IMenu
    {
        void dulces();
        void ventas();
        double solicitarPago();
    }
}