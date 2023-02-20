using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class OtraClase
    {
        public void ClaseAlternativa(Action<int> action)
        {
            action(9);
        }
    }
}
