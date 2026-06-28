namespace TP_Tutorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCargarPrecios = new System.Windows.Forms.Button();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.gbPrepago = new System.Windows.Forms.GroupBox();
            this.rbSiP = new System.Windows.Forms.RadioButton();
            this.rbNoP = new System.Windows.Forms.RadioButton();
            this.gbDiaHabil = new System.Windows.Forms.GroupBox();
            this.rbSiD = new System.Windows.Forms.RadioButton();
            this.rbNoD = new System.Windows.Forms.RadioButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tbHora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCat1 = new System.Windows.Forms.Label();
            this.lbCat2 = new System.Windows.Forms.Label();
            this.lbCat3 = new System.Windows.Forms.Label();
            this.lbCat4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRecaudado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListaVehiculos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbTicket.SuspendLayout();
            this.gbPrepago.SuspendLayout();
            this.gbDiaHabil.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCargarPrecios
            // 
            this.btnCargarPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPrecios.Location = new System.Drawing.Point(46, 12);
            this.btnCargarPrecios.Name = "btnCargarPrecios";
            this.btnCargarPrecios.Size = new System.Drawing.Size(91, 64);
            this.btnCargarPrecios.TabIndex = 0;
            this.btnCargarPrecios.Text = "Cargar Precios";
            this.btnCargarPrecios.UseVisualStyleBackColor = true;
            this.btnCargarPrecios.Click += new System.EventHandler(this.btnCargarPrecios_Click);
            // 
            // gbTicket
            // 
            this.gbTicket.Controls.Add(this.btnCrearTicket);
            this.gbTicket.Controls.Add(this.gbPrepago);
            this.gbTicket.Controls.Add(this.gbDiaHabil);
            this.gbTicket.Controls.Add(this.cbCategoria);
            this.gbTicket.Controls.Add(this.tbHora);
            this.gbTicket.Controls.Add(this.label2);
            this.gbTicket.Controls.Add(this.label1);
            this.gbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicket.Location = new System.Drawing.Point(46, 103);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(280, 387);
            this.gbTicket.TabIndex = 1;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "Ticket";
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Location = new System.Drawing.Point(86, 334);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(117, 32);
            this.btnCrearTicket.TabIndex = 18;
            this.btnCrearTicket.Text = "Crear Ticket";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // gbPrepago
            // 
            this.gbPrepago.Controls.Add(this.rbSiP);
            this.gbPrepago.Controls.Add(this.rbNoP);
            this.gbPrepago.Location = new System.Drawing.Point(42, 241);
            this.gbPrepago.Name = "gbPrepago";
            this.gbPrepago.Size = new System.Drawing.Size(190, 75);
            this.gbPrepago.TabIndex = 17;
            this.gbPrepago.TabStop = false;
            this.gbPrepago.Text = "Prepago";
            // 
            // rbSiP
            // 
            this.rbSiP.AutoSize = true;
            this.rbSiP.Location = new System.Drawing.Point(23, 33);
            this.rbSiP.Name = "rbSiP";
            this.rbSiP.Size = new System.Drawing.Size(45, 24);
            this.rbSiP.TabIndex = 11;
            this.rbSiP.TabStop = true;
            this.rbSiP.Text = "Si";
            this.rbSiP.UseVisualStyleBackColor = true;
            // 
            // rbNoP
            // 
            this.rbNoP.AutoSize = true;
            this.rbNoP.Location = new System.Drawing.Point(110, 33);
            this.rbNoP.Name = "rbNoP";
            this.rbNoP.Size = new System.Drawing.Size(51, 24);
            this.rbNoP.TabIndex = 12;
            this.rbNoP.TabStop = true;
            this.rbNoP.Text = "No";
            this.rbNoP.UseVisualStyleBackColor = true;
            // 
            // gbDiaHabil
            // 
            this.gbDiaHabil.Controls.Add(this.rbSiD);
            this.gbDiaHabil.Controls.Add(this.rbNoD);
            this.gbDiaHabil.Location = new System.Drawing.Point(42, 150);
            this.gbDiaHabil.Name = "gbDiaHabil";
            this.gbDiaHabil.Size = new System.Drawing.Size(190, 75);
            this.gbDiaHabil.TabIndex = 16;
            this.gbDiaHabil.TabStop = false;
            this.gbDiaHabil.Text = "Dia habil";
            // 
            // rbSiD
            // 
            this.rbSiD.AutoSize = true;
            this.rbSiD.Location = new System.Drawing.Point(23, 32);
            this.rbSiD.Name = "rbSiD";
            this.rbSiD.Size = new System.Drawing.Size(45, 24);
            this.rbSiD.TabIndex = 9;
            this.rbSiD.TabStop = true;
            this.rbSiD.Text = "Si";
            this.rbSiD.UseVisualStyleBackColor = true;
            // 
            // rbNoD
            // 
            this.rbNoD.AutoSize = true;
            this.rbNoD.Location = new System.Drawing.Point(110, 32);
            this.rbNoD.Name = "rbNoD";
            this.rbNoD.Size = new System.Drawing.Size(51, 24);
            this.rbNoD.TabIndex = 10;
            this.rbNoD.TabStop = true;
            this.rbNoD.Text = "No";
            this.rbNoD.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(120, 96);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cbCategoria.TabIndex = 13;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(120, 37);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(121, 26);
            this.tbHora.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cat 1 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cat 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cat 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cat 4 :";
            // 
            // lbCat1
            // 
            this.lbCat1.AutoSize = true;
            this.lbCat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat1.Location = new System.Drawing.Point(208, 62);
            this.lbCat1.Name = "lbCat1";
            this.lbCat1.Size = new System.Drawing.Size(15, 20);
            this.lbCat1.TabIndex = 8;
            this.lbCat1.Text = "-";
            this.lbCat1.Click += new System.EventHandler(this.lbCat1_Click);
            // 
            // lbCat2
            // 
            this.lbCat2.AutoSize = true;
            this.lbCat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat2.Location = new System.Drawing.Point(208, 145);
            this.lbCat2.Name = "lbCat2";
            this.lbCat2.Size = new System.Drawing.Size(15, 20);
            this.lbCat2.TabIndex = 9;
            this.lbCat2.Text = "-";
            this.lbCat2.Click += new System.EventHandler(this.lbCat2_Click);
            // 
            // lbCat3
            // 
            this.lbCat3.AutoSize = true;
            this.lbCat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat3.Location = new System.Drawing.Point(208, 235);
            this.lbCat3.Name = "lbCat3";
            this.lbCat3.Size = new System.Drawing.Size(15, 20);
            this.lbCat3.TabIndex = 10;
            this.lbCat3.Text = "-";
            this.lbCat3.Click += new System.EventHandler(this.lbCat3_Click);
            // 
            // lbCat4
            // 
            this.lbCat4.AutoSize = true;
            this.lbCat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat4.Location = new System.Drawing.Point(213, 313);
            this.lbCat4.Name = "lbCat4";
            this.lbCat4.Size = new System.Drawing.Size(15, 20);
            this.lbCat4.TabIndex = 11;
            this.lbCat4.Text = "-";
            this.lbCat4.Click += new System.EventHandler(this.lbCat4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pagos Tarjeta Prepaga";
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjeta.Location = new System.Drawing.Point(409, 73);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(15, 20);
            this.lbTarjeta.TabIndex = 13;
            this.lbTarjeta.Text = "-";
            this.lbTarjeta.Click += new System.EventHandler(this.lbTarjeta_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total Recaudado";
            // 
            // lbRecaudado
            // 
            this.lbRecaudado.AutoSize = true;
            this.lbRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecaudado.Location = new System.Drawing.Point(134, 73);
            this.lbRecaudado.Name = "lbRecaudado";
            this.lbRecaudado.Size = new System.Drawing.Size(15, 20);
            this.lbRecaudado.TabIndex = 15;
            this.lbRecaudado.Text = "-";
            this.lbRecaudado.Click += new System.EventHandler(this.lbRecaudado_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lbCat4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbCat1);
            this.groupBox4.Controls.Add(this.lbCat3);
            this.groupBox4.Controls.Add(this.lbCat2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(354, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 387);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehículos";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbTarjeta);
            this.groupBox1.Controls.Add(this.lbRecaudado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // btnListaVehiculos
            // 
            this.btnListaVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaVehiculos.Location = new System.Drawing.Point(198, 12);
            this.btnListaVehiculos.Name = "btnListaVehiculos";
            this.btnListaVehiculos.Size = new System.Drawing.Size(89, 64);
            this.btnListaVehiculos.TabIndex = 18;
            this.btnListaVehiculos.Text = "Ver lista";
            this.btnListaVehiculos.UseVisualStyleBackColor = true;
            this.btnListaVehiculos.Click += new System.EventHandler(this.btnListaVehiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 639);
            this.Controls.Add(this.btnListaVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.btnCargarPrecios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            this.gbPrepago.ResumeLayout(false);
            this.gbPrepago.PerformLayout();
            this.gbDiaHabil.ResumeLayout(false);
            this.gbDiaHabil.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCargarPrecios;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.RadioButton rbNoP;
        private System.Windows.Forms.RadioButton rbSiP;
        private System.Windows.Forms.RadioButton rbNoD;
        private System.Windows.Forms.RadioButton rbSiD;
        private System.Windows.Forms.MaskedTextBox tbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPrepago;
        private System.Windows.Forms.GroupBox gbDiaHabil;
        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCat4;
        private System.Windows.Forms.Label lbCat3;
        private System.Windows.Forms.Label lbCat2;
        private System.Windows.Forms.Label lbCat1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRecaudado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCrearTicket;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnListaVehiculos;
    }
}

