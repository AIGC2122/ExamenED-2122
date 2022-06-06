using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenED2122
{
    public partial class Form1 : Form
    {
        ;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
           
            double importeAIGC2122= double.Parse(txtImporte.Text);
            double ivaAIGC2122 = 0.21;
            if (rbReducido.Checked == true)  // IVA reducido, 10%
                ivaAIGC2122 = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                ivaAIGC2122 = 0.4;
            importeAIGC2122 = importeAIGC2122 * ivaAIGC2122; // Calculamos el importe con IVA
            cantidadTotalAIGC2122 = importeAIGC2122; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importeAIGC2122);
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(cantidadTotalAIGC2122);
        }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
            {

            }
        }
}
