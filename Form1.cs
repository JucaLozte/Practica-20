namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);
            if (edad < 12) MessageBox.Show("Usted es un Niño");
            else
                if (edad < 18) MessageBox.Show("Usted es un Adolescente");
            else
                if (edad < 60) MessageBox.Show("Usted es un Adulto");
            else MessageBox.Show("Usted es un Adulto mayor");
        }
    }
}