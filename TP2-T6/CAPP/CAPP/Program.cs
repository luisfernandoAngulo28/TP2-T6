using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPP
{
    class Program
    {
        public static void Main(string[] args)
        {
            clsColaC C = new clsColaC();

            for (int i = 1; i < 6; i++)
            {
                C.Add(i);
            }

            Console.WriteLine(C.Mostrar());
            Console.ReadKey();
               
            
        }
    }
}
