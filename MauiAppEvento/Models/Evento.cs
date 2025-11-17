using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string nomeEvento { get; set; }
        public string localEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntPartici { get; set; }
        public double valorPartici { get; set; }
        public int totalDuracao
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double CustoTotal
        {
            get
            {
               
                double total = QntPartici * valorPartici;

                return total;
            }
        }

    }
}
