using SequenceOfNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CA1416
namespace SequenceOfNumbers
{
    public partial class Form1 : Form
    {
        private Cont container;
        public Form1()
        {
            InitializeComponent();
            container = new Cont(textBox8);
        }
        private SequenceOfNumbers SN;
        private void button1_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox1.Text);
            double f = Convert.ToDouble(textBox2.Text);
            double d = Convert.ToDouble(textBox3.Text);
            SN = new Arithmetic(N, f, d);
            container.AddSequence(new Arithmetic(N, f, d));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox1.Text);
            double f = Convert.ToDouble(textBox2.Text);
            double d = Convert.ToDouble(textBox3.Text);
            SN = new Arithmetic(N, f, d);
            textBox13.Text = SN.ToString();
            textBox12.Text = Convert.ToString(SN.SumN(N));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox6.Text);
            double f = Convert.ToDouble(textBox5.Text);
            double r = Convert.ToDouble(textBox4.Text);
            container.AddSequence(new Geometric(N, f, r));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox6.Text);
            double f = Convert.ToDouble(textBox5.Text);
            double r = Convert.ToDouble(textBox4.Text);
            SN = new Geometric(N, f, r);
            textBox14.Text = SN.ToString();
            textBox15.Text = Convert.ToString(SN.SumN(N));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox7.Text);
            double f = Convert.ToDouble(textBox9.Text);
            double s = Convert.ToDouble(textBox10.Text);
            container.AddSequence(new Fibonacci(N, f, s));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textBox7.Text);
            double f = Convert.ToDouble(textBox9.Text);
            double s = Convert.ToDouble(textBox10.Text);
            SN = new Fibonacci(N, f, s);
            textBox16.Text = SN.ToString();
            textBox17.Text = Convert.ToString(SN.SumN(N));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label24.Text = Convert.ToString(container.SumAllSequences());
            textBox18.Text = Convert.ToString(container.FindSequenceWithMaxSum());
            container.Output();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox11.Text);
            container.RemoveSequence((int)i);
        }

    }
#pragma warning restore CA1416
}
