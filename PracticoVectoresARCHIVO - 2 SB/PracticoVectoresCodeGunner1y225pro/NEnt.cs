using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoVectoresCodeGunner1y225pro
{
    class NEnt
    {
        private int n;


        public NEnt()
        {
            n = 0;
        }


        public void Cargar(int dato)
        {
            n = dato;
        }

        public int Descargar()
        {
            return n;
        }

        public bool VerifPri()
        {
            int i, cont;
            cont = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return (cont == 2);
        }


        public bool EsCapicua(int num)
        {
            int numreverso, numoriginal;
            numreverso = 0; numoriginal = num;
            while (num > 0)
            {
                int digito = num % 10;
                numreverso = (numreverso * 10) + digito;
                num = num / 10;
            }
            return (numoriginal == numreverso);
        }

        public bool verifcapi()
        {
            bool b = false;
            int nu = 0;
            int aux = n;
            while (n > 0)
            {
                int dig = n % 10;
                n /= 10;
                nu = (nu * 10 + dig);
            }
            if (nu == aux)
            {
                b = true;
            }
            n = aux;
            return b;
        }
        public bool verif_fibo()
        {
            int a = -1;
            int b = 1;
            int c;
            do
            {
                c = checked(a + b);
                a = b;
                b = c;
            }
            while (!((c == n) || (c > n)));
            return c == n;
        }

        public bool VerifPar()
        {
            return (n % 2 == 0);
        }
        public bool verifMayor(double n1)
        {
            return n > n1;
        }
    }
}
