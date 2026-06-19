using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//topla
        {
          
            try
            {
                MessageBox.Show((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString());
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                    errorProvider1.SetError(textBox1,"Add the variable!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                    errorProvider1.SetError(textBox2, "Add the variable!");
                }
                
            }
            if(button1.Enabled==true)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)//Properties
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Warning";
            toolTip1.IsBalloon = true;
            textBox1.GotFocus += textBox1_GotFocus;
            textBox2.GotFocus += textBox2_GotFocus;
            this.HelpButton=true; 
            this .MaximizeBox=false;
            this.MinimizeBox = false;
            helpProvider1.SetHelpString(textBox1,"hello exist!");
            helpProvider1.HelpNamespace = Application.StartupPath + "https://www.google.com/search?q=autocad+&safe=active&sca_esv=84c550665db3d809&sca_upv=1&sxsrf=ACQVn0_6NDThzuDhpCZSjK77AKrBVwUVMg%3A1712234989173&ei=7aEOZquSCp-Exc8P9uqg4Ao&ved=0ahUKEwjrvLSyzKiFAxUfQvEDHXY1CKwQ4dUDCBA&uact=5&oq=autocad+&gs_lp=Egxnd3Mtd2l6LXNlcnAiCGF1dG9jYWQgSIhRUABYsktwAHgAkAEAmAEAoAEAqgEAuAEDyAEA-AEBmAIAoAIAqAIAmAMAkgcAoAcA&sclient=gws-wiz-serp";
            helpProvider1.SetHelpKeyword(textBox1, "methods");
            helpProvider1.SetHelpNavigator(textBox1,HelpNavigator.AssociateIndex);
            helpProvider1.SetShowHelp(textBox1,true);
           
        }

        void textBox2_GotFocus(object sender, EventArgs e)//focus 2
        {
            toolTip1.Show("TextBox2 must Number", textBox2, textBox2.Width, textBox2.Height - 80, 5000);
        }

        void textBox1_GotFocus(object sender, EventArgs e)
        {
            toolTip1.Show("TextBox1 must Number", textBox1, textBox1.Width, textBox1.Height, 5000);
        }

        private void button2_Click(object sender, EventArgs e)//focus 1
        {
          
            try
            {
                MessageBox.Show((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString());
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                    errorProvider1.SetError(textBox1, "Add the variable!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                    errorProvider1.SetError(textBox2, "Add the variable!");
                }

            }
            if (button2.Enabled == true)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)//çarpma 
        {
           
            try
            {
                MessageBox.Show((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString());
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                    errorProvider1.SetError(textBox1, "Add the variable!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                    errorProvider1.SetError(textBox2, "Add the variable!");
                }
            }
            if (button3.Enabled == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)//bölme
        {

            try
            {
                MessageBox.Show((Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString());
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                    errorProvider1.SetError(textBox1, "Add the variable!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                      errorProvider1.SetError(textBox2,"Add the variable!");
                }
            }
            if (button4.Enabled == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)//ortalama
        {
            try
            {
                MessageBox.Show(((Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)) / 2).ToString());
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)//karesi 1
        {
            button6.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text))).ToString()));
            }
            catch
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)//küpü 1
        {
            button7.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)))).ToString());
            }
            catch
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)//karesi 2
        {
            button8.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text))).ToString()));
            }
            catch
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)//küpü 2
        {
            button9.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)))).ToString());
            }
            catch
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)//karesi 3
        {
            button10.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text))).ToString()));
            }
            catch
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)//küpü 3
        {
            button11.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)))).ToString());
            }
            catch
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)//küpü 4
        {
            button13.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)) * (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)) * (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)))).ToString());
            }
            catch
            {
                MessageBox.Show(" 0'a Bölünemez!");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)//karesi 4
        {
            button12.Enabled = false;
            try
            {
                MessageBox.Show((((Convert.ToDouble(textBox1.Text) /Convert.ToDouble(textBox2.Text)) * (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text))).ToString()));
            }
            catch
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox1 must number!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("TextBox2 must number!");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)//sıfırla
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            errorProvider1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Bütün değerler sıfırlamdı .");
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

