using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSoftwareEventos.Models
{
    public class Evento
    {
        public string NomeDoEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipantes { get; set; }
        public string LocalEvento { get; set; }
        public int CustoParticipante { get; set; }
        public int DuracaoEvento
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
        public int CustoEvento 
        {
            get
            {
                double valor_evento = QntParticipantes * CustoParticipante;
                double total = valor_evento * DuracaoEvento;
                return (int) total;
            }
        }

        
    }
}
