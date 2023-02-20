using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class DelegadosHdeleon
    {
        public delegate int BuscaNumeroMayor(List<int> lst);

        public static int Buscar(List<int> lst_)
        {
            return lst_.OrderByDescending(x => x).First();
        }

    }
}
