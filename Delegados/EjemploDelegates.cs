using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate void Imprimir<T>(T Valor);
    public class EjemploDelegates
    {
        public void ImprimirPantalla(string Variable)
        {
            Console.WriteLine(Variable);
        }
        public void ImprimirPantalla(int Variable)
        {
            Console.WriteLine($"El valor es : {Variable}");
        }
        public void EjemploDelegado()
        {
            Imprimir<string> imprimirDel = new Imprimir<string>(ImprimirPantalla);
            imprimirDel("Texto a imprimir");

            Imprimir<int> imprimirEntero = new Imprimir<int>(ImprimirPantalla);
            imprimirEntero(7);

        }

        public void EjemploAction()
        {
            Action<int> ActionEjemplo = ImprimirPantalla;
        }

        public void EjemploAnonimo()
        {
            Action<string> EjemploAnonimo = delegate (string valor)
            {
                Console.WriteLine(valor);
            };

            EjemploAnonimo("Imprimir valor");

            Action<string> EjemploAnonimoLambada = v => Console.WriteLine(v);
            EjemploAnonimoLambada("TIO IMPRIME");
        }

        public void EjemploFunc()
        {
            Func<int, string> delegadoFun1 = v => $"El valor es {v}";
            Console.WriteLine( delegadoFun1(23));
        }
    }
}
