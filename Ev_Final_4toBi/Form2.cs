using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Byte Var1 = Byte.Parse(textVar1.Text);
            Byte Var2 = Byte.Parse(textVar2.Text);
            int Promedio = Var1 * Var2;
            MessageBox.Show("El R// es + Promedio");
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Var1 = Byte.Parse(textVar1.Text);
            Byte Var2 = Byte.Parse(textVar2.Text);
            int suma = Var1 + Var2;
            MessageBox.Show(" El R// es + suma");
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(textVar1.Text);
            int Var2 = int.Parse(textVar2.Text);
            int potencia = 1;
            int J = 0;

            while (J != Var2 ) ;
            {
                potencia = potencia * Var1;
                MessageBox.Show("El R// es + Potencia");

            }
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Var1 = float.Parse(textVar1.Text);
            float Var2 = float.Parse(textVar1.Text);
            if (Var1 > 0)
            {
                float divison = Var1 / Var2;
                MessageBox.Show("El R/ es + Division");
            }
            else
            {
                MessageBox.Show("La divison es indefinida");
            }
        }
    }
}
