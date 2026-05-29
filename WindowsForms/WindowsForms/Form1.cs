using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string dni= tbDNI.Text;
            double monto = Convert.ToDouble(tbMonto.Text);
            expedienteService.RegistrarExpediente(nombre, dni, monto);
            
        }
        ExpedienteService expedienteService = new ExpedienteService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
