using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFrontEnd.Models
{
    public class Dados
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string DataFormatada { get { return Data.ToShortDateString(); } }

        public String Demanda { get; set; }

        public int Capacidade { get; set; }

        public int AtendimentoPlanejado { get; set; }

        public int AtendimentoRealizado { get; set; }

        public decimal Desvio { get; set; }

        public int Diferenca { get { return Capacidade - AtendimentoRealizado; } }
    }
}
