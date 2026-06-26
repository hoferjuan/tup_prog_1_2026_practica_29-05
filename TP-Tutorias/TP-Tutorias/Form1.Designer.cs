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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCargarPrecios = new System.Windows.Forms.Button();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbDiaHabil = new System.Windows.Forms.GroupBox();
            this.gbPrepago = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbTicket.SuspendLayout();
            this.gbDiaHabil.SuspendLayout();
            this.gbPrepago.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCargarPrecios
            // 
            this.btnCargarPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPrecios.Location = new System.Drawing.Point(46, 29);
            this.btnCargarPrecios.Name = "btnCargarPrecios";
            this.btnCargarPrecios.Size = new System.Drawing.Size(91, 49);
            this.btnCargarPrecios.TabIndex = 0;
            this.btnCargarPrecios.Text = "Cargar Precios";
            this.btnCargarPrecios.UseVisualStyleBackColor = true;
            // 
            // gbTicket
            // 
            this.gbTicket.Controls.Add(this.gbPrepago);
            this.gbTicket.Controls.Add(this.gbDiaHabil);
            this.gbTicket.Controls.Add(this.comboBox1);
            this.gbTicket.Controls.Add(this.textBox3);
            this.gbTicket.Controls.Add(this.maskedTextBox1);
            this.gbTicket.Controls.Add(this.label4);
            this.gbTicket.Controls.Add(this.label2);
            this.gbTicket.Controls.Add(this.label1);
            this.gbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicket.Location = new System.Drawing.Point(46, 103);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(273, 338);
            this.gbTicket.TabIndex = 1;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 31);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 26);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 33);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 24);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Si";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(110, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 24);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "No";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // gbDiaHabil
            // 
            this.gbDiaHabil.Controls.Add(this.radioButton1);
            this.gbDiaHabil.Controls.Add(this.radioButton2);
            this.gbDiaHabil.Location = new System.Drawing.Point(42, 150);
            this.gbDiaHabil.Name = "gbDiaHabil";
            this.gbDiaHabil.Size = new System.Drawing.Size(190, 75);
            this.gbDiaHabil.TabIndex = 16;
            this.gbDiaHabil.TabStop = false;
            this.gbDiaHabil.Text = "Dia habil";
            // 
            // gbPrepago
            // 
            this.gbPrepago.Controls.Add(this.radioButton3);
            this.gbPrepago.Controls.Add(this.radioButton4);
            this.gbPrepago.Location = new System.Drawing.Point(42, 240);
            this.gbPrepago.Name = "gbPrepago";
            this.gbPrepago.Size = new System.Drawing.Size(190, 75);
            this.gbPrepago.TabIndex = 17;
            this.gbPrepago.TabStop = false;
            this.gbPrepago.Text = "Prepago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vehiculos ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cat 1 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cat 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cat 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cat 4 :";
            // 
            // lbCat1
            // 
            this.lbCat1.AutoSize = true;
            this.lbCat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat1.Location = new System.Drawing.Point(113, 74);
            this.lbCat1.Name = "lbCat1";
            this.lbCat1.Size = new System.Drawing.Size(15, 20);
            this.lbCat1.TabIndex = 8;
            this.lbCat1.Text = "-";
            // 
            // lbCat2
            // 
            this.lbCat2.AutoSize = true;
            this.lbCat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat2.Location = new System.Drawing.Point(113, 111);
            this.lbCat2.Name = "lbCat2";
            this.lbCat2.Size = new System.Drawing.Size(15, 20);
            this.lbCat2.TabIndex = 9;
            this.lbCat2.Text = "-";
            // 
            // lbCat3
            // 
            this.lbCat3.AutoSize = true;
            this.lbCat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat3.Location = new System.Drawing.Point(113, 140);
            this.lbCat3.Name = "lbCat3";
            this.lbCat3.Size = new System.Drawing.Size(15, 20);
            this.lbCat3.TabIndex = 10;
            this.lbCat3.Text = "-";
            // 
            // lbCat4
            // 
            this.lbCat4.AutoSize = true;
            this.lbCat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat4.Location = new System.Drawing.Point(113, 178);
            this.lbCat4.Name = "lbCat4";
            this.lbCat4.Size = new System.Drawing.Size(15, 20);
            this.lbCat4.TabIndex = 11;
            this.lbCat4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pagos Tarjeta Prepaga";
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjeta.Location = new System.Drawing.Point(234, 116);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(15, 20);
            this.lbTarjeta.TabIndex = 13;
            this.lbTarjeta.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total Recaudado";
            // 
            // lbRecaudado
            // 
            this.lbRecaudado.AutoSize = true;
            this.lbRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecaudado.Location = new System.Drawing.Point(88, 277);
            this.lbRecaudado.Name = "lbRecaudado";
            this.lbRecaudado.Size = new System.Drawing.Size(15, 20);
            this.lbRecaudado.TabIndex = 15;
            this.lbRecaudado.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbTarjeta);
            this.groupBox4.Controls.Add(this.lbRecaudado);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbCat4);
            this.groupBox4.Controls.Add(this.lbCat1);
            this.groupBox4.Controls.Add(this.lbCat3);
            this.groupBox4.Controls.Add(this.lbCat2);
            this.groupBox4.Location = new System.Drawing.Point(394, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 338);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.btnCargarPrecios);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            this.gbDiaHabil.ResumeLayout(false);
            this.gbDiaHabil.PerformLayout();
            this.gbPrepago.ResumeLayout(false);
            this.gbPrepago.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCargarPrecios;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPrepago;
        private System.Windows.Forms.GroupBox gbDiaHabil;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}

