using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrizexamen
{
    public partial class Form1 : Form
    {
        Matriz x1, x2, x3;

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = x1.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.Descargar();
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
            x3 = new Matriz();
        }

        //examen

     
        private void mayorFrecuanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamada aqui

            //textBox7.Text = x1.NumeroElementosDiferentesTriangularInferiorDer();
            int ned = x1.NumeroElementosDiferentesTriangularInferiorDer();
            textBox7.Text = ned.ToString();
        }

    }
}
