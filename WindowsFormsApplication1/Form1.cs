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
        Random rnd = new Random();
        double chisloA, chisloB, chisloX, chisloY, stepenbA, stepenbB;
        string Key1, Key2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RandomAandB_Click(object sender, EventArgs e) // Генерируем случайно число А и В
        {
            RandomA.Text = (rnd.Next(100)).ToString();
            chisloA = Convert.ToDouble(RandomA.Text);
            RandomB.Text = (rnd.Next(100)).ToString();
            chisloB = Convert.ToDouble(RandomB.Text);
        }

        private void RandX_Click(object sender, EventArgs e) // Генерируем случайно число Х
        {
            RandomX.Text = (rnd.Next(10)).ToString();
            chisloX = Convert.ToDouble(RandomX.Text);
        }

        private void RandY_Click(object sender, EventArgs e) // Генерируем случайно число У
        {
            RandomY.Text = (rnd.Next(10)).ToString();
            chisloY = Convert.ToDouble(RandomY.Text);
        }

        private void generiryemkey_Click(object sender, EventArgs e)
        {
            if (RandomA.Text == "" || RandomB.Text == "" || RandomX.Text == "" || RandomY.Text == "") //проверка текстбоксов на пустоту
            {
                MessageBox.Show("Сгенерируйте все переменные");
            }

            stepenbA = (Math.Pow(chisloB, chisloX) % chisloA); // В возводим в степень х и мод А
            stepenbB = (Math.Pow(chisloB, chisloY) % chisloA); // В возводим в степень у и мод А

            X.Text = Convert.ToString(stepenbA % chisloA); // Вывовдим в текст бокс Х
            Y.Text = Convert.ToString(stepenbB % chisloA); // Вывовдим в текст бокс У
            

            Key1 = Convert.ToString(((Math.Pow(stepenbA, chisloY) % chisloA))); // степень А возводим в степень у и мод А
            Key2 = Convert.ToString(((Math.Pow(stepenbB, chisloX) % chisloA))); //степень В возводим в степень х и мод А

            k1.Text = Convert.ToString(Key1); //Вывовдим в текст бокс к1
            k2.Text = Convert.ToString(Key2); //Вывовдим в текст бокс к2

        }
    }
}