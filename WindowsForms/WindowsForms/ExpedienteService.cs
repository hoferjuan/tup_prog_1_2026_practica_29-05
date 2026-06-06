using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class ExpedienteService
    {
        private string[] Nombres = new string[100];
        private string[] DNIs = new string[100];
        private double[] montos = new double[100];
        private int contadorIngresados = 0;

        // método Construcctor de mi objeto
        public ExpedienteService()
        {

        }

        public void RegistrarExpediente(string nombre, string dni, double monto)
        {
            Nombres[contadorIngresados] = nombre;
            montos[contadorIngresados] = monto;
            DNIs[contadorIngresados] = dni;
            contadorIngresados++;
        }
        public double CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < contadorIngresados; i++)
            {
                total += montos[i];
            }
            return total;
        }
        public double VerMayor()
        {
            double mayorMonto = 0;
            for (int i = 0; i < contadorIngresados; i++)
            {
                if (montos[i] > mayorMonto)
                {
                    mayorMonto = montos[i];
                }
            }
            return mayorMonto;
        }
        public int VerCantidadIngresados()
        {
            return contadorIngresados;
        }
        public string VerExpediente(int idx)
        {
            string expediente = $"Nombre: {Nombres[idx]}, Monto: $ {montos[idx]}, DNI: {idx} ";

            return expediente;
        }
        public void OrdenarPorMontosAscendente()
        {
            for (int i = 0; i < contadorIngresados; i++)
            {
                for (int j = 0; j < contadorIngresados - 1; j++)
                {
                    if (montos[i] > montos[j])
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }
        public void OrdenarPorMontosDescendiente()
        {

        }
        public string BuscarPorDNI(int dni)
        {
            return "jdjd";
        }
        private void Intercambiar(int i, int j)
        {
            string auxDNI = DNIs[i];
            DNIs[i] = DNIs[j];
            DNIs[i] = DNIs[j];
            DNIs[j] = auxDNI;

            double auxMonto = montos[i];
            montos[i] = montos[j];
            montos[j] = auxMonto;

            string auxNombres = Nombres[i];
            Nombres[i] = Nombres[j];
            Nombres[j] = auxNombres;
        }


    }
}
