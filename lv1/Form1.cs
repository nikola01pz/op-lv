namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        int btn1Counter = 0;
        int btn2Counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1Counter++;
            label1.Text = "Button 1 pressed " + btn1Counter.ToString() + " times";
            label3.Text = "Button 1 pressed";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn2Counter++;
            label2.Text = "Button 2 pressed " + btn1Counter.ToString() + " times";
            label3.Text = "Button 2 pressed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                label7.Text = Convert.ToString(root1);
                label12.Text = Convert.ToString(root2);
            }

            // condition for real and equal roots
            else if (discriminant == 0)
            {
                double root1 = -b / (2 * a);
                double root2 = root1;
                label7.Text = Convert.ToString(root1);
                label12.Text = Convert.ToString(root2);
            }

            // if roots are not real
            else
            {
                double realPart = -b / (2 * a);
                double imagPart = Math.Sqrt(-discriminant) / (2 * a);
                string root1 = realPart + "+" + imagPart + "i";
                string root2 = realPart + "-" + imagPart + "i";
                label7.Text = root1;
                label12.Text = root2;
            }

            //label7.Text = Convert.ToString(result);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}