using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Tutorias
{
    public partial class Form1 : Form
    {
        PuestoControl puesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.Add("Categoría I");
            cbCategoria.Items.Add("Categoría II");
            cbCategoria.Items.Add("Categoría III");
            cbCategoria.Items.Add("Categoría IV");
        }

        private void btnCargarPrecios_Click(object sender, EventArgs e)
        {
            FormCargarDatos Fdatos = new FormCargarDatos();
            if (Fdatos.ShowDialog() == DialogResult.OK)
            {
                puesto = new PuestoControl(Fdatos.Precio1, Fdatos.Precio2, Fdatos.Precio3, Fdatos.Precio4);
                Fdatos.Dispose();
            }
        }
        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            if (puesto == null)
            {
                MessageBox.Show("Primero cargue los precios.");
                return;
            }
            int hr = Convert.ToInt32(tbHora.Text);
            int cat = cbCategoria.SelectedIndex + 1;
            bool esHab = rbSiD.Checked;
            bool esPrep = rbSiP.Checked;
            Ticket t = puesto.RegistrarPeaje(hr, cat, esHab, esPrep);
            MessageBox.Show(t.VerInformacion());
            ActualizarResumen();
            tbHora.Text = "";
            cbCategoria.SelectedIndex = -1;
            rbSiD.Checked = false;
            rbNoD.Checked = false;
            rbSiP.Checked = false;
            rbNoP.Checked = false;
        }

        #region resumen
        private void lbRecaudado_Click(object sender, EventArgs e)
        {
            double totalRecaudado = puesto.VerRecaudacionTotal();

            lbRecaudado.Text = totalRecaudado.ToString("F2");
        }

        private void lbTarjeta_Click(object sender, EventArgs e)
        {
            double[] porcentajePrepago = puesto.VerPorcentajePorSistemaPago();
            lbTarjeta.Text = porcentajePrepago[0].ToString("F2") + "%";
        }
        #endregion
        #region Porcentajes
        private void lbCat1_Click(object sender, EventArgs e)
        {
            double[] porcentajes = puesto.VerPorcentajePorCategoria();
            lbCat1.Text = porcentajes[0].ToString("F2") + "%";
        }

        private void lbCat2_Click(object sender, EventArgs e)
        {
            double[] porcentajes = puesto.VerPorcentajePorCategoria();
            lbCat2.Text = porcentajes[1].ToString("F2") + "%";
        }

        private void lbCat3_Click(object sender, EventArgs e)
        {
            double[] porcentajes = puesto.VerPorcentajePorCategoria();
            lbCat3.Text = porcentajes[2].ToString("F2") + "%";
        }

        private void lbCat4_Click(object sender, EventArgs e)
        {
            double[] porcentajes = puesto.VerPorcentajePorCategoria();
            lbCat4.Text = porcentajes[3].ToString("F2") + "%";
        }
        #endregion
        private void ActualizarResumen()
        {
            double[] porcentajes = puesto.VerPorcentajePorCategoria();
            lbCat1.Text = porcentajes[0].ToString("F2") + "%";
            lbCat2.Text = porcentajes[1].ToString("F2") + "%";
            lbCat3.Text = porcentajes[2].ToString("F2") + "%";
            lbCat4.Text = porcentajes[3].ToString("F2") + "%";

            lbRecaudado.Text = puesto.VerRecaudacionTotal().ToString("F2");

            double[] prepago = puesto.VerPorcentajePorSistemaPago();
            lbTarjeta.Text = prepago[0].ToString("F2") + "%";
        }

        private void btnListaVehiculos_Click(object sender, EventArgs e)
        {
            if (puesto == null)
            {
                MessageBox.Show("Primero cargue los precios.");
                return;
            }
            string[] lista = puesto.VerVehiculosCarga();
            FormLista fl = new FormLista();
            fl.CargarLista(lista);
            fl.Show();
        }
    }
}
