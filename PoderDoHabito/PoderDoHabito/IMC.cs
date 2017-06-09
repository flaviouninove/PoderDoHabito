using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderDoHabito
{
    public partial class IMC : Form
    {
        double soma = 0;
        double peso = 0;
        double altura = 0;

        public IMC()
        {
            InitializeComponent();
        }

        private void IMC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peso = double.Parse(txtpeso.Text);
            altura = double.Parse(txtaltura.Text);

            soma = (peso / (altura * altura));

            lbimc.Text = Convert.ToString(soma);

            if (soma < 18.5)
            {
                MessageBox.Show("Peso abaixo do normal!");
                var ma = new IncentivoM();
                ma.ShowDialog();

            }

            else if (soma >= 18.6 && soma <= 24.9)
            {
                MessageBox.Show("Peso Ideal!");
                MessageBox.Show("Parabens!!! Corpo são, mente sã");
                var peso = new PesoIdeal();
                peso.ShowDialog();
            }

            else if (soma >= 25 && soma < 29.9)
            {

                MessageBox.Show("Você esta um poquinho acima do Peso!");
                var gordo = new IncentivoG();
                gordo.ShowDialog();
            }
            else if (soma == 30 && soma <= 34.9)
            {
                MessageBox.Show("Obesidade 1º Grau");
                var gordo1 = new IncentivoG();
                gordo1.ShowDialog();
            }
            else if (soma == 35 && soma <= 39.9)
            {
                MessageBox.Show("Obesidade 2º Grau");
                var gordo2 = new IncentivoG();
                gordo2.ShowDialog();
            }
            else if (soma >= 40)
                MessageBox.Show("Obsidade 3ºGrau");
                var gordo3 = new IncentivoG();
                gordo3.ShowDialog();
        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }   
        }
    }
}
