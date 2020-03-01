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
       

        public Form1()
        {
            InitializeComponent();
        }

        float num;
        float ans = 0;
        int compteur = 0;

        int count;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        #region test
        private void bt_CE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            compteur = 0;
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            compteur = 0;
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                label2.Text = num.ToString() + "/";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                label2.Text = "";
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                label2.Text = num.ToString() + "/";
                compteur = compteur + 1;
            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
         
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
           
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ 9;
         

        }

        private void bt_multiple_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                label2.Text = num.ToString() + "*";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                label2.Text = "";
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                label2.Text = num.ToString() + "*";
                compteur = compteur + 1;
            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            
        }

        private void bt_soustraction_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                label2.Text = num.ToString() + "-";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                label2.Text = "";
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                label2.Text = num.ToString() + "-";
                compteur = compteur + 1;
            }

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
           
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
          
        }

        private void bt_addition_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                label2.Text = num.ToString() + "+";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                label2.Text = "";
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                label2.Text = num.ToString() + "+";
            }

        }

        private void bt_mystery_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "MYSTERE";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            
        }

        private void bt_virgule_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            //operateur = ",";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private void bt_egal_Click(object sender, EventArgs e)
        {
            Calcul();
            label2.Text = "";
        }

        public void Calcul()
        {

            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans =num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;

                    
            }

        }
    }
}
