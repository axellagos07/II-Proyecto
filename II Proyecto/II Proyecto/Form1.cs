using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(Nota1textBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2textBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3textBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4textBox.Text);

            decimal Promedio = await promedioAsync(nota1, nota2, nota3, nota4);
            MessageBox.Show("El promedio es: " + Promedio, "PROMEDIO FINAL");

            Nota1textBox.Clear();
            Nota2textBox.Clear();
            Nota3textBox.Clear();
            Nota4textBox.Clear();

        }

        private async Task<decimal> promedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
    }
}
