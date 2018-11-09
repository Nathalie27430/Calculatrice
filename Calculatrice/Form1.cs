using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        int resultat = 0;
        List<int> chiffres = new List<int>();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ecran.Text += "+";
            
            //foreach (int elements in chiffres)
            //{
            //    resultat = resultat + elements;

            //   //operation = "+";
            //}

                

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ecran.Text += "1";
          //  chiffres.Add(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ecran.Text += "2";
            chiffres.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ecran.Text += "3";
            chiffres.Add(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {           
            DispatchOperation dispatch = new DispatchOperation();
            Ecran.Text = dispatch.ChooseOperation(Ecran.Text);
           
            
        }

        private void soustraction_Click(object sender, EventArgs e)
        {
            Ecran.Text += "-";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           Ecran.Clear();
           
       
        }

        private void Multipli_Click(object sender, EventArgs e)
        {
            Ecran.Text += "*";
        }

    }
}
