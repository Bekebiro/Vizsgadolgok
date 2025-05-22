using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;

namespace calcullator2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int sign = 0;
        static int dot = 0;
        static double result = 0.0;
        static bool resultBool = false;
        static bool operBool = false;
        static string oper = "";

        static int Lenght(string displaytext)
        {
            if (displaytext.Contains(","))
            {
                dot = 1;
            }
            else dot = 0;

            if (displaytext.Contains("-"))
            {
                sign = 1;
            }
            else sign = 0;

            return 14 + sign + dot;
        }

        private void operation()
        {
            if (oper == "+")
            {
                result += double.Parse(txtDisplay.Text);
            }
            else if (oper == "/" && double.Parse(txtDisplay.Text) != 0)
            {
                result /= double.Parse(txtDisplay.Text);
            }
            else if (oper == "*")
            {
                result *= double.Parse(txtDisplay.Text);
            }
            else if (oper == "-")
            {
                result -= double.Parse(txtDisplay.Text);
            }
            string resultText = result.ToString();
            int resultLenght = Lenght(resultText);
            if (resultText.Length < resultLenght) txtDisplay.Text = resultText;
            else txtDisplay.Text = resultText.Substring(0, resultLenght);
            resultBool = true;
            if (double.Parse(txtDisplay.Text) == 0 || Math.Abs(result) > 99999999999999 || Math.Abs(result) < 0.0000000000000)
            {
                txtDisplay.Text = "HIBA";
                result = 0;
                resultBool = false;
                operBool = false;
            }
        }


        private void Display(string btn)
        {
            string textDisplay = txtDisplay.Text;
            int maxLength = Lenght(textDisplay);

            if (btn == "+-")
            {
                txtDisplay.Text = (double.Parse(textDisplay) * -1).ToString();
                return;
            }

            if (btn == "C")
            {
                txtDisplay.Text = "0";
                return;
            }

            if (btn == "AC")
            {
                txtDisplay.Text = "0";
                result = 0;
                return;
            }

            if (btn == "sqrt")
            {
                result = Math.Sqrt(double.Parse(txtDisplay.Text));
                string resultText = result.ToString();
                int resultLenght = Lenght(resultText);
                if (resultText.Length < resultLenght) txtDisplay.Text = resultText;
                else txtDisplay.Text = resultText.Substring(0, resultLenght);
                resultBool = true;
                operBool = false;
                return;
            }

            if (btn == "/")
            {
                if (!resultBool && !operBool)
                {
                    oper = "/";
                    result = double.Parse(textDisplay);
                    operBool = true;
                    resultBool = true;
                    return;
                }
                else if(resultBool && !operBool)
                {
                    oper = "/";
                    operBool = true;
                    return;
                }
                else if(resultBool && operBool)
                {
                    operation();
                    oper = "/";
                }
                return;
            }

            if (textDisplay.Length == maxLength)
            {
                return;
            }
            else
            {
                if(btn == "," && dot == 0)
                {
                    txtDisplay.Text += ",";
                    return;
                }
                else if(btn == "," && dot == 1)
                {
                    return;
                }
                else
                {
                    if (textDisplay == "0") txtDisplay.Text = btn;
                    else txtDisplay.Text += btn;
                }
            }

            if (textDisplay.Length == maxLength) return;

            if (btn == ",")
            {
                txtDisplay.Text += ",";
                return;
            }


            if (btn == "0")
            {
                txtDisplay.Text += "0";
                return;
            }
            else
            {
                txtDisplay.Text = textDisplay == "0" ? btn : textDisplay + btn;
                return;
            }

           

        }
        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static int btnColorIndex = 0;
        List<Color> lisColor = new List<Color>();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            

            lisColor.Add(Color.White);
            lisColor.Add(Color.Red);
            lisColor.Add(Color.Green);
            lisColor.Add(Color.Blue);
            lisColor.Add(Color.Yellow);
            lisColor.Add(Color.Pink);
            txtDisplay.BackColor = lisColor[btnColorIndex];
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            btnColorIndex++;
            if (btnColorIndex >= lisColor.Count) btnColorIndex = 0;
            txtDisplay.BackColor = lisColor[btnColorIndex];
            btnColor.BackColor = lisColor[btnColorIndex];
            
        }

        

        private void bntPlusMinus_Click(object sender, EventArgs e)
        {
            Display("+-");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Display("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Display("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Display("2");
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            Display("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Display("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Display("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Display("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Display("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Display("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Display("9");
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            Display("sqrt");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Display("C");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Display("AC");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Display("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Display("/");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Display("+");
        }

        private void bntMinus_Click(object sender, EventArgs e)
        {
            Display("-");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Display("=");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            Display(",");
        }
    }
}
