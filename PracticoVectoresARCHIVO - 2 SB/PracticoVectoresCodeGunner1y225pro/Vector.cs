using System;  //<CodeGunner>
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoVectoresCodeGunner1y225pro
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void CargarRnd(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;

            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b + 1);
            }
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;

            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox("Ingrese el elemento " + i + " del vector:", "Carga Manual"));
            }
        }



        public string Descargar()
        {
            string s = "";
            int i;

            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + "\x0009";
            }

            return s;
        }

        public void Insertar(int x)
        {
            n++;
            v[n] = x;
        }
        //1
        public void Ejercicio1p1(int ne, int m, int vi)
        {
            n = ne;
            for (int i = 1; i <= n; i++)
            {
                v[i] = vi;
                vi = vi * m;
            }
        }
        //2
        public void Ejercicio2p1(int ne)
        {

            int c = 0;
            int a = -1;
            int b = 1;
            n = ne;

            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;

                v[i] = c;
            }
        }
        //3
        public double Ejercicio3p1()
        {
            double s = 0;
            bool sumar = true;

            for (int i = 1; i <= n; i++)
            {
                double termino = v[i] / (2.0 * i); // denominador = 2,4,6,...

                if (sumar)
                    s += termino;
                else
                    s -= termino;

                sumar = !sumar;
            }

            return s;
        }
        //4
        public double Ejercicio4p1(int m)
        {
            double s = 0;
            double naux = 0;
            double media;

            for (int i = m; i <= n; i = i + m)
            {
                s = s + v[i];
                naux++;
            }

            media = s / naux;

            return media;
        }
        //5
        public double Ejercicio5p1(int a, int b)
        {
            double s = 0;
            double c = 0;
            double p = 0;

            for (int i = a; i <= b; i++)
            {
                s = s + v[i];
                c++;
            }

            p = s / c;

            return p;
        }
        //6
        public void Ejercicio6p1(ref Vector vr1, ref Vector vr2, int m)
        {
            vr1.n = 0; vr2.n = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] % m == 0)
                {
                    vr1.Insertar(v[i]);
                }
                else
                {
                    vr2.Insertar(v[i]);
                }
            }
        }
        //7
        public void Ejercicio7p1(ref Vector vr1, ref Vector vr2, ref Vector vr3)
        {
            vr1.n = 0; vr2.n = 0; vr3.n = 0;

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += v[i];
            }
            double media = s / n;

            double sc = 0;
            for (int i = 1; i <= n; i++)
            {
                sc += Math.Pow(v[i] - media, 2);
            }
            double desv = Math.Sqrt(sc / n);

            for (int i = 1; i <= n; i++)
            {
                if (v[i] > media + desv)
                {
                    vr1.Insertar(v[i]);
                }

                if (v[i] < media - desv)
                {
                    vr3.Insertar(v[i]);
                }

                if (v[i] <= media + desv && v[i] >= media - desv)
                {
                    vr2.Insertar(v[i]);
                }
            }
        }
        //8
        public void Ejercicio8p1(ref Vector vr)
        {
            vr.n = 0;
            for (int i = 1; i <= n; i++)
            {
                if (frecuencia(v[i]) > 1)
                {
                    vr.Insertar(v[i]);
                }
            }
        }

        public int frecuencia(int x)
        {
            int c = 0;

            for (int i = 1; i <= n; i++)
            {
                if (v[i] == x)
                {
                    c++;
                }
            }

            return c;
        }
        //9
        public void Ejercicio9p1()
        {
            int j = 0;

            for (int i = 1; i <= n; i++)
            {
                if (v[i] % 2 != 0) // si es impar
                {
                    j++;
                    v[j] = v[i];  // copiamos el impar en la nueva posición
                }
            }

            n = j;
        }
        //10
        public bool Ejercicio10p1()
        {
            bool ban = true;


            for (int i = 1; i <= n; i++)
            {

                if (i % 2 != 0)
                {
                    if (v[i] % 2 != 0) // Si no es par
                    {
                        ban = false;
                    }
                }


                if (i % 2 == 0)
                {
                    if (v[i] % 2 == 0) // Si no es impar
                    {
                        ban = false;
                    }
                }
            }

            return ban;
        }
        //11
        public void Ejercicio11p1(Vector Ve, ref Vector R)
        {
            int i, j;
            bool repetido;

            R.n = 0;


            for (i = 1; i <= n; i++)
            {
                R.Insertar(v[i]);
            }


            for (i = 1; i <= Ve.n; i++)
            {
                repetido = false;


                for (j = 1; j <= R.n; j++)
                {
                    if (Ve.v[i] == R.v[j])
                    {
                        repetido = true; // Marcamos que ya existe
                    }
                }

                if (!repetido)
                {
                    R.Insertar(Ve.v[i]);
                }
            }
        }
        //12
        public void Ejercicio12p1(Vector Ve, ref Vector Vr)
        {

            Vr.n = 0;

            for (int i = 1; i <= n; i++)
            {
                bool existe = false;


                for (int j = 1; j <= Ve.n; j++)
                {
                    if (v[i] == Ve.v[j])
                    {
                        existe = true; // Se encontró el elemento
                    }
                }

                if (!existe)
                {
                    Vr.Insertar(v[i]);
                }
            }
        }
        //13
        public bool Ejercicio13p2(int a, int b)
        {

            if (a < 1) a = 1;
            if (b > n) b = n;


            for (int i = a; i < b; i++)
            {

                if (v[i] > v[i + 1])
                {
                    return false; // Encontramos desorden -> no está ordenado
                }
            }

            return true; // Si no hubo problemas -> está ordenado
        }

        //P2

        //1
        public void ejercicio1p2(int a, int b)
        {
            int c = 0;
            for (int i = 1; i < a; i++)
            {


                if (i < a)
                {
                    c++;
                    v[c] = v[i];

                }


            }
            for (int i = a; i <= n; i++)
            {

                if (i > b)
                {

                    c++;
                    v[c] = v[i];

                }


            }

            n = n - (b - (a - 1));
        }

        //2
        public void ejercicio2p2(int m)
        {
            for (int i = m; i <= n; i = i + m)
            {

                for (int j = i + m; j <= n; j = j + m)
                {
                    if (v[j] < v[i])
                    {
                        Inter(i, j);
                    }

                }

            }
        }



        public void Inter(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }

        //3---------------------------------obs

        public void ejercicio3p2(Vector vr)
        {
            bool ban;
            ban = true;
            NEnt n1 = new NEnt();
            vr.n = 0;

            int num, i2, i1, c1, c2;
            num = n;

            i2 = 0;
            i1 = 0;
            c1 = 0;
            c2 = n;
            OrdBurbuja();
            for (int i = 1; i <= n; i++)
            {
                if (ban == true)
                {
                    c1 = c1 + 1;
                    i1 = i1 + 1;
                    vr.n = i1;

                    vr.v[c1] = v[i1];
                    ban = !ban;
                }
                else
                {


                    i2 = i2 + 1;
                    i1 = i1 + 1;
                    num = num - (i2 - 1);
                    vr.n = num;

                    vr.v[c2] = v[i1];
                    c2 = c2 - 1;
                    ban = !ban;

                }

            }

            vr.n = n;
        }
        public void OrdBurbuja()
        {
            int num = n;
            checked
            {
                for (int i = 1; i <= num; i++)
                {
                    int num2 = i + 1;
                    int num3 = n;
                    for (int j = num2; j <= num3; j++)
                    {
                        if (v[i] > v[j])
                        {


                            Intercambio(i, j);
                        }
                    }
                }
            }
        }
        public void Intercambio(int a, int b)
        {
            int aux;

            aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }


        //4

        //public int ejercicio4p2(int a, int b)
        //{
        //    int i = a, aux, cont = 0;
        //    Vector v1 = new Vector();
        //    v1 = this;
        //    v1.OrdSec(a, b);
        //    while (i <= b)
        //    {
        //        aux = v1.v[i];
        //        while (v1.v[i] == aux)
        //        {
        //            i++;
        //        }
        //        cont++;


        //    }

        //    return cont;

        //}

        public int ejercicio4p2(int a, int b)
        {

            OrdSec(a, b);


            int x = 1;


            for (int i = a + 1; i <= b; i++)
            {

                if (v[i] != v[i - 1])
                {
                    x++;
                }
            }


            return x;
        }


        public void OrdSec(int a, int b)
        {
            int num = n;
            int aux;

            {
                for (int i = a; i <= b; i++)
                {

                    for (int j = a; j <= b; j++)
                    {
                        if (v[j] > v[j + 1])
                        {
                            aux = v[j];
                            v[j] = v[j + 1];
                            v[j + 1] = aux;

                        }
                    }
                }
            }
        }

        //5

        public int Elem_MasRep_Seg(int a, int b)
        {
            int i = a;
            int fr = frec_elem_segmento(v[i], a, b);
            int ele = v[i];
            for (i = a; i <= b; i++)
            {
                if (frec_elem_segmento(v[i], a, b) > fr)
                {
                    fr = frec_elem_segmento(v[i], a, b);
                    ele = v[i];
                }
            }
            return ele;
        }

        public int Elem_MasRep_Seg_frec(int a, int b)
        {
            int ele = v[a];
            int fr = frec_elem_segmento(ele, a, b);

            for (int i = a + 1; i <= b; i++)
            {
                int f = frec_elem_segmento(v[i], a, b);
                if (f > fr)
                {
                    fr = f;
                    ele = v[i];
                }
            }
            return fr;
        }

        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;
            int num = a;
            int num2 = b;
            checked
            {
                for (int i = num; i <= num2; i++)
                {

                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }


        //6
        public void ejercicio6p2(int a, int b, ref Vector e, ref Vector f)
        {
            OrdenarSegVec(a, b);
            e.n = 0;
            f.n = 0;
            int i = a;

            {
                while (i <= b)
                {
                    int ele = v[i];
                    int fr = 0;
                    while ((i <= b) & (ele == v[i]))
                    {
                        i++;
                        fr++;
                    }
                    e.Insertar(ele);
                    f.Insertar(fr);
                }
            }
        }
        public void OrdenarSegVec(int a, int b)
        {
            checked
            {
                for (int i = a; i <= b; i++)
                {
                    int num = i + 1;
                    for (int j = num; j <= b; j++)
                    {
                        if (v[i] > v[j])
                        {
                            Inter(i, j);
                        }
                    }
                }
            }
        }

        //7
        public void ejercicio7v2(Vector e, Vector f)
        {
            int num, c1;
            num = n;
            e.n = 0;
            c1 = 0;

            OrdBurbuja();


            for (int i = 1; i <= num; i++)
            {

                NEnt n1 = new NEnt();
                n1.Cargar(v[i]);

                if (n1.verif_fibo() && (v[i] != v[i + 1]))
                {
                    c1 = c1 + 1;
                    e.v[c1] = v[i];

                    f.v[c1] = frec_elem_segmento(v[i], 1, n);
                }


            }
            e.n = c1;
            f.n = c1;
        }

        //8
        public void ejercicio8p2(int a, int b)
        {
            NEnt n1 = new NEnt();
            int i = a;
            int d = b;
            {
                while (i <= d)
                {
                    bool b2 = true;
                    while ((i <= d && b2))
                    {

                        if (frec_elem_segmento(v[d], a, b) == 1)
                        {
                            d--;
                        }
                        else
                        {
                            b2 = false;
                        }
                    }
                    bool b3 = true;
                    while ((i <= d && b3))
                    {

                        if ((frec_elem_segmento(v[i], a, b) > 1))
                        {
                            i++;
                        }
                        else
                        {
                            b3 = false;
                        }
                    }
                    if (i <= d)
                    {
                        Inter(i, d);
                        i++;
                        d--;
                    }
                }
                OrdenarSegVecDes(a, d);
                OrdenarSegVecDes(i, b);
            }
        }
        public void OrdenarSegVecDes(int a, int b)
        {
            checked
            {
                for (int i = a; i <= b; i++)
                {
                    int num = i + 1;
                    for (int j = num; j <= b; j++)
                    {
                        if (v[i] < v[j])
                        {
                            Inter(i, j);
                        }
                    }
                }
            }
        }
        //9
        public void ejercicio9p2()
        {

            int k = 1;

            for (int i = 1; i <= n; i++)
            {
                NEnt x = new NEnt();
                x.Cargar(v[i]);
                if (x.verifcapi())
                {

                    int a = v[i];
                    v[i] = v[k];
                    v[k] = a;
                    k++;
                }
            }


            for (int i = 1; i <= k - 2; i++)
            {
                for (int j = i + 1; j <= k - 1; j++)
                {
                    if (v[j] < v[i])
                    {
                        int a = v[i];
                        v[i] = v[j];
                        v[j] = a;
                    }
                }
            }


            for (int i = k; i <= n - 1; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[j] > v[i])
                    {
                        int a = v[i];
                        v[i] = v[j];
                        v[j] = a;
                    }
                }
            }
        }

        //10
        public void ejercicio10p2(int a, int b)
        {
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            bool ban = true;

            {
                for (int p = a; p <= b; p++)
                {
                    if (ban)
                    {
                        int num = p + 1;
                        for (int d = num; d <= b; d++)
                        {
                            n1.Cargar(v[d]);
                            n2.Cargar(v[p]);
                            if ((n1.VerifPri() & !n2.VerifPri()) | (n1.VerifPri() & n2.VerifPri() & (v[p] > v[d])) | (!n1.VerifPri() & !n2.VerifPri() & (v[p] > v[d])))
                            {
                                Inter(p, d);
                            }
                        }
                    }
                    else
                    {
                        int num2 = p + 1;
                        for (int d = num2; d <= b; d++)
                        {
                            n1.Cargar(v[p]);
                            n2.Cargar(v[d]);
                            if ((n1.VerifPri() & !n2.VerifPri()) | (n1.VerifPri() & n2.VerifPri() & (v[p] > v[d])) | (!n1.VerifPri() & !n2.VerifPri() & (v[p] > v[d])))
                            {
                                Inter(p, d);
                            }
                        }
                    }
                    ban = !ban;
                }
            }
        }

        


        public void Inter2(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }

        public void OrdInter()
        {
            int p, d;
            // for (p = n; p >= 2; p--)
            p = n;
            while (p >= 2)
            {
                //for (d = p > 1; d >= 1; d--)
                d = p;
                while (d >= 1)
                {
                    if (v[d] > v[p])
                        Inter(p, d);
                    d--;
                }
                p--;
            }
        }

        public void OrdInterD()
        {
            int p, d;
            for (p = 1; p <= n - 1; p++)
                for (d = n; d >= p + 1; d--)
                    if (v[d] > v[p])
                        Inter(p, d);
        }

        public void Push(int ele)
        {
            n++;
            v[n] = ele;
        }

        public int Pop()
        {
            int ele;
            ele = v[n];
            n--;
            return ele;
        }

        public bool Over()
        {
            return n == MAX;
        }

        public bool Under()
        {
            return n == 0;
        }



        public void Quick()
        {
            int i, d, m, id, dd, pivo;
            Vector izq, der; izq = new Vector(); der = new Vector();
            izq.Push(1); der.Push(n);

            while (!izq.Under())
            {
                i = izq.Pop(); d = der.Pop();
                while (i < d)
                {
                    m = (i + d) / 2; pivo = v[m]; id = i; dd = d;
                    while (id <= dd)
                    {
                        while ((id <= dd) && (v[id] > pivo))
                            id++;
                        while ((id <= dd) && (v[id] < pivo))
                            dd--;
                        if (id <= dd)
                        {
                            Inter(id, dd); id++; dd--;
                        }


                    }
                    izq.Push(id);
                    der.Push(d);
                    d = dd;
                }
            }
        }

        public void OrdBurb()
        {
            int t, d;
            for (t = n; t >= 2; t--)
                for (d = 1; d <= t - 1; d++)
                    if (v[d] < v[d + 1])
                        Inter(d, d + 1);
        }

        public void OrdBurInv()
        {
            int t, d;
            for (t = 1; t <= n - 1; t++)
            {
                for (d = n; d >= t + 1; d--)
                {
                    if (v[d] < v[d - 1])
                    {

                        Inter(d, d - 1);
                    }
                }

            }

        }

        public void Insert(int ele)
        {
            int d;
            bool b;
            d = n;
            b = true;
            while ((d >= 1) && (b == true))
            {
                if (v[d] > ele)
                {
                    v[d + 1] = v[d]; d--;
                }

                else
                {
                    b = false;
                }

            }
            v[d + 1] = ele;
            n++;
        }
        //EJERCICIOS NUEVOS ARCHIVOS
        public void GrabarV(string narch1)
        {
            ArchBin a1 = new ArchBin();
            int i;
            a1.Abrir_Grab(narch1);
            for (i = 1; i <= n; i++)
                a1.Grabar(v[i]);
            a1.Cerrar_Grab();
        }
        public void Leer(string narch1)
        {
            ArchBin a1 = new ArchBin();
            int i = 0;
            a1.Abrir_Leer(narch1);
            while (!a1.Verif_Fin())
            {
                i++;
                v[i] = a1.Leer();
            }
            n = i;
            a1.Cerrar_Leer();
        }

    }
}
