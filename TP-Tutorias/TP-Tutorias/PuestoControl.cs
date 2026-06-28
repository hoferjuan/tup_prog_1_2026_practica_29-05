using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tutorias
{
    internal class PuestoControl
    {
        private double precioCat1;
        private double precioCat2;
        private double precioCat3;
        private double precioCat4;
        private int CantidadTickets;

        Ticket[] historial = new Ticket[0];
        public PuestoControl(double pr1, double pr2, double pr3, double pr4)
        {
            precioCat1 = pr1; precioCat2 = pr2; precioCat3 = pr3; precioCat4 = pr4;
        }
        public Ticket RegistrarPeaje(int hr, int cat, bool esHab, bool esPrep)
        {
            double precio = 0;
            if (cat == 1) precio = precioCat1;
            else if (cat == 2) precio = precioCat2;
            else if (cat == 3) precio = precioCat3;
            else if (cat == 4) precio = precioCat4;
            Ticket t = new Ticket(hr, cat, precio, esHab, esPrep);
            Array.Resize(ref historial, CantidadTickets + 1);
            historial[CantidadTickets] = t;
            CantidadTickets++;
            return t;
        }
        public int VerCantidadTickets()
        {
            return CantidadTickets;
        }
        public string[] VerVehiculosCarga()
        {
            string[] resultado = new string[0];
            for (int i = 0; i < CantidadTickets; i++)
            {
                if ((historial[i].Categoria == 3 || historial[i].Categoria == 4)
                    && !historial[i].EsDiaHabil
                    && historial[i].Hora >= 30 && historial[i].Hora <= 2300)
                {
                    Array.Resize(ref resultado, resultado.Length + 1);
                    resultado[resultado.Length - 1] = historial[i].VerInformacion();
                }
            }
            return resultado;
        }
        public double[] VerPorcentajePorCategoria()
        {
            if (CantidadTickets == 0) return new double[4];

            double[] porcentajes = new double[4];
            int[] contadores = new int[4];
            for (int i = 0; i < CantidadTickets; i++)
            {
                contadores[historial[i].Categoria - 1]++;
            }
            for (int i = 0; i < 4; i++)
            {
                porcentajes[i] = (double)contadores[i] / CantidadTickets * 100;
            }
            return porcentajes;
        }
        public double[] VerPorcentajePorSistemaPago()
        {
            if (CantidadTickets == 0) return new double[2];

            double[] porcentajes = new double[2];
            int contPrepaga = 0;
            for (int i = 0; i < CantidadTickets; i++)
            {
                if (historial[i].EsSistemaPrepago) contPrepaga++;
            }
            porcentajes[0] = (double)contPrepaga / CantidadTickets * 100;
            porcentajes[1] = 100 - porcentajes[0];
            return porcentajes;
        }
        public double VerRecaudacionTotal()
        {
            double costoFinal = 0;
            for (int i = 0; i < CantidadTickets; i++)
            {
                costoFinal += historial[i].CalcularCosto();
            }
            return costoFinal;
        }
        public Ticket[] VerHistorial()
        {
            return historial;
        }
    }

}
