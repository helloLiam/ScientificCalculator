using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator0630
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(this.num1.Text);
            var number2 = int.Parse(this.num2.Text);
            var finalResult = number1 + number2;
            this.result.Text = finalResult.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(this.num1.Text);
            var number2 = int.Parse(this.num2.Text);
            var finalResult = number1 - number2;
            this.result.Text = finalResult.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(this.num1.Text);
            var number2 = int.Parse(this.num2.Text);
            var finalResult = number1 * number2;
            this.result.Text = finalResult.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(this.num1.Text);
            var number2 = int.Parse(this.num2.Text);
            if (number2!=0)
            {              
                var finalResult = number1 + number2;
                this.result.Text = finalResult.ToString();
            }
            else
            {
                this.result.Text = "被除数不能为 0";
            }
            
        }
    }
}
