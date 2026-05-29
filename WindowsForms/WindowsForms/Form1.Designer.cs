namespace WindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btnCalcularMontoTotal = new System.Windows.Forms.Button();
            this.btnVerMontoMayor = new System.Windows.Forms.Button();
            this.btnVerIngresados = new System.Windows.Forms.Button();
            this.btnVerExpedientes = new System.Windows.Forms.Button();
            this.lbMontoTotal = new System.Windows.Forms.Label();
            this.lbMontoMayor = new System.Windows.Forms.Label();
            this.lbIngresados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto $";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMonto);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(326, 71);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(91, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(199, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(91, 73);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(199, 20);
            this.tbDNI.TabIndex = 5;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(91, 112);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(199, 20);
            this.tbMonto.TabIndex = 6;
            // 
            // btnCalcularMontoTotal
            // 
            this.btnCalcularMontoTotal.Location = new System.Drawing.Point(32, 226);
            this.btnCalcularMontoTotal.Name = "btnCalcularMontoTotal";
            this.btnCalcularMontoTotal.Size = new System.Drawing.Size(121, 23);
            this.btnCalcularMontoTotal.TabIndex = 4;
            this.btnCalcularMontoTotal.Text = "Ver Monto Total";
            this.btnCalcularMontoTotal.UseVisualStyleBackColor = true;
            // 
            // btnVerMontoMayor
            // 
            this.btnVerMontoMayor.Location = new System.Drawing.Point(32, 275);
            this.btnVerMontoMayor.Name = "btnVerMontoMayor";
            this.btnVerMontoMayor.Size = new System.Drawing.Size(121, 23);
            this.btnVerMontoMayor.TabIndex = 5;
            this.btnVerMontoMayor.Text = "Ver monto mayor";
            this.btnVerMontoMayor.UseVisualStyleBackColor = true;
            // 
            // btnVerIngresados
            // 
            this.btnVerIngresados.Location = new System.Drawing.Point(31, 336);
            this.btnVerIngresados.Name = "btnVerIngresados";
            this.btnVerIngresados.Size = new System.Drawing.Size(122, 23);
            this.btnVerIngresados.TabIndex = 6;
            this.btnVerIngresados.Text = "Ver Ingresados";
            this.btnVerIngresados.UseVisualStyleBackColor = true;
            // 
            // btnVerExpedientes
            // 
            this.btnVerExpedientes.Location = new System.Drawing.Point(189, 404);
            this.btnVerExpedientes.Name = "btnVerExpedientes";
            this.btnVerExpedientes.Size = new System.Drawing.Size(147, 23);
            this.btnVerExpedientes.TabIndex = 7;
            this.btnVerExpedientes.Text = "Ver expedientes";
            this.btnVerExpedientes.UseVisualStyleBackColor = true;
            // 
            // lbMontoTotal
            // 
            this.lbMontoTotal.AutoSize = true;
            this.lbMontoTotal.Location = new System.Drawing.Point(168, 231);
            this.lbMontoTotal.Name = "lbMontoTotal";
            this.lbMontoTotal.Size = new System.Drawing.Size(35, 13);
            this.lbMontoTotal.TabIndex = 8;
            this.lbMontoTotal.Text = "label4";
            // 
            // lbMontoMayor
            // 
            this.lbMontoMayor.AutoSize = true;
            this.lbMontoMayor.Location = new System.Drawing.Point(171, 280);
            this.lbMontoMayor.Name = "lbMontoMayor";
            this.lbMontoMayor.Size = new System.Drawing.Size(35, 13);
            this.lbMontoMayor.TabIndex = 9;
            this.lbMontoMayor.Text = "label5";
            // 
            // lbIngresados
            // 
            this.lbIngresados.AutoSize = true;
            this.lbIngresados.Location = new System.Drawing.Point(171, 336);
            this.lbIngresados.Name = "lbIngresados";
            this.lbIngresados.Size = new System.Drawing.Size(35, 13);
            this.lbIngresados.TabIndex = 10;
            this.lbIngresados.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.lbIngresados);
            this.Controls.Add(this.lbMontoMayor);
            this.Controls.Add(this.lbMontoTotal);
            this.Controls.Add(this.btnVerExpedientes);
            this.Controls.Add(this.btnVerIngresados);
            this.Controls.Add(this.btnVerMontoMayor);
            this.Controls.Add(this.btnCalcularMontoTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCalcularMontoTotal;
        private System.Windows.Forms.Button btnVerMontoMayor;
        private System.Windows.Forms.Button btnVerIngresados;
        private System.Windows.Forms.Button btnVerExpedientes;
        private System.Windows.Forms.Label lbMontoTotal;
        private System.Windows.Forms.Label lbMontoMayor;
        private System.Windows.Forms.Label lbIngresados;
    }
}

