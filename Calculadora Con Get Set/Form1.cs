using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Con_Get_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            clsuma sum = new clsuma();
            sum.V1 = int.Parse(txtv1.Text);
            sum.V2 = int.Parse(txtv2.Text);

            txtres.Text = sum.sumar().ToString();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            clresta res = new clresta();
            res.V1 = int.Parse(txtv1.Text);
            res.V2 = int.Parse(txtv2.Text);

            txtres.Text = res.restar().ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            clmultiplicacion mult = new clmultiplicacion();
            mult.V1 = int.Parse(txtv1.Text);
            mult.V2 = int.Parse(txtv2.Text);

            txtres.Text = mult.multiplicar().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cldivision div = new cldivision(); 
            div.V1 = double.Parse(txtv1.Text);
            div.V2 = double.Parse(txtv2.Text);

            txtres.Text = div.dividir().ToString();

        }
    }
}
