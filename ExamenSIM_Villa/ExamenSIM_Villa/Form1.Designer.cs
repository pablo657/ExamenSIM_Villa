namespace ExamenSIM_Villa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cant_prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_garantia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_politica_1 = new System.Windows.Forms.GroupBox();
            this.grilla_1 = new System.Windows.Forms.DataGridView();
            this.nAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_prom_vida_pol_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grilla_2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_prom_vida_pol_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grilla_3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_prom_vida_pol_3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.txt_Costo_reparacion = new System.Windows.Forms.TextBox();
            this.grp_politica_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidades a producir en el año=";
            // 
            // txt_cant_prod
            // 
            this.txt_cant_prod.Location = new System.Drawing.Point(174, 15);
            this.txt_cant_prod.Name = "txt_cant_prod";
            this.txt_cant_prod.Size = new System.Drawing.Size(47, 20);
            this.txt_cant_prod.TabIndex = 1;
            this.txt_cant_prod.Text = "120";
            this.txt_cant_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_prod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Años de garantia =";
            // 
            // txt_garantia
            // 
            this.txt_garantia.Location = new System.Drawing.Point(522, 15);
            this.txt_garantia.Name = "txt_garantia";
            this.txt_garantia.Size = new System.Drawing.Size(47, 20);
            this.txt_garantia.TabIndex = 3;
            this.txt_garantia.Text = "5";
            this.txt_garantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_garantia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo de reparación=";
            // 
            // grp_politica_1
            // 
            this.grp_politica_1.Controls.Add(this.grilla_1);
            this.grp_politica_1.Controls.Add(this.txt_prom_vida_pol_1);
            this.grp_politica_1.Controls.Add(this.label4);
            this.grp_politica_1.Location = new System.Drawing.Point(15, 41);
            this.grp_politica_1.Name = "grp_politica_1";
            this.grp_politica_1.Size = new System.Drawing.Size(954, 179);
            this.grp_politica_1.TabIndex = 6;
            this.grp_politica_1.TabStop = false;
            this.grp_politica_1.Text = "Politica 1";
            // 
            // grilla_1
            // 
            this.grilla_1.AllowUserToAddRows = false;
            this.grilla_1.AllowUserToDeleteRows = false;
            this.grilla_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAuto,
            this.rdn,
            this.tFalla,
            this.tGarantia,
            this.isGarantia,
            this.costArreglo,
            this.costProd,
            this.costTotal,
            this.costAcum});
            this.grilla_1.Location = new System.Drawing.Point(20, 51);
            this.grilla_1.Name = "grilla_1";
            this.grilla_1.ReadOnly = true;
            this.grilla_1.RowHeadersVisible = false;
            this.grilla_1.Size = new System.Drawing.Size(905, 128);
            this.grilla_1.TabIndex = 10;
            // 
            // nAuto
            // 
            this.nAuto.HeaderText = "Nro de Auto";
            this.nAuto.Name = "nAuto";
            this.nAuto.ReadOnly = true;
            // 
            // rdn
            // 
            this.rdn.HeaderText = "Random";
            this.rdn.Name = "rdn";
            this.rdn.ReadOnly = true;
            // 
            // tFalla
            // 
            this.tFalla.HeaderText = "Tiempo de falla";
            this.tFalla.Name = "tFalla";
            this.tFalla.ReadOnly = true;
            // 
            // tGarantia
            // 
            this.tGarantia.HeaderText = "Garantia";
            this.tGarantia.Name = "tGarantia";
            this.tGarantia.ReadOnly = true;
            // 
            // isGarantia
            // 
            this.isGarantia.HeaderText = "Está en Garantia";
            this.isGarantia.Name = "isGarantia";
            this.isGarantia.ReadOnly = true;
            // 
            // costArreglo
            // 
            this.costArreglo.HeaderText = "Costo de Arreglo";
            this.costArreglo.Name = "costArreglo";
            this.costArreglo.ReadOnly = true;
            // 
            // costProd
            // 
            this.costProd.HeaderText = "Costo Producción";
            this.costProd.Name = "costProd";
            this.costProd.ReadOnly = true;
            // 
            // costTotal
            // 
            this.costTotal.HeaderText = "Costo Total";
            this.costTotal.Name = "costTotal";
            this.costTotal.ReadOnly = true;
            // 
            // costAcum
            // 
            this.costAcum.HeaderText = "Costo Acumulado";
            this.costAcum.Name = "costAcum";
            this.costAcum.ReadOnly = true;
            // 
            // txt_prom_vida_pol_1
            // 
            this.txt_prom_vida_pol_1.Location = new System.Drawing.Point(150, 13);
            this.txt_prom_vida_pol_1.Name = "txt_prom_vida_pol_1";
            this.txt_prom_vida_pol_1.Size = new System.Drawing.Size(47, 20);
            this.txt_prom_vida_pol_1.TabIndex = 9;
            this.txt_prom_vida_pol_1.Text = "4";
            this.txt_prom_vida_pol_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prom_vida_pol_1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vida promedio en años (m)=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grilla_2);
            this.groupBox1.Controls.Add(this.txt_prom_vida_pol_2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politica 2";
            // 
            // grilla_2
            // 
            this.grilla_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.grilla_2.Location = new System.Drawing.Point(20, 45);
            this.grilla_2.Name = "grilla_2";
            this.grilla_2.RowHeadersVisible = false;
            this.grilla_2.Size = new System.Drawing.Size(905, 128);
            this.grilla_2.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro de Auto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Random";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tiempo de falla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Garantia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Está en Garantia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Costo de Arreglo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo Producción";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Costo Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Costo Acumulado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // txt_prom_vida_pol_2
            // 
            this.txt_prom_vida_pol_2.Location = new System.Drawing.Point(150, 13);
            this.txt_prom_vida_pol_2.Name = "txt_prom_vida_pol_2";
            this.txt_prom_vida_pol_2.Size = new System.Drawing.Size(47, 20);
            this.txt_prom_vida_pol_2.TabIndex = 10;
            this.txt_prom_vida_pol_2.Text = "5";
            this.txt_prom_vida_pol_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prom_vida_pol_2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vida promedio en años (m)=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grilla_3);
            this.groupBox2.Controls.Add(this.txt_prom_vida_pol_3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 179);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Politica 3";
            // 
            // grilla_3
            // 
            this.grilla_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.grilla_3.Location = new System.Drawing.Point(20, 39);
            this.grilla_3.Name = "grilla_3";
            this.grilla_3.RowHeadersVisible = false;
            this.grilla_3.Size = new System.Drawing.Size(905, 128);
            this.grilla_3.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Nro de Auto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Random";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Tiempo de falla";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Garantia";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Está en Garantia";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Costo de Arreglo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Costo Producción";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Costo Total";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Costo Acumulado";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // txt_prom_vida_pol_3
            // 
            this.txt_prom_vida_pol_3.Location = new System.Drawing.Point(150, 13);
            this.txt_prom_vida_pol_3.Name = "txt_prom_vida_pol_3";
            this.txt_prom_vida_pol_3.Size = new System.Drawing.Size(47, 20);
            this.txt_prom_vida_pol_3.TabIndex = 12;
            this.txt_prom_vida_pol_3.Text = "6";
            this.txt_prom_vida_pol_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prom_vida_pol_3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vida promedio en años (m)=";
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.ForeColor = System.Drawing.Color.Maroon;
            this.btn_simular.Location = new System.Drawing.Point(708, 611);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 8;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // txt_Costo_reparacion
            // 
            this.txt_Costo_reparacion.Location = new System.Drawing.Point(356, 15);
            this.txt_Costo_reparacion.Name = "txt_Costo_reparacion";
            this.txt_Costo_reparacion.Size = new System.Drawing.Size(47, 20);
            this.txt_Costo_reparacion.TabIndex = 5;
            this.txt_Costo_reparacion.Text = "5";
            this.txt_Costo_reparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Costo_reparacion_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 646);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_politica_1);
            this.Controls.Add(this.txt_Costo_reparacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_garantia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cant_prod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Final SIM - ej 318";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_politica_1.ResumeLayout(false);
            this.grp_politica_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cant_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_garantia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_politica_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.TextBox txt_prom_vida_pol_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prom_vida_pol_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prom_vida_pol_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Costo_reparacion;
        private System.Windows.Forms.DataGridView grilla_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn isGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn costProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn costTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn costAcum;
        private System.Windows.Forms.DataGridView grilla_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView grilla_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}

