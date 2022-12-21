using FundamentosOK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOK.Helpers
{
    public class HelperMeses
    {
        //Esta clase tendra una coleccion con todos los meses
        public List<TemperaturaMes> Meses { get; set; }

        public HelperMeses()
        {
            this.GenerarNuevosDatosMeses();
        }

        public void GenerarNuevosDatosMeses()
        {
            this.Meses = new List<TemperaturaMes>();
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.Maxima = random.Next(20, 60);
                mes.Minima = random.Next(-15, 17);
                mes.NombreMes = "Mes " + i;
                this.Meses.Add(mes);
            }
        }
        // METODO PARA MEDIA ANUAL
        public int GetMediaAnual()
        {
            int media = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                media += mes.GetMediaMes();
            }
            return media / this.Meses.Count;
        }
        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach (TemperaturaMes mes in this.Meses) {
                maxima = Math.Max(maxima, mes.Maxima);
            }
            return maxima;
        }
        public int GetMinimaAnual ()
        {
            int minima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.Minima);
            }
            return minima;
        }
    }
}
