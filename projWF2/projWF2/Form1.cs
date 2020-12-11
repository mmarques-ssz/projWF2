using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projWF2
{
    public partial class frmSomar : Form
    {
        private Somar s1;

        public frmSomar()
        {
            InitializeComponent();
            s1 = new Somar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            s1.setN1(int.Parse(txtN1.Text));
            s1.setN2(int.Parse(txtN2.Text));
            s1.calcular();
            lblResultado.Text = s1.getResultado().ToString();
        }

        private void btnGetN1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = s1.getN1().ToString();
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            Somar s2;
            s2 = new Somar(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
            s2.calcular();
            lblResultado.Text = s2.getResultado().ToString();
        }

 
    }
}
