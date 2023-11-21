using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distruttore
{
    internal class Program
    {
        class esempio
        {
            protected string stringa;
            protected int numero;

            public esempio()
            {
                stringa = "ciao";
                numero = 1;
            }

            public void stampa()
            {
                Console.WriteLine(stringa + numero);
            }

            ~esempio()
            {
                Console.WriteLine("Distruzione avvenuta");
            }

            public void dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
        static void Main(string[] args)
        {
            esempio es=new esempio();
            es.stampa();
   
        }
    }
}
