using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_TESTE.models;
using Microsoft.AspNetCore.Mvc;
namespace API_TESTE.Controllers
{
    [ApiController]
    [Route("[controllher]")]
    public class VendaController : ControllerBase
    {
        private static List<Vendedor> vendedores()
        {
           return new List<Vendedor>
           {
            new Vendedor{Id = 1, Nome="Vendedor 1", Cpf = "1212121212", Email = "Vendedor1@hotmail.com", Telefone = "3333333333" },
            new Vendedor{Id = 2, Nome="Vendedor 2", Cpf = "0210336332", Email = "Vendedor2@hotmail.com", Telefone = "4444444444" },
            new Vendedor{Id = 3, Nome="Vendedor 3", Cpf = "9999999999", Email = "Vendedor3@hotmail.com", Telefone = "1111111111" }
           }; 
        }
        private static List<Venda> vendas()
        {
            return new List<Venda>
            {
              new Venda{IdPedido = 1, IdVendedor = 1, Data = DateTime.Now, ItensVendidos = "10 Pacotes de Café"},
              new Venda{IdPedido = 2, IdVendedor = 2, Data = DateTime.Now, ItensVendidos = "5 Caixas de creme de Leite"},
              new Venda{IdPedido = 3, IdVendedor = 3, Data = DateTime.Now, ItensVendidos = "6 caixas de Nutella"}
            };
            
        }
        [HttpGet("Obter por Vendedores")]
        public IActionResult ExibirVendedores()
        {
            return Ok(vendedores());
        }
        [HttpGet("Obter Vendas por Id")]
        public IActionResult ExibirVendas()
        {
            return Ok(vendas());
        }
        [HttpPost("CadastrarVenda")]
        public IActionResult CadastrarNovaVenda(Venda venda)
        {
            return Ok(Vendas(venda));
        }
        private static List<Venda> Vendas(Venda venda)
        {
            return new List<Venda> {new Venda{IdPedido = venda.IdPedido, IdVendedor = venda.IdVendedor, Data = DateTime.Now, ItensVendidos = venda.ItensVendidos}};
            
            
            
        }
    }
}