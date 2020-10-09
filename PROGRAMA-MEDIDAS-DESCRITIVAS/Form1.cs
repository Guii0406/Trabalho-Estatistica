using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA_MEDIDAS_DESCRITIVAS
{
    public partial class Form1 : Form
    {
        List<double> listaNumeros = new List<double>();
        double mediaAritmetica;
        double mediana;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaNumeros.Add((double)numericUpDown1.Value);
            Atualizar();
            numericUpDown1.Value = 0;
        }

        private void Atualizar()
        {
            richTextBox1.Clear();

            foreach(double numero in listaNumeros)
            {
                richTextBox1.AppendText($"{numero}, ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mediaAritmetica = Calcula.MediaAritmetica(listaNumeros);
            mediana = Calcula.Mediana(listaNumeros);


            MessageBox.Show($"Media aritmética: {mediaAritmetica}\nMediana: {mediana}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listaNumeros.Clear();
            richTextBox1.Clear();
        }

    }
}
