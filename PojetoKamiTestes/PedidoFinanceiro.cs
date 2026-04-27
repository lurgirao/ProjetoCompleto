using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetoKamiTestes
{
    public class PedidoFinanceiro
    {
        public string Numero { get; set; }
        public Dictionary<string, (double preco, int quantidade)> Itens { get; set; }
        public double Total { get; set; }
        public DateTime DataHora { get; set; }
        public string FormaPagamento { get; set; }
    }
}
    
