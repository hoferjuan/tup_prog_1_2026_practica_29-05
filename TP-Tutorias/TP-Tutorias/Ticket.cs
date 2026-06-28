using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tutorias
{
    internal class Ticket
    {
        public int Hora;
        public int Categoria;
        public double PrecioCatSelect;
        public bool EsDiaHabil;
        public bool EsSistemaPrepago;

        public DateTime Fecha;

        public Ticket(int hr, int cat, double precio, bool esHab, bool esPrep)
        {
            Hora = hr; Categoria = cat; PrecioCatSelect = precio; EsDiaHabil = esHab; EsSistemaPrepago = esPrep;
            Fecha = DateTime.Now;
        }
        public double CalcularCosto()
        {
            double descuento = 0;

            if (EsDiaHabil)
            {
                if (Hora >= 2231 || Hora <= 600)
                {
                    descuento = 0.15;
                }
                else if (Hora >= 601 && Hora <= 2000)
                {
                    descuento = 0.10;
                }
                else if (Hora >= 2001 && Hora <= 2230)
                {
                    descuento = 0.12;
                }
            }
            else
            {
                if (Hora >= 2231 || Hora <= 600)
                {
                    descuento = 0.25;
                }
                else if (Hora >= 601 && Hora <= 2000)
                {
                    descuento = 0.15;
                }
                else if (Hora >= 2001 && Hora <= 2230)
                {
                    descuento = 0.20;
                }
            }

            double costoFinal = PrecioCatSelect + (PrecioCatSelect * descuento);
            return costoFinal;
        }
        public string VerInformacion()
        {
            double costo = CalcularCosto();
            double porcentaje = (costo - PrecioCatSelect) / PrecioCatSelect;

            return $"Fecha: {Fecha:dd/MM/yyyy}\n" +
                   $"Hora: {Hora:00}:00\n" +
                   $"Categoría: {Categoria}\n" +
                   $"Precio Base: ${PrecioCatSelect:F2}\n" +
                   $"Recargo: {porcentaje:P0}\n" +
                   $"Precio Final: ${costo:F2}\n";
        }

    }
}
