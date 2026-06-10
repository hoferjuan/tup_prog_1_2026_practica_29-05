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
        ExpedienteService expedienteService = new ExpedienteService();
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
            string dni = tbDNI.Text;
            double monto = Convert.ToDouble(tbMonto.Text);
            expedienteService.RegistrarExpediente(nombre, dni, monto);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularMontoTotal_Click(object sender, EventArgs e)
        {
            double total = expedienteService.CalcularTotal();
            lbMontoTotal.Text = total.ToString();
        }

        private void btnVerMontoMayor_Click(object sender, EventArgs e)
        {
            double mayor = expedienteService.VerMayor();
            lbMontoMayor.Text = mayor.ToString();
        }

        private void btnVerIngresados_Click(object sender, EventArgs e)
        {
            int ingresados = expedienteService.VerCantidadIngresados();
            lbIngresados.Text = ingresados.ToString();
        }

        private void btnOrdenarAscendiente_Click(object sender, EventArgs e)
        {
            expedienteService.OrdenarPorDNIAscendiente();
        }

        private void btnOrdenarDescendiente_Click(object sender, EventArgs e)
        {
            expedienteService.OrdenarPorDNIDescendiente();
        }

        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            string[] expedientes = expedienteService.VerExpedientes();
            form2.lbExpedientes.Text = string.Join("\n", expedientes);
            form2.ShowDialog();
            form2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string buscar = expedienteService.BuscarPorDNI(Convert.ToInt32(tbBuscarPorDNI.Text));
            Form2 form2 = new Form2();
            form2.lbExpedientes.Text = buscar;
            form2.ShowDialog();
            form2.Dispose();
        }
    }
}
