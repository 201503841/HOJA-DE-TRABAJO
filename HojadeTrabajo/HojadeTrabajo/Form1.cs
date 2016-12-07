using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HojadeTrabajo
{

    public partial class Form1 : Form
    {

        string palabra, temporal;
        int conta1, conta2, conta3,conta4,consonantes1;
        
        public Form1()
        {
           
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            palabraalreves();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            repetidos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vocales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consonantes();
        }

        private void palabraalreves()
        {
            palabra = textBox1.Text;
            for (int x= palabra.Length-1; x >= 0; x--)
            {
                temporal += palabra[x];
            }
            label1.Text = temporal;

        }
        private void consonantes()
        {
            palabra = textBox1.Text;
            for (int i= 0; i < palabra.Length; i++)
            {
                conta1++;
            }
            for (int i = 0; i < palabra.Length; i++)
            {
                if ((palabra[i] == 'a')|| (palabra[i]=='e')|| (palabra[i]=='i')||(palabra[i]=='o')||(palabra[i]=='u'))
                    {
                    conta2++;
                }
            }
            //resta de las variables del contador
            consonantes1= conta1 - conta2;
            label1.Text = consonantes1.ToString();
            
        }
        private void vocales()
        {
            palabra = textBox1.Text;
            for (int i = 0; i < palabra.Length; i++)
            {
                conta3++;
            }
            for (int i = 0; i < palabra.Length; i++)
            {
                if ((palabra[i] == 'a') || (palabra[i] == 'e') || (palabra[i] == 'i') || (palabra[i] == 'o') || (palabra[i] == 'u'))
                {
                    conta4++;
                }
            }
            //resta de las variables del contador

            label1.Text = conta4.ToString();
        }
        public void repetidos()
        {
            char[] Arraycadena;
            char caracter;
            int contador = 0;
            palabra = textBox1.Text;
            Arraycadena =palabra.ToCharArray();
            for (int k=0; k < Arraycadena.Length; k++)
            {
                caracter = Arraycadena[k];
                for (int j= 0; j < Arraycadena.Length; j++)
                {
                    if (Arraycadena[j]==caracter)
                    {
                        contador++;
                    }
                }

                label1.Text = Arraycadena[k].ToString() + "->" + contador;
                contador = 0;
            }

        }

    }
}
