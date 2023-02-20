using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class EditorCalculadora
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public void Sumar(int a, int b)
        {
            if(ejemploEvento != null)
            {
                Console.WriteLine($"La suma es {a + b}");
            }
            else
            {
                Console.WriteLine($"No estas suscrito a los eventos");
            }
            
        }
        public void Restar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                Console.WriteLine($"La resta es {a - b}");
            }
            else
            {
                Console.WriteLine($"No estas suscrito a los eventos");
            }
        }
    }
    public class SuscriptorCalculadora
    {
        EditorCalculadora editor;
        private int A;
        private int B;
        public void EjemploEventHandler()
        {
            Console.WriteLine("La operacion va a ser ejecutada");
        }
        public SuscriptorCalculadora(int a, int b)
        {
            editor = new EditorCalculadora();
            A = a;
            B = b;
            editor.ejemploEvento += EjemploEventHandler;
        }

        public void OperacionSuma()
        {
            editor.Sumar(A, B);
        }
        public void OperacionResta()
        {
            editor.Restar(A, B);
        }
    }
}
