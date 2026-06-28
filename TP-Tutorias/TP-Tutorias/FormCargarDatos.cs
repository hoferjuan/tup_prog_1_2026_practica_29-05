using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Tutorias
{
    public partial class FormCargarDatos : Form
    {
        public double Precio1 { get; set; }
        public double Precio2 { get; set; }
        public double Precio3 { get; set; }
        public double Precio4 { get; set; }
        public FormCargarDatos()
        {
            InitializeComponent();
        }

        private void FormCargarDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Precio1 = Convert.ToDouble(tbCat1.Text);
            Precio2 = Convert.ToDouble(tbCat2.Text);
            Precio3 = Convert.ToDouble(tbCat3.Text);
            Precio4 = Convert.ToDouble(tbCat4.Text);
            DialogResult = DialogResult.OK; ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
