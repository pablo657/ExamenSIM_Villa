using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenSIM_Villa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {

        }
        public void validar()
        {

        }

        private void txt_cant_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true; 
            }
        }

        private void txt_Costo_reparacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            //{
            //    MessageBox.Show("Sólo se permiten Números");
            //    e.Handled = true;
            //}


            // ACA PERMITE PONER COMAS, PERO PODES PONER MAS DE UNA ¨OJO¨

            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_garantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_prom_vida_pol_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_prom_vida_pol_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_prom_vida_pol_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }
    }
}
