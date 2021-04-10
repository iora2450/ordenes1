namespace ordenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbvendedor = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbproductos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbpul = new System.Windows.Forms.RadioButton();
            this.rbcm = new System.Windows.Forms.RadioButton();
            this.txtlargo_bn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtancho_bn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtlargo_bs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtancho_bs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtalto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.dtfechafin);
            this.splitContainer1.Panel1.Controls.Add(this.dtfechainicio);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.cmbvendedor);
            this.splitContainer1.Panel1.Controls.Add(this.cmbestado);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbcliente);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "COMPLETADO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "CANCELADO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "PENDIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "EN TRABAJO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtfechafin
            // 
            this.dtfechafin.Enabled = false;
            this.dtfechafin.Location = new System.Drawing.Point(406, 78);
            this.dtfechafin.Name = "dtfechafin";
            this.dtfechafin.Size = new System.Drawing.Size(94, 20);
            this.dtfechafin.TabIndex = 15;
            // 
            // dtfechainicio
            // 
            this.dtfechainicio.Enabled = false;
            this.dtfechainicio.Location = new System.Drawing.Point(406, 49);
            this.dtfechainicio.Name = "dtfechainicio";
            this.dtfechainicio.Size = new System.Drawing.Size(94, 20);
            this.dtfechainicio.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbvendedor
            // 
            this.cmbvendedor.FormattingEnabled = true;
            this.cmbvendedor.Location = new System.Drawing.Point(602, 49);
            this.cmbvendedor.Name = "cmbvendedor";
            this.cmbvendedor.Size = new System.Drawing.Size(146, 21);
            this.cmbvendedor.TabIndex = 12;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "PENDIENTE",
            "CANCELADO",
            "EN TRABAJO",
            "COMPLETADO"});
            this.cmbestado.Location = new System.Drawing.Point(602, 76);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(146, 21);
            this.cmbestado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ESTADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "VENDEDOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FECHA FIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA INICIO:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA:";
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(83, 77);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(200, 21);
            this.cmbcliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE ORDEN ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtcomentario);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.txtcantidad);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.cmbproductos);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rbpul);
            this.splitContainer2.Panel2.Controls.Add(this.rbcm);
            this.splitContainer2.Panel2.Controls.Add(this.txtlargo_bn);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.txtancho_bn);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.txtlargo_bs);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.txtancho_bs);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.txtancho);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.txtalto);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Size = new System.Drawing.Size(794, 320);
            this.splitContainer2.SplitterDistance = 377;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(35, 149);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(339, 162);
            this.txtcomentario.TabIndex = 12;
            this.txtcomentario.Text = "comentario temporal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "COMENTARIO:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(109, 73);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(200, 20);
            this.txtcantidad.TabIndex = 10;
            this.txtcantidad.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "CANTIDAD:";
            // 
            // cmbproductos
            // 
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(109, 15);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(200, 21);
            this.cmbproductos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "PRODUCTO:";
            // 
            // rbpul
            // 
            this.rbpul.AutoSize = true;
            this.rbpul.Location = new System.Drawing.Point(194, 15);
            this.rbpul.Name = "rbpul";
            this.rbpul.Size = new System.Drawing.Size(83, 17);
            this.rbpul.TabIndex = 25;
            this.rbpul.Text = "PULGADAS";
            this.rbpul.UseVisualStyleBackColor = true;
            this.rbpul.CheckedChanged += new System.EventHandler(this.rbpul_CheckedChanged);
            // 
            // rbcm
            // 
            this.rbcm.AutoSize = true;
            this.rbcm.Checked = true;
            this.rbcm.Location = new System.Drawing.Point(44, 15);
            this.rbcm.Name = "rbcm";
            this.rbcm.Size = new System.Drawing.Size(119, 17);
            this.rbcm.TabIndex = 24;
            this.rbcm.TabStop = true;
            this.rbcm.Text = "CENTRIMENTROS";
            this.rbcm.UseVisualStyleBackColor = true;
            this.rbcm.CheckedChanged += new System.EventHandler(this.rbcm_CheckedChanged);
            // 
            // txtlargo_bn
            // 
            this.txtlargo_bn.Location = new System.Drawing.Point(128, 266);
            this.txtlargo_bn.Name = "txtlargo_bn";
            this.txtlargo_bn.Size = new System.Drawing.Size(200, 20);
            this.txtlargo_bn.TabIndex = 22;
            this.txtlargo_bn.Text = "0";
            this.txtlargo_bn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlargo_bn_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "LARGO_BN";
            // 
            // txtancho_bn
            // 
            this.txtancho_bn.Location = new System.Drawing.Point(128, 231);
            this.txtancho_bn.Name = "txtancho_bn";
            this.txtancho_bn.Size = new System.Drawing.Size(200, 20);
            this.txtancho_bn.TabIndex = 20;
            this.txtancho_bn.Text = "0";
            this.txtancho_bn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtancho_bn_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ANCHO_BN";
            // 
            // txtlargo_bs
            // 
            this.txtlargo_bs.Location = new System.Drawing.Point(128, 194);
            this.txtlargo_bs.Name = "txtlargo_bs";
            this.txtlargo_bs.Size = new System.Drawing.Size(200, 20);
            this.txtlargo_bs.TabIndex = 18;
            this.txtlargo_bs.Text = "0";
            this.txtlargo_bs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlargo_bs_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "LARGO_BS";
            // 
            // txtancho_bs
            // 
            this.txtancho_bs.Location = new System.Drawing.Point(128, 148);
            this.txtancho_bs.Name = "txtancho_bs";
            this.txtancho_bs.Size = new System.Drawing.Size(200, 20);
            this.txtancho_bs.TabIndex = 16;
            this.txtancho_bs.Text = "0";
            this.txtancho_bs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtancho_bs_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "ANCHO_BS";
            // 
            // txtancho
            // 
            this.txtancho.Location = new System.Drawing.Point(128, 102);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(200, 20);
            this.txtancho.TabIndex = 14;
            this.txtancho.Text = "0";
            this.txtancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtancho_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ANCHO:";
            // 
            // txtalto
            // 
            this.txtalto.Location = new System.Drawing.Point(128, 61);
            this.txtalto.Name = "txtalto";
            this.txtalto.Size = new System.Drawing.Size(200, 20);
            this.txtalto.TabIndex = 12;
            this.txtalto.Text = "0";
            this.txtalto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtalto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "ALTO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DE ORDEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbvendedor;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlargo_bn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtancho_bn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtlargo_bs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtancho_bs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtancho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtalto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbpul;
        private System.Windows.Forms.RadioButton rbcm;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtfechafin;
        private System.Windows.Forms.DateTimePicker dtfechainicio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

