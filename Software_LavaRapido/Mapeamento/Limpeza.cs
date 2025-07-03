using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_LavaRapido.Mapeamento
{
    public class Limpeza
    {
        public int ID { get; set; }
        public string PlacaCarro { get; set; }
        public int IDCliente { get; set; }
        public decimal Valor_Limpeza { get; set; }
        public DateTime HorarioAgendado { get; set; }
        public DateTime DiaAgendado { get; set; }
    }
}
