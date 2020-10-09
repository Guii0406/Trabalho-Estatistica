using System;
using System.Collections.Generic;
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
            LimparEfocar();
        }
        void Adicionar()
        {
            listaNumeros.Add((double)numericUpDown1.Value);
            richTextBox1.AppendText($"{listaNumeros[listaNumeros.Count - 1]} - ");
            LimparEfocar();
        }
        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                Adicionar();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar();
        }
        private void LimparEfocar()
        {
            numericUpDown1.Value = 0;
            numericUpDown1.Focus();
            numericUpDown1.Select(0, 4);
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
