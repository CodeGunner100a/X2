using System.IO;

namespace PracticoVectoresCodeGunner1y225pro
{
    class ArchBin
    {
        private string narch;
        private FileStream stream;
        private BinaryWriter writer1;
        private BinaryReader reader1;

        public ArchBin()
        {
            narch = "";
        }

        public void Abrir_Grab(string narch1)
        {
            narch = narch1;
            stream = new FileStream(narch, FileMode.CreateNew, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }
        public void Grabar(int dato)
        {
            writer1.Write(dato);
        }


        public void Cerrar_Grab()
        {
            writer1.Close();
            stream.Close();
        }
        public void Abrir_Leer(string narch1)
        {
            narch = narch1;
            stream = new FileStream(narch, FileMode.Open, FileAccess.Read);
            reader1 = new BinaryReader(stream);
        }
        public int Leer()
        {
            int n;
            n = reader1.ReadInt32();
            return n;
        }


        public void Cerrar_Leer()
        {
            reader1.Close();
            stream.Close();
        }
        public bool Verif_Fin()
        {

            return stream.Position == stream.Length;
        }


        public void SelectPares(string Nomb1, string Nomb2, ref ArchBin A2)
        {
            NEnt nu = new NEnt();
            Abrir_Leer(Nomb1);
            A2.Abrir_Grab(Nomb2);

            while (!Verif_Fin())
            {
                nu.Cargar(Leer());
                if (nu.VerifPar())
                    A2.Grabar(nu.Descargar());
            }

            Cerrar_Leer();
            A2.Cerrar_Grab();
        }

    

        public void Abrir_Lerr_Grabar(string March1)
        {
            narch = March1;
            stream = new FileStream(narch, FileMode.Open, FileAccess.ReadWrite);
            reader1 = new BinaryReader(stream);
            writer1 = new BinaryWriter(stream);
        }



        public void GrabarR(int nr, int dato)
        {
            nr = (nr - 1) * 4;
            writer1.Write(dato);
        }
        public void Cerrar_Leer_Grabar()
        {
            reader1.Close();
            writer1.Close();
            stream.Close();
        }

        public void LeerR(int nr, int dato)
        {
            //int n;
            nr = (nr - 1) * 4;
            stream.Seek(nr, SeekOrigin.Begin);
            writer1.Write(dato);

        }


        public int LeerR(int nr)
        {
            int n;
            nr = (nr - 1) * 4;
            stream.Seek(nr, SeekOrigin.Begin);
            n = reader1.ReadInt32();
            return n;
        }

     
        public double Media(string Narch)
        {
            int c = 0, s = 0;
            Abrir_Leer(Narch);

            while (!Verif_Fin())
            {
                c++;
                s = s + Leer();
            }

            Cerrar_Leer();

            if (c == 0)
            {
                return 0; 
            }

            return (double)s / c;
        }

        public void SelectElemsMayoresAlaMedia(string Nomb1, string Nomb2, ref ArchBin A2)
        {
            NEnt nu = new NEnt();
            double media = Media(Nomb1);
            Abrir_Leer(Nomb1);
            A2.Abrir_Grab(Nomb2);

            while (!Verif_Fin())
            {
                nu.Cargar(Leer());
                if (nu.verifMayor(media))
                    A2.Grabar(nu.Descargar());
            }

            Cerrar_Leer();
            A2.Cerrar_Grab();
        }

   
        public void PurgarAsc(string Nomb1, string Nomb2, ref ArchBin A2)
        {
            int act, ant;

            Abrir_Leer(Nomb1);
            A2.Abrir_Grab(Nomb2);

            if (!Verif_Fin())                 
            {
                ant = Leer();               
                A2.Grabar(ant);              

                while (!Verif_Fin())         
                {
                    act = Leer();
                    if (act != ant)           
                    {
                        A2.Grabar(act);
                        ant = act;
                    }
                }
            }

            Cerrar_Leer();
            A2.Cerrar_Grab();
        }






        public void UnirAsc(string Nomb1, string Nomb2, string Nomb3, ref ArchBin a2, ref ArchBin a3)
        {
            int x = 0, y = 0;
            bool fin1 = false, fin2 = false;

            Abrir_Leer(Nomb1);     
            a2.Abrir_Leer(Nomb2);   
            a3.Abrir_Grab(Nomb3);  

         
            if (!Verif_Fin())
            {                
                x = Leer();
            }
            else
            {
                fin1 = true;
            }

            if (!a2.Verif_Fin()) 
            { 
                
                y = a2.Leer(); 
            }
            else
            {
                fin2 = true;
            }

 
            while (!fin1 || !fin2)
            {
              
                if (!fin1 && !fin2)
                {
                    if (x <= y)
                    {
                        a3.Grabar(x);
                        if (!Verif_Fin()) { x = Leer(); }
                        else fin1 = true;
                    }
                    else
                    {
                        a3.Grabar(y);
                        if (!a2.Verif_Fin()) { y = a2.Leer(); }
                        else fin2 = true;
                    }
                }
                else if (!fin1) 
                {
                    a3.Grabar(x);
                    if (!Verif_Fin()) { x = Leer(); }
                    else fin1 = true;
                }
                else 
                {
                    a3.Grabar(y);
                    if (!a2.Verif_Fin()) { y = a2.Leer(); }
                    else fin2 = true;
                }
            }

            Cerrar_Leer();
            a2.Cerrar_Leer();
            a3.Cerrar_Grab();
        }



 
        
        public int MayorPosM(string Nomb1, int m)
        {
            int nTotal, pos, dato, may = int.MinValue;

            Abrir_Lerr_Grabar(Nomb1);

            nTotal = (int)stream.Length / 4;         

            for (pos = m; pos <= nTotal; pos += m)   
            {
                dato = LeerR(pos);

                if (dato > may)
                    may = dato;
            }

            Cerrar_Leer_Grabar();

            return may;
        }


        
        public int BusqBinaria(string Nomb1, int ele)
        {
            int ini, fin, mid, dato, n;

            Abrir_Lerr_Grabar(Nomb1);

            n = (int)stream.Length / 4;   
            ini = 1;
            fin = n;

            while (ini <= fin)
            {
                mid = (ini + fin) / 2;
                dato = LeerR(mid);

                if (dato == ele)
                {
                    Cerrar_Leer_Grabar();
                    return mid;           
                }

                if (ele > dato)
                    ini = mid + 1;
                else
                    fin = mid - 1;
            }

            Cerrar_Leer_Grabar();
            return -1;                   
        }

   

       

        public void Ejercicio6_MismoArchivo(string narch1, int m)
        {
            NEnt num = new NEnt();
            int pos = 0, cont = 0;

         
            Abrir_Leer(narch1);
            while (!Verif_Fin())
            {
                num.Cargar(Leer()); 
                pos++;
                if (pos % m == 0)
                    cont++;
            }
            Cerrar_Leer();

            if (cont == 0) return;  

            int[] aux = new int[cont];   
            pos = 0;
            int k = 0;

        
            Abrir_Leer(narch1);
            while (!Verif_Fin())
            {
                num.Cargar(Leer());
                pos++;
                if (pos % m == 0)
                {
                    aux[k] = num.Descargar();
                    k++;
                }
            }
            Cerrar_Leer();


            Abrir_Leer(narch1);
            ArchBin temp = new ArchBin();
            temp.Abrir_Grab("temp.dat"); 

            pos = 0;
            k = cont - 1;

            while (!Verif_Fin())
            {
                num.Cargar(Leer());
                pos++;

                if (pos % m == 0)          
                {
                    temp.Grabar(aux[k]);
                    k--;
                }
                else
                {
                    temp.Grabar(num.Descargar());  
                }
            }

            Cerrar_Leer();
            temp.Cerrar_Grab();

           
            File.Delete(narch1);
            File.Move("temp.dat", narch1);
        }

   



        public int examen(string Nomb1)
        {
            int ned = 0;
            int act, ant;

            Abrir_Leer(Nomb1);

            if (!Verif_Fin())
            {
                ant = Leer();
                ned = 1;

                while (!Verif_Fin())
                {
                    act = Leer();
                    if (act != ant)
                    {
                        ned++;
                        ant = act;
                    }
                }
            }

            Cerrar_Leer();

            return ned;
        }

    }
}
