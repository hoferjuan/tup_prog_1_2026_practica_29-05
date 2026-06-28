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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }
        public void CargarLista(string[] vehiculos)
        {
            if (vehiculos.Length == 0)
            {
                lbLista.Items.Add("No hay vehículos a informar.");
            }
            else
            {
                foreach (string v in vehiculos)
                {
                    lbLista.Items.Add(v);
                }
            }
        }
        private void FormLista_Load(object sender, EventArgs e)
        {

        }
    }
}
