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
        int conta1, conta2, conta3,consonantes1;
        
        public Form1()
        {
           
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            palabraalreves();

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

    }
}
