using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Nent
    {
        private int n;
        public Nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }
        public bool verifpri()
        {
            int  r, c;
            c = 0;
            for (int i = 1; i <= n; i++)
            {
                r = n % i;
                if (r == 0)
                    c++;
            }
            return (c == 2);
        }
        public bool verifpar()
        {
            return (n % 2 == 0);
        }
    }
}