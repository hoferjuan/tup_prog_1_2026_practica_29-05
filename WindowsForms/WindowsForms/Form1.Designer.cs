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
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCalcularMontoTotal = new System.Windows.Forms.Button();
            this.btnVerMontoMayor = new System.Windows.Forms.Button();
            this.btnVerIngresados = new System.Windows.Forms.Button();
            this.btnVerExpedientes = new System.Windows.Forms.Button();
            this.lbMontoTotal = new System.Windows.Forms.Label();
            this.lbMontoMayor = new System.Windows.Forms.Label();
            this.lbIngresados = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOrdenarDescendiente = new System.Windows.Forms.Button();
            this.tbBuscarPorDNI = new System.Windows.Forms.TextBox();
            this.btnOrdenarAscendiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(43, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(604, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(121, 138);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(264, 22);
            this.tbMonto.TabIndex = 6;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(121, 90);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(264, 22);
            this.tbDNI.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(121, 39);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(264, 22);
            this.tbNombre.TabIndex = 4;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(435, 87);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 28);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularMontoTotal
            // 
            this.btnCalcularMontoTotal.Location = new System.Drawing.Point(43, 249);
            this.btnCalcularMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularMontoTotal.Name = "btnCalcularMontoTotal";
            this.btnCalcularMontoTotal.Size = new System.Drawing.Size(161, 28);
            this.btnCalcularMontoTotal.TabIndex = 4;
            this.btnCalcularMontoTotal.Text = "Ver Monto Total";
            this.btnCalcularMontoTotal.UseVisualStyleBackColor = true;
            this.btnCalcularMontoTotal.Click += new System.EventHandler(this.btnCalcularMontoTotal_Click);
            // 
            // btnVerMontoMayor
            // 
            this.btnVerMontoMayor.Location = new System.Drawing.Point(41, 300);
            this.btnVerMontoMayor.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerMontoMayor.Name = "btnVerMontoMayor";
            this.btnVerMontoMayor.Size = new System.Drawing.Size(161, 28);
            this.btnVerMontoMayor.TabIndex = 5;
            this.btnVerMontoMayor.Text = "Ver monto mayor";
            this.btnVerMontoMayor.UseVisualStyleBackColor = true;
            this.btnVerMontoMayor.Click += new System.EventHandler(this.btnVerMontoMayor_Click);
            // 
            // btnVerIngresados
            // 
            this.btnVerIngresados.Location = new System.Drawing.Point(43, 350);
            this.btnVerIngresados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerIngresados.Name = "btnVerIngresados";
            this.btnVerIngresados.Size = new System.Drawing.Size(163, 28);
            this.btnVerIngresados.TabIndex = 6;
            this.btnVerIngresados.Text = "Ver Ingresados";
            this.btnVerIngresados.UseVisualStyleBackColor = true;
            this.btnVerIngresados.Click += new System.EventHandler(this.btnVerIngresados_Click);
            // 
            // btnVerExpedientes
            // 
            this.btnVerExpedientes.Location = new System.Drawing.Point(253, 494);
            this.btnVerExpedientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerExpedientes.Name = "btnVerExpedientes";
            this.btnVerExpedientes.Size = new System.Drawing.Size(196, 47);
            this.btnVerExpedientes.TabIndex = 7;
            this.btnVerExpedientes.Text = "Ver expedientes";
            this.btnVerExpedientes.UseVisualStyleBackColor = true;
            this.btnVerExpedientes.Click += new System.EventHandler(this.btnVerExpedientes_Click);
            // 
            // lbMontoTotal
            // 
            this.lbMontoTotal.AutoSize = true;
            this.lbMontoTotal.Location = new System.Drawing.Point(228, 255);
            this.lbMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMontoTotal.Name = "lbMontoTotal";
            this.lbMontoTotal.Size = new System.Drawing.Size(44, 16);
            this.lbMontoTotal.TabIndex = 8;
            this.lbMontoTotal.Text = "label4";
            // 
            // lbMontoMayor
            // 
            this.lbMontoMayor.AutoSize = true;
            this.lbMontoMayor.Location = new System.Drawing.Point(228, 306);
            this.lbMontoMayor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMontoMayor.Name = "lbMontoMayor";
            this.lbMontoMayor.Size = new System.Drawing.Size(44, 16);
            this.lbMontoMayor.TabIndex = 9;
            this.lbMontoMayor.Text = "label5";
            // 
            // lbIngresados
            // 
            this.lbIngresados.AutoSize = true;
            this.lbIngresados.Location = new System.Drawing.Point(228, 362);
            this.lbIngresados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngresados.Name = "lbIngresados";
            this.lbIngresados.Size = new System.Drawing.Size(44, 16);
            this.lbIngresados.TabIndex = 10;
            this.lbIngresados.Text = "label6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar Expediente por DNI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrdenarDescendiente
            // 
            this.btnOrdenarDescendiente.Location = new System.Drawing.Point(478, 467);
            this.btnOrdenarDescendiente.Name = "btnOrdenarDescendiente";
            this.btnOrdenarDescendiente.Size = new System.Drawing.Size(150, 53);
            this.btnOrdenarDescendiente.TabIndex = 13;
            this.btnOrdenarDescendiente.Text = "Ordenar por DNI Descendiente";
            this.btnOrdenarDescendiente.UseVisualStyleBackColor = true;
            this.btnOrdenarDescendiente.Click += new System.EventHandler(this.btnOrdenarDescendiente_Click);
            // 
            // tbBuscarPorDNI
            // 
            this.tbBuscarPorDNI.Location = new System.Drawing.Point(264, 424);
            this.tbBuscarPorDNI.Name = "tbBuscarPorDNI";
            this.tbBuscarPorDNI.Size = new System.Drawing.Size(237, 22);
            this.tbBuscarPorDNI.TabIndex = 14;
            // 
            // btnOrdenarAscendiente
            // 
            this.btnOrdenarAscendiente.Location = new System.Drawing.Point(67, 467);
            this.btnOrdenarAscendiente.Name = "btnOrdenarAscendiente";
            this.btnOrdenarAscendiente.Size = new System.Drawing.Size(150, 53);
            this.btnOrdenarAscendiente.TabIndex = 15;
            this.btnOrdenarAscendiente.Text = "Ordenar por DNI ascendiente";
            this.btnOrdenarAscendiente.UseVisualStyleBackColor = true;
            this.btnOrdenarAscendiente.Click += new System.EventHandler(this.btnOrdenarAscendiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 554);
            this.Controls.Add(this.btnOrdenarAscendiente);
            this.Controls.Add(this.tbBuscarPorDNI);
            this.Controls.Add(this.btnOrdenarDescendiente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbIngresados);
            this.Controls.Add(this.lbMontoMayor);
            this.Controls.Add(this.lbMontoTotal);
            this.Controls.Add(this.btnVerExpedientes);
            this.Controls.Add(this.btnVerIngresados);
            this.Controls.Add(this.btnVerMontoMayor);
            this.Controls.Add(this.btnCalcularMontoTotal);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Expedientes";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOrdenarDescendiente;
        private System.Windows.Forms.TextBox tbBuscarPorDNI;
        private System.Windows.Forms.Button btnOrdenarAscendiente;
    }
}

