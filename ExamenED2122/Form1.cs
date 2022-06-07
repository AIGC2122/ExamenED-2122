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
        double cantidadTotal;
        public Form1()
            {
            InitializeComponent();
            }

        private void btCalcular_Click(object sender, EventArgs e)
            {
            double importe = Double.Parse(txtImporte.Text);
            double IVA = 0.21;

            if (rbReducido.Checked == true)  // IVA reducido, 10%
                IVA = 0.1;
            if (rbSuper.Checked == true)  // IVA super reducido, 4%
                IVA = 0.4;
            importe = importe * IVA; // Calculamos el importe con IVA
            cantidadTotal = importe; // Se lo añadimos a la cantidad total
            txtResultado.Text = Convert.ToString(importe);
            }

        private void btTotal_Click(object sender, EventArgs e)
            {
            txtResultado.Text = Convert.ToString(cantidadTotal);
            }
        }
    }