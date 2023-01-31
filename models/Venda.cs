using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TESTE.models
{
    public class Venda
    {
        public int IdVendedor{ get; set; }
        public DateTime Data { get; set; }
        public int IdPedido { get; set; }
        public string ItensVendidos { get; set; }
        public EnumStatusVendas Status { get; set; }
        
        
    }
}