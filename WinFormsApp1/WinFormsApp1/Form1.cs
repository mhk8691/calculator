using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using System;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1

{

    public partial class Form1 : Form
    {

        int isDark = 0;

        int number1 = 0;

        int number2 = 0;



        string Opt;

        string Optkeys;



        int number1ornumber2 = 0;



        int result = 0;

        int test = 1;

        public Form1()

        {


            InitializeComponent();
            this.KeyPreview = true;
            foreach (Control removeborder in this.Controls)
            {

                if (removeborder is Button)
                {
                    Button border = (Button)removeborder;
                    border.TabStop = false;
                    border.FlatStyle = FlatStyle.Flat;
                    border.FlatAppearance.BorderSize = 0;
                }
            }
        }

        void setkeybord(string text)
        {

            if (number1ornumber2 % 2 == 0)
            {
                number1 = Convert.ToInt32(label1.Text);
               
            }

            else
            {

                number2 = Convert.ToInt32(label1.Text);
                
            }

        }

        int equalclick()
        {

            if (Opt == "+")
            {

                result = number1 + number2;
            }
            else if (Opt == "-")
            {
                result = number1 - number2;
            }
            else if (Opt == "×")
            {
                result = number1 * number2;
            }
            else if (Opt == "÷")
            {
                result = number1 / number2;
            }
            else if (Opt == "%")
            {
                result = number1 % number2;
            }

            return result;





        }

        private void buttoncalculator1(object sender, EventArgs e)
        {

            Button number = (Button)sender;

            label1.Text += number.Text;

            setkeybord(label1.Text);

            

        }

        private void pow2_Click(object sender, EventArgs e)
        {
            if (label1.Text == number1.ToString())
            {
                number1 = number1 * number1;
                label1.Text = number1.ToString();

                history.Text += number1.ToString();
            }
            else if (label1.Text == number2.ToString())
            {
                number2 = number2 * number2;

                label1.Text = number2.ToString();


            }
            else
            {
                result = result * result;
                label1.Text = result.ToString();
            }

        }

        private void factorial_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label1.Text);
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            if (label1.Text == number1.ToString())
            {
                number1 = factorial;
                label1.Text = number1.ToString();
            }
            else
            {
                number2 = factorial;
                label1.Text = number2.ToString();

            }
        }

        private void handleOpt(object sender, EventArgs e)
        {

            number1ornumber2++;


            Button Optbutton = (Button)sender;
            Opt = Optbutton.Text;


            history.Text = label1.Text;

            

            label1.Text = "";


            history.Text += " ";

            history.Text += Optbutton.Text;

            history.Text += " ";

            history.Visible = true;
            
            if (test % 2 == 0)
            {

                equalclick();
                label1.Text = result + "";

                number1 = result;

            }
            test++;





        }

        private void equal_Click(object sender, EventArgs e)
        {
            test = 0;
            if (test % 2 == 0)
            {

                int resul2 = equalclick();
                label1.Text = resul2.ToString();
                history.Text += " ";
                history.Text += number2 + "";
                history.Text += " =";
                history.Visible = true;
            }

        }

        private void clear(object sender, EventArgs e)
        {

            label1.Text = "";

            history.Text = "";
            number1ornumber2 = 1;

            //history.Text = label1.Text;

            number1 = 0;
            number2 = 0;
            


        }

        private void negative(object sender, EventArgs e)
        {
            if (label1.Text == number1.ToString())
            {
                number1 *= -1;
                label1.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                label1.Text = number2.ToString();
            }


        }

        private void Removelastnumber(object sender, EventArgs e)
        {
                string removelastnumber = label1.Text;
           
            if (label1.Text.Length > 1)
            {

                removelastnumber = removelastnumber.Remove(removelastnumber.Length -1);
                
                
                label1.Text = removelastnumber.ToString();
                setkeybord(label1.Text);
                
            }
            else
            {
                label1.Text = "";
                
            }
            
            

        }

        private void DarkmodeClick(object sender, EventArgs e)
        {
            if (isDark % 2 == 0)
            {

                this.BackColor = Color.Black;
                this.ForeColor = Color.White;


                darkmodebutton.Text = "Light";
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        Button btndarkmode = (Button)c;

                        btndarkmode.BackColor = Color.FromArgb(24, 24, 24);
                        btndarkmode.ForeColor = Color.White;
                    }
                }


            }
            else
            {
                this.BackColor = Color.FromArgb(218, 218, 218);
                this.ForeColor = Color.Black;

                darkmodebutton.Text = "Dark";

                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        Button btndarkmode = (Button)c;

                        btndarkmode.BackColor = Color.White;
                        btndarkmode.ForeColor = Color.Black;
                    }
                }


            }
            isDark++;
        }

        private void int_to_double(object sender, EventArgs e)
        {
            
            label1.Text += ".";
          
            
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                label1.Text += "0";
                setkeybord(label1.Text);

            }

            else if (e.KeyCode == Keys.NumPad1)
            {
                label1.Text += "1";
                setkeybord(label1.Text);

            }

            else if (e.KeyCode == Keys.NumPad2)
            {
                label1.Text += "2";
                setkeybord(label1.Text);

            }

            else if (e.KeyCode == Keys.NumPad3)
            {
                label1.Text += "3";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad4)
            {
                label1.Text += "4";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad5)
            {
                label1.Text += "5";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad6)
            {
                label1.Text += "6";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad7)
            {
                label1.Text += "7";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad8)
            {
                label1.Text += "8";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad9)
            {
                label1.Text += "9";
                setkeybord(label1.Text);
            }

            else if (e.KeyCode == Keys.Add)
            {

                plus.PerformClick();
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                minus.PerformClick();
            }

            else if (e.KeyCode == Keys.Multiply)
            {
                multiplication.PerformClick();
            }

            else if (e.KeyCode == Keys.Divide)
            {
                Division.PerformClick();
            }

            else if (e.KeyCode == Keys.Return)
            {
                equal.PerformClick();
                this.ActiveControl = history;
            }

            else if (e.KeyCode == Keys.P)
            {
                pow2.PerformClick();

            }

            else if (e.KeyCode == Keys.F)
            {
                factorial.PerformClick();

            }

            else if (e.KeyCode == Keys.Escape)
            {
                cleartext.PerformClick();
            }

            else if (e.KeyCode == Keys.Back)
            {
                backspace.PerformClick();
            }

            else if (e.KeyCode == Keys.B)
            {
                baghimande.PerformClick();
            }

            else if (e.KeyCode == Keys.N)
            {
                negativ.PerformClick();
            }

            else if (e.KeyCode == Keys.Decimal)
            {
                ashar.PerformClick();
            }

            else if (e.KeyCode == Keys.D)
            {
                darkmodebutton.PerformClick();
            }
        }
    }
}






