using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSIM_Villa
{
    

    public partial class Form1 : Form
    {
        private long cantidadAProducir;
        private double costoReparacion;
        private int aniosGarantia;
        private int vidaPol1;
        private int vidaPol2;
        private int vidaPol3;
        //private double costoProducir;
        private double costoArreglar;
        //private double costoTotal;
        double costo_pol_1;
        double costo_pol_2;
        double costo_pol_3;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {

           
            if (validar () )
            {
                if (int.Parse(txt_desde.Text) >= int.Parse(txt_hasta.Text))
                {
                    MessageBox.Show("La fila desde no puede ser mayor a la fila hasta");
                    return;
                }
                if (int.Parse(txt_hasta.Text) <= int.Parse(txt_desde.Text))
                {
                    MessageBox.Show("La fila hasta no puede ser menor a la fila desde");
                    return;
                }

                cantidadAProducir = long.Parse(txt_cant_prod.Text);
                costoArreglar = double.Parse(txt_Costo_reparacion.Text);
                aniosGarantia = int.Parse(txt_garantia.Text);
                vidaPol1 = int.Parse(txt_prom_vida_pol_1.Text);
                vidaPol2 = int.Parse(txt_prom_vida_pol_2.Text);
                vidaPol3 = int.Parse(txt_prom_vida_pol_3.Text);

                Simular(grilla_1, cantidadAProducir, costoArreglar, aniosGarantia, vidaPol1);
                Simular(grilla_2, cantidadAProducir, costoArreglar, aniosGarantia, vidaPol2);
                Simular(grilla_3, cantidadAProducir, costoArreglar, aniosGarantia, vidaPol3);

                btn_simular.Enabled = false;
                ObtenerMejorPolitica(); 
            }
          

        }
        public void ObtenerMejorPolitica()
        {
            if (costo_pol_1 < costo_pol_2 && costo_pol_1 < costo_pol_3)
            {
                lbl_mejor_politica.Text = "1";
                txt_Resultado.Text = costo_pol_1.ToString();
            }
            if (costo_pol_2 < costo_pol_1 && costo_pol_2 < costo_pol_3)
            {
                lbl_mejor_politica.Text = "2";
                txt_Resultado.Text = costo_pol_2.ToString();
            }
            if (costo_pol_3 < costo_pol_2 && costo_pol_3 < costo_pol_1)
            {
                lbl_mejor_politica.Text = "3";
                txt_Resultado.Text = costo_pol_3.ToString();
            }
        }
      
       
        public void Simular(DataGridView grilla, long cantProd, double costoArreglar,int aniosGarantia, int promVida)
        {
            long  cont = 0;
            double costoReparacion =0.00;
            double costoProducir= CalculoCosto.calcularCosto(promVida);
            double tiempoFalla;
            //Random  rdn = new Random ();
            double randomActual;
            double costoTotal;
            double costoAcumulado=0.00;
           

            while (cont < cantProd)
            {
                    cont++;
                String tieneGarantia = "";
                randomActual= rand.NextDouble();
                tiempoFalla = Distribuciones.Exponencial(promVida, randomActual);
                

                if (tiempoFalla <= aniosGarantia)
                {
                    tieneGarantia = "SI";
                    costoReparacion = costoArreglar;
                }
                else
                {
                    tieneGarantia = "NO";
                    costoReparacion = 0.00;
                }
                costoTotal = costoProducir + costoReparacion;
                costoAcumulado =Math.Round(costoAcumulado,1) + Math.Round(costoTotal, 1);

               
                if (cont >= int.Parse(txt_desde.Text)  && cont <= int.Parse(txt_hasta.Text))
                {
                    int i = grilla.Rows.Add();
                    grilla.Rows[i].Cells[0].Value = cont;
                    grilla.Rows[i].Cells[1].Value = randomActual;
                    grilla.Rows[i].Cells[2].Value = tiempoFalla;
                    grilla.Rows[i].Cells[3].Value = aniosGarantia;
                    grilla.Rows[i].Cells[4].Value = tieneGarantia;
                    grilla.Rows[i].Cells[5].Value = costoReparacion;
                    grilla.Rows[i].Cells[6].Value = costoProducir;
                    grilla.Rows[i].Cells[7].Value = costoTotal;
                    grilla.Rows[i].Cells[8].Value = costoAcumulado; 
                }
                if (grilla == grilla_1)
                {
                    costo_pol_1 = costoAcumulado;
                }
                if (grilla == grilla_2)
                {
                    costo_pol_2 = costoAcumulado;
                }
                if (grilla == grilla_3)
                {
                    costo_pol_3 = costoAcumulado;
                }
            }
        }
        public Boolean  validar()
        {
            if (txt_cant_prod.Text == "" || txt_Costo_reparacion.Text =="" || txt_garantia.Text==""||txt_prom_vida_pol_1.Text==""||txt_prom_vida_pol_2.Text==""||txt_prom_vida_pol_3.Text==""|| txt_hasta.Text=="" || txt_desde.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void txt_cant_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
                
            }
            if (txt_cant_prod.Text == "0" )
            {
                MessageBox.Show("Debe ser mayor a 0");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_cant_prod_TextChanged(object sender, EventArgs e)
        {
            txt_hasta.Text = txt_cant_prod.Text;
        }

        private void txt_hasta_TextChanged(object sender, EventArgs e)
        {

            if (txt_cant_prod.Text != "")
            {
                if (txt_hasta.Text != "")
                {
                    if (int.Parse(txt_hasta.Text) <= int.Parse(txt_cant_prod.Text))
                    {
                        if (txt_cant_prod.Text != "" && int.Parse(txt_hasta.Text) > 5)
                        {
                            int res = int.Parse(txt_hasta.Text) - 5;
                            txt_desde.Text = res.ToString();
                        }
                        else
                        {
                            txt_desde.Text = "1";
                        }
                    }
                    else
                    {
                        MessageBox.Show("no puede ser mayor que la cantidad a producir");
                        txt_hasta.Text = txt_cant_prod.Text;

                    }
                }
                else {
                    MessageBox.Show("ingrese valor");
                }

            }
           
            else
            {
                MessageBox.Show("ingrese valor");
                txt_desde.Text = "";
                txt_hasta.Text = "";
            }
        }

        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txt_cant_prod.Text = "120";
            txt_Costo_reparacion.Text = "5";
            txt_garantia.Text = "5";
            txt_desde.Text = "115";
            txt_hasta.Text = "120";
            txt_prom_vida_pol_1.Text = "4";
            txt_prom_vida_pol_2.Text = "5";
            txt_prom_vida_pol_3.Text = "6";
            grilla_1.Rows.Clear();
            grilla_2.Rows.Clear();
            grilla_3.Rows.Clear();
            lbl_mejor_politica.Text = "";
            txt_Resultado.Text = "";
            btn_simular.Enabled = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
