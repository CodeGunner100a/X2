using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticoVectoresCodeGunner1y225pro
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3, v4; NEnt n1;
      

        ArchBin a1, a2, a3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            v4 = new Vector();
            n1 = new NEnt();
            a1 = new ArchBin();
            a2 = new ArchBin();
            a3 = new ArchBin();
        }
       
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargardato(int.Parse(textBox1.Text));

            textBox5.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = v1.Descargar();
        }
    
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox6.Text = v2.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.cargardato(int.Parse(textBox1.Text));
            textBox6.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox8.Text = v2.Descargar();
        }
     
     




        

        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v1.GrabarV(saveFileDialog1.FileName);
        }



        private void leerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Leer(openFileDialog1.FileName);
        }

        private void ordenarInterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdInter();
            v2.OrdInter();
        }



        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v2.GrabarV(saveFileDialog1.FileName);
        }



        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v2.Leer(openFileDialog1.FileName);
        }

       

        

     
        private void elemntsMayoresALaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.SelectElemsMayoresAlaMedia(openFileDialog1.FileName, saveFileDialog1.FileName, ref a2);
        }



 
        private void purgarArchivoOrdenadoAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
            saveFileDialog1.ShowDialog(); 
            a1.PurgarAsc(openFileDialog1.FileName, saveFileDialog1.FileName, ref a2);
        }



        private void unir2ArchivosOrdenadosEnOtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog2.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.UnirAsc(openFileDialog1.FileName, openFileDialog2.FileName, saveFileDialog1.FileName, ref a2, ref a3);
        }


        
    
        private void encontrarElElemMayorDePosicionesMúltiplosDeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            int m = int.Parse(textBox4.Text); 

            int mayor = a1.MayorPosM(openFileDialog1.FileName, m);
            MessageBox.Show("El mayor en posiciones múltiplos de " + m + " es: " + mayor);
        }
       
        private void búsquedaBinariaEnElArchivoOrdenadoAscToolStripMenuItem_Click(object sender, EventArgs e)

        {
            openFileDialog1.ShowDialog();
            int x = int.Parse(textBox4.Text);

            int pos = a1.BusqBinaria(openFileDialog1.FileName, x);
            MessageBox.Show("Resultado: Pos = " + pos);
        }
       
        private void invertirLosElementosDePosicionesMúltiplosDeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                
            int m = int.Parse(textBox4.Text);             

            a1.Ejercicio6_MismoArchivo(openFileDialog1.FileName, m);

            MessageBox.Show("Proceso terminado.\nLos elementos en posiciones múltiplos de " +
                             m + " fueron invertidos en el mismo archivo.");
        }


        private void ejercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }


        private void ejercicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            int resultado = a1.examen(openFileDialog1.FileName);
            textBox7.Text = resultado.ToString();
        }

    }
}
