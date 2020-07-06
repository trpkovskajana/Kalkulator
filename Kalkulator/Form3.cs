using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form3 : Form
    {
        private double broj1;
        private double broj2;
        private char operacija; //a=addition; s=substraction; m=multiplication; d=division; 
        private int operacija2;  //0-nema vtora operacija vneseno; 1- ima vtora operacija vneseno;
        private int decimalenBr2 = 0;  //0-nema vtor decimalen br; 1- ima vtor decimalen br;

        public Form3()
        {
            InitializeComponent();
            textBox1.Text = "0";
            broj1 = 0;
            broj2 = 0;
            operacija = ' ';
            operacija2 = 0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void esc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
      
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operacija = ' ';
            broj1 = 0;
            broj2 = 0;
            operacija2 = 0;
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains<char>('.'))
            {
                textBox1.Text += ".";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 1;
                        textBox1.Text += "1";
                    }
                    else
                    {
                        broj2 = 1;
                        textBox1.Text = "1";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 1;
                    textBox1.Text += "1";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 1;
                    textBox1.Text = "1";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "1";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "1";
                }
            }
        }
        
        private void two_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 2;
                        textBox1.Text += "2";
                    }
                    else
                    {
                        broj2 = 2;
                        textBox1.Text = "2";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 2;
                    textBox1.Text += "2";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 2;
                    textBox1.Text = "2";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "2";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "2";
                }
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 3;
                        textBox1.Text += "3";
                    }
                    else
                    {
                        broj2 = 3;
                        textBox1.Text = "3";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 3;
                    textBox1.Text += "3";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 3;
                    textBox1.Text = "3";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "3";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "3";
                }
            }
        }
        
        private void four_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 4;
                        textBox1.Text += "4";
                    }
                    else
                    {
                        broj2 = 4;
                        textBox1.Text = "4";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 4;
                    textBox1.Text += "4";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 4;
                    textBox1.Text = "4";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "4";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "4";
                }
            }
        }
        
        private void five_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 5;
                        textBox1.Text += "5";
                    }
                    else
                    {
                        broj2 = 5;
                        textBox1.Text = "5";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 5;
                    textBox1.Text += "5";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 5;
                    textBox1.Text = "5";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "5";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "5";
                }
            }
        }
        
        private void six_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 6;
                        textBox1.Text += "6";
                    }
                    else
                    {
                        broj2 = 6;
                        textBox1.Text = "6";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 6;
                    textBox1.Text += "6";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 6;
                    textBox1.Text = "6";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "6";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "6";
                }
            }
        }
        
        private void seven_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 7;
                        textBox1.Text += "7";
                    }
                    else
                    {
                        broj2 = 7;
                        textBox1.Text = "7";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 7;
                    textBox1.Text += "7";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 7;
                    textBox1.Text = "7";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "7";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "7";
                }
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 8;
                        textBox1.Text += "8";
                    }
                    else
                    {
                        broj2 = 8;
                        textBox1.Text = "8";
                    }
                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 8;
                    textBox1.Text += "8";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 8;
                    textBox1.Text = "8";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "8";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "8";

                }
            }
        }
        
        private void nine_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 9;
                        textBox1.Text += "9";
                    }
                    else
                    {
                        broj2 = 9;
                        textBox1.Text = "9";
                    }

                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    broj2 += 9;
                    textBox1.Text += "9";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 9;
                    textBox1.Text = "9";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0" && broj1 != 0)
                {
                    textBox1.Text += "9";
                }

                if (textBox1.Text.Length == 1 && broj1 == 0)
                {
                    textBox1.Text = "9";
                }
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (operacija != ' ')
            {
                if (operacija2 == 0 && broj2 == 0)
                {
                    if (decimalenBr2 == 1)
                    {
                        broj2 = 0;
                        textBox1.Text += "0";
                    }
                    else
                    {
                        broj2 = 0;
                        textBox1.Text = "0";
                    }

                }
                else if (operacija2 == 0 && broj2 != 0)
                {
                    broj2 *= 10;
                    textBox1.Text += "0";
                }
                else if (operacija2 != 0 && broj2 == 0)
                {
                    broj2 = 0;
                    textBox1.Text = "0";
                    operacija2 = 0;
                }
            }
            else
            {
                if (textBox1.Text.Length >= 1 && textBox1.Text != "0")
                {
                    textBox1.Text += "0";
                }

                if (textBox1.Text.Length == 1 && textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
            }
        }
        
        private void addition_Click(object sender, EventArgs e)
        {
            if (operacija == ' ')
            {
                broj1 = Double.Parse(textBox1.Text);
                operacija = 'a';
                operacija2 = 0;
            }
            else
            {
                switch (operacija)
                {
                    case 'a':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 + broj2);
                            operacija2 = 1;
                            broj1 = broj1 + broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'a';
                            break;
                        }

                    case 's':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 - broj2);
                            broj1 = broj1 - broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'a';
                            break;
                        }

                    case 'd':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 / broj2);
                            broj1 = broj1 / broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'a';
                            break;
                        }

                    case 'm':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 * broj2);
                            broj1 = broj1 * broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'a';
                            break;
                        }

                }
            }
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            if (operacija == ' ')
            {
                broj1 = Double.Parse(textBox1.Text);
                operacija = 's';
                operacija2 = 0;
            }
            else
            {
                switch (operacija)
                {
                    case 'a':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 + broj2);
                            operacija2 = 1;
                            broj1 = broj1 + broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 's';
                            break;
                        }

                    case 's':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 - broj2);
                            operacija2 = 1;
                            broj1 = broj1 - broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 's';
                            break;
                        }

                    case 'd':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 / broj2);
                            operacija2 = 1;
                            broj1 = broj1 / broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 's';
                            break;
                        }

                    case 'm':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 * broj2);
                            operacija2 = 1;
                            broj1 = broj1 * broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 's';
                            break;
                        }
                }
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (operacija == ' ')
            {
                broj1 = Double.Parse(textBox1.Text);
                operacija = 'd';
                operacija2 = 0;
            }
            else
            {
                switch (operacija)
                {
                    case 'a':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 + broj2);
                            operacija2 = 1;
                            broj1 = broj1 + broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'd';
                            break;
                        }

                    case 's':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 - broj2);
                            operacija2 = 1;
                            broj1 = broj1 - broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'd';
                            break;
                        }

                    case 'd':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 / broj2);
                            operacija2 = 1;
                            broj1 = broj1 / broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'd';
                            break;
                        }

                    case 'm':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 * broj2);
                            operacija2 = 1;
                            broj1 = broj1 * broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'd';
                            break;
                        }
                }
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {

            if (operacija == ' ')
            {
                broj1 = Double.Parse(textBox1.Text);
                operacija = 'm';
                operacija2 = 0;
            }
            else
            {
                switch (operacija)
                {
                    case 'a':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 + broj2);
                            operacija2 = 1;
                            broj1 = broj1 + broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'm';
                            break;
                        }

                    case 's':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 - broj2);
                            operacija2 = 1;
                            broj1 = broj1 - broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'm';
                            break;
                        }

                    case 'd':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 / broj2);
                            operacija2 = 1;
                            broj1 = broj1 / broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'm';
                            break;
                        }

                    case 'm':
                        {
                            if (textBox1.Text.Contains<char>('.'))
                            {
                                int pom = 0, brojac = 0;
                                char[] br2 = textBox1.Text.ToCharArray();
                                for (int i = 0; i < br2.Length; i++)
                                {
                                    if (pom == 1)
                                    {
                                        brojac++;
                                    }
                                    else
                                    {
                                        if (br2[i] == '.')
                                            pom = 1;
                                    }
                                }

                                broj2 /= Math.Pow(10, brojac);
                            }
                            textBox1.Text = String.Format("{0}", broj1 * broj2);
                            operacija2 = 1;
                            broj1 = broj1 * broj2;
                            broj2 = 0; //posledni promeni
                            decimalenBr2 = 0;
                            operacija = 'm';
                            break;
                        }
                }
            }
        }

        private void pos_neg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = String.Format("{0}", Double.Parse(textBox1.Text) * (-1));
            }
        }

        private void precent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = String.Format("{0}", Double.Parse(textBox1.Text) / 100);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if(operacija!=' ')
            {
                switch (operacija)
            {
                case 'a':
                    {
                        if (textBox1.Text.Contains<char>('.'))
                        {
                            int pom = 0, brojac = 0;
                            char[] br2 = textBox1.Text.ToCharArray();
                            for (int i = 0; i < br2.Length; i++)
                            {
                                if (pom == 1)
                                {
                                    brojac++;
                                }
                                else
                                {
                                    if (br2[i] == '.')
                                        pom = 1;
                                }
                            }

                            broj2 /= Math.Pow(10, brojac);
                        }
                        textBox1.Text = String.Format("{0}", broj1 + broj2);
                        broj1 = 0;
                        broj2 = 0; 
                        operacija2 = 0; 
                        decimalenBr2 = 0;
                        operacija = ' ';
                        break;
                    }

                case 's':
                    {
                        if (textBox1.Text.Contains<char>('.'))
                        {
                            int pom = 0, brojac = 0;
                            char[] br2 = textBox1.Text.ToCharArray();
                            for (int i = 0; i < br2.Length; i++)
                            {
                                if (pom == 1)
                                {
                                    brojac++;
                                }
                                else
                                {
                                    if (br2[i] == '.')
                                        pom = 1;
                                }
                            }

                            broj2 /= Math.Pow(10, brojac);
                        }
                        textBox1.Text = String.Format("{0}", broj1 - broj2);
                        broj1 = 0;
                        broj2 = 0;
                        operacija2 = 0; 
                        decimalenBr2 = 0;
                        operacija = ' ';
                        break;
                    }

                case 'd':
                    {
                        if (textBox1.Text.Contains<char>('.'))
                        {
                            int pom = 0, brojac = 0;
                            char[] br2 = textBox1.Text.ToCharArray();
                            for (int i = 0; i < br2.Length; i++)
                            {
                                if (pom == 1)
                                {
                                    brojac++;
                                }
                                else
                                {
                                    if (br2[i] == '.')
                                        pom = 1;
                                }
                            }

                            broj2 /= Math.Pow(10, brojac);
                        }
                        textBox1.Text = String.Format("{0}", broj1 / broj2);
                        broj1 = 0;
                        broj2 = 0; 
                        operacija2 = 0; 
                        decimalenBr2 = 0;
                        operacija = ' ';
                        break;
                    }

                case 'm':
                    {
                        if (textBox1.Text.Contains<char>('.'))
                        {
                            int pom = 0, brojac = 0;
                            char[] br2 = textBox1.Text.ToCharArray();
                            for (int i = 0; i < br2.Length; i++)
                            {
                                if (pom == 1)
                                {
                                    brojac++;
                                }
                                else
                                {
                                    if (br2[i] == '.')
                                        pom = 1;
                                }
                            }

                            broj2 /= Math.Pow(10, brojac);
                        }
                        textBox1.Text = String.Format("{0}", broj1 * broj2);
                        broj1 = 0;
                        broj2 = 0; 
                        operacija2 = 0; 
                        decimalenBr2 = 0;
                        operacija = ' ';
                        break;
                    }
                case ' ':
                    {
                        break;
                    }
            }
            }
            
        }

        //==============Extended Functions==========================

        private void trikorenx_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = String.Format("{0}", Math.Pow(Double.Parse(textBox1.Text),1/3));
            }
        }

        private void korenx_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = String.Format("{0}", Math.Sqrt(Double.Parse(textBox1.Text)));
            }
        }

        private void e_Click(object sender, EventArgs e)
        {
             textBox1.Text = String.Format("{0}", Math.E);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.PI);
        }

        private void factoriel_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains<char>('.'))
            {
                textBox1.Text = "Error";
            }
            else
            {
                double br = Double.Parse(textBox1.Text);
                if (br == 0)
                {
                    textBox1.Text = "1";
                }
                else
                {
                    double proizvod = 1;
                    for (double i = br; i >= 1; i--)
                    {
                        proizvod *= i;
                    }

                    textBox1.Text = proizvod.ToString();
                }
            }
            
        }

        private void dropka_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", 1/Double.Parse(textBox1.Text));
        }

        private void desetNaX_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Pow(10,Double.Parse(textBox1.Text)));
        }

        private void dvaNaX_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Pow(2, Double.Parse(textBox1.Text)));
        }

        private void eNaX_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Pow(Math.E, Double.Parse(textBox1.Text)));
        }

        private void xVtora_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Pow(Double.Parse(textBox1.Text),2));
        }

        private void xTreta_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Pow(Double.Parse(textBox1.Text),3));
        }

        private void sinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Sin(Double.Parse(textBox1.Text)/57.29578));
        }

        private void cosinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Cos(Double.Parse(textBox1.Text)/57.29578));
        }

        private void logx_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("{0}", Math.Log10(Double.Parse(textBox1.Text)));
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            textBox1.Text = String.Format("{0}", r.NextDouble());
        }
    }
}
