using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class ExpedienteService
    {
        string[] nombres;
        string[] dnis;
        double[]montos;
        int contadorIngresados;
        
        // método Construcctor de mi objeto
        public ExpedienteService()
        {
            nombres = new string[100];
            dnis = new string[100];
            montos = new double[100];
            contadorIngresados = 0;
        }

        public void RegistrarExpediente(string nombre, string dni, double monto)
        { 
            nombres[contadorIngresados] = nombre;
            dnis[contadorIngresados]= dni;
            montos[contadorIngresados]= monto;
            contadorIngresados++;
        }
        public double CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < montos.Length; i++)
            {
                total += montos[i];
            }
            return total;
        }
        public double VerMayor()
        {

            return 0;
        }
        public int VerCantidadIngresados()
        {
            return 0;
        }
        public string Expediente(int idx)
        {
            return "hola";
        }

    
    }
}
