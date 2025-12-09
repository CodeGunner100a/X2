using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizexamen
{
    class Matriz
    {
    
        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;

        private int f, c;

   

        public Matriz()
        {

            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;

        }



        public void CargarRandom(int nf, int nc, int a, int b)

        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;


            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    x[f1, c1] = r.Next(a, b + 1);

                }

            }

        }


        public string Descargar()

        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    s = s + x[f1, c1] + "\x9";


                }
                s = s + "\xd" + "\xa";

            }

            return s;

        }


        //examen

        public int NumeroElementosDiferentesTriangularInferiorDer()
        {
            int ned = 0;

            // Recorrer cada elemento de la triangular inferior derecha
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c - f + f1; c1 <= c; c1++)
                {
                    int actual = x[f1, c1];
                    bool esDiferente = true;
                    bool salir = false;

                    // Verificar si el elemento ya fue contado antes
                    for (int f2 = 1; f2 <= f && !salir; f2++)
                    {
                        for (int c2 = c - f + f2; c2 <= c && !salir; c2++)
                        {
                            // Si llegamos a la posición actual, detenemos
                            if (f2 == f1 && c2 == c1)
                            {
                                salir = true;
                            }
                            else if (x[f2, c2] == actual)
                            {
                                // Si encontramos el elemento antes, no es diferente
                                esDiferente = false;
                                salir = true;
                            }
                        }
                    }

                    if (esDiferente)
                        ned++;
                }
            }

            return ned;
        }


        //-----------------


        public void MayorFrecuenciaTSupDer(ref int ele, ref int frec)
        {
            ele = 0;
            frec = 0;

            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = f1; c1 <= c; c1++)  
                {
                    int cont = 0;
                    int val = x[f1, c1];


                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = f2; c2 <= c; c2++)
                        {
                            if (x[f2, c2] == val)
                                cont++;
                        }
                    }

                    if (cont > frec)
                    {
                        frec = cont;
                        ele = val;
                    }
                }
            }
        }

    }
}
