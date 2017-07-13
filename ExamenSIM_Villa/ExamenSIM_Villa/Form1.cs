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
        private int cantidadAProducir;
        private double costoReparacion;
        private int aniosGarantia;
        private int vidaPol1;
        private int vidaPol2;
        private int vidaPol3;
        //private double costoProducir;
        private double costoArreglar;
        //private double costoTotal;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
           
            validar();
            cantidadAProducir = int.Parse( txt_cant_prod.Text);
            costoArreglar  = double.Parse(txt_Costo_reparacion.Text);
            aniosGarantia = int.Parse(txt_garantia.Text);
            vidaPol1 = int.Parse(txt_prom_vida_pol_1.Text);
            vidaPol2 = int.Parse(txt_prom_vida_pol_2.Text);
            vidaPol3 = int.Parse(txt_prom_vida_pol_3.Text);
            
            Simular(grilla_1,cantidadAProducir,costoArreglar,aniosGarantia,vidaPol1 );
            Simular(grilla_2, cantidadAProducir, costoArreglar, aniosGarantia, vidaPol2);
            Simular(grilla_3, cantidadAProducir, costoArreglar, aniosGarantia, vidaPol3);


        }
        public void Simular(DataGridView grilla, int cantProd, double costoArreglar,int aniosGarantia, int promVida)
        {
            int cont = 0;
            double costoReparacion;
            double costoProducir= CalculoCosto.calcularCosto(promVida);
            double tiempoFalla;
            Random  rdn = new Random ();
            double randomActual;
            double costoTotal;
            double costoAcumulado;
           
            while (cont < cantProd)
            {
                cont++;
                String tieneGarantia = "";
                randomActual= rdn.NextDouble();
                tiempoFalla = Distribuciones.Exponencial(promVida, randomActual);
                int i = grilla.Rows.Add();
                if (tiempoFalla <= aniosGarantia)
                {
                    tieneGarantia = "SI";
                    costoReparacion = costoArreglar;
                }
                else
                {
                    tieneGarantia = "NO";
                    costoReparacion = 0;
                }
                costoTotal = costoProducir + costoReparacion;
                if (i == 0)
                {
                    costoAcumulado = costoTotal;
                }
                else
                {
                    costoAcumulado= double.Parse( grilla.Rows[i-1].Cells[8].Value.ToString()) + costoTotal ;
                }
                grilla.Rows[i].Cells[0].Value =cont ;
                grilla.Rows[i].Cells[1].Value = randomActual;
                grilla.Rows[i].Cells[2].Value = tiempoFalla;
                grilla.Rows[i].Cells[3].Value = aniosGarantia ;
                grilla.Rows[i].Cells[4].Value = tieneGarantia;
                grilla.Rows[i].Cells[5].Value = costoReparacion  ;
                grilla.Rows[i].Cells[6].Value = costoProducir;
                grilla.Rows[i].Cells[7].Value = costoTotal ;
                grilla.Rows[i].Cells[8].Value = costoAcumulado ;
            }
        }
        public void validar()
        {
            if (txt_cant_prod.Text == "" || txt_Costo_reparacion.Text =="" || txt_garantia.Text==""||txt_prom_vida_pol_1.Text==""||txt_prom_vida_pol_2.Text==""||txt_prom_vida_pol_3.Text=="")
            {
                MessageBox.Show("Complete todos los campos");
            }

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
            String cadena = txt_Costo_reparacion.ToString();

            if (cadena.IndexOf(".")==-1)
            {
                e.Handled = false ;
            }
            //if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            //{
            //    MessageBox.Show("Sólo se permiten Números");
            //    e.Handled = true;
            //}


            // ACA PERMITE PONER COMAS, PERO PODES PONER MAS DE UNA ¨OJO¨

            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
