using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPP
{
    public class clsColaC
    {
        private const int max = 5;
        private int[] Cola = new int[max];
        private int rear;
        private int from;
        private int cant;

        public clsColaC()
        {

            rear = -1;
            from = -1;
            cant = 0;
            for (int i = 0; i < max; i++)
            {
                Cola[i] = 0;
            }

        }
        public clsColaC(clsColaC C)
        {

            rear = C.rear;
            from = C.from;
            cant = C.cant;
            for (int i = 0; i < max; i++)
            {
                Cola[i] = C.Cola[i];
            }
        }
        public bool Vacia()
        {
            return (cant == 0);
        }
        public bool Llena()
        {
            return (cant == max);
        }
        public void Add(int x)
        {
            if (Llena() != true)
            {
                rear = (rear + 1) % max;
                Cola[rear] = x;
                cant++;
            }
        }
        public void Delete()
        {
            if (Vacia() != true)
            {
                from = (from + 1) % max;
                cant--;
            }
        }
        public int From()
        {
            return (Cola[from + 1]);
        }
        public string Mostrar()
        {
            string s = "C[";

            int i = from;
            for (int j = 1; j <= cant; j++)
            {
                i = (i + 1) % max;
                s += Cola[i] + ",";
            }
            s += "]";
            return s;
        }



    }
}
