using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;


namespace caculator1
{
    public partial class caculator : Form
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ILog logger = LogManager.GetLogger(typeof(caculator));
            logger.Info("hien thi thong bao");

        }
        private static readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
      
           

            Double value = 0;
        Double memory;
        String operation = "";
        bool operation_pressed = false;
        

    public caculator()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender,EventArgs e)
        {

            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;



        }
      
        private void button21_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "×":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
               
                default:
                    break;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = (Double.Parse(result.Text) * Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("-"))
                result.Text = result.Text.Remove(0, 1);
            else
                result.Text = "-" + result.Text;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result.Text);
        }

        private void pasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text += Clipboard.GetText();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            result.Text = memory.ToString();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(result.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            memory = memory + Double.Parse(result.Text);
            result.Text = memory.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            memory = memory - Double.Parse(result.Text);
            result.Text = memory.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            memory = 0;

        }

        private void caculator_Load(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            result.Text = Math.Sin(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            result.Text = Math.Cos(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            result.Text = Math.Tan(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            result.Text = Math.Exp(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            result.Text = Math.Log(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }




        private void button47_Click(object sender, EventArgs e)
        {

            result.Text = Math.Tanh(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button48_Click(object sender, EventArgs e)
        {

            result.Text = Math.Abs(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button49_Click(object sender, EventArgs e)
        {

            result.Text = Math.Cosh(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width =320;
            result.Width = 277;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 590;
          


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            result.Text = (Double.Parse(result.Text) * Double.Parse(result.Text) * Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(a);

        }

        private void button53_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            memory = memory + Double.Parse(result.Text);
            result.Text = memory.ToString();

        }

        private void button46_Click(object sender, EventArgs e)
        {
            result.Text = Math.Sinh(Double.Parse(result.Text)).ToString();
            operation_pressed = true;

        }

        private void button43_Click(object sender, EventArgs e)
        {
            result.Text = Math.Log10(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            result.Text = Math.Acos(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            result.Text = Math.Asin(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            result.Text = Math.Atan(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            result.Text = Math.Sign(Double.Parse(result.Text)).ToString();
            operation_pressed = true;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            result.Text =(Math.PI).ToString();
            operation_pressed = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            result.Text = (Math.E).ToString();
            operation_pressed = true;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            int n = int.Parse(result.Text);
            
            int s = 1;//khởi tạo giá trị ban đầu
            for (int i = 1; i <= n; i++)
            {
                s = s * i;
            }
            result.Text = s.ToString();

        }

        private void button38_Click(object sender, EventArgs e)
        {
          
            Random rd = new Random();

            result.Text = rd.Next(0, 9).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            result.Text = "memory";
        }
    }
}


