using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pasqua = 20;
            int nereu = 40;
            int popa = 35;
            double conta;

            conta = ((pasqua + nereu + popa) / 3);

            MessageBox.Show("A idade média da familia é: " + conta);

        }
    }
}
