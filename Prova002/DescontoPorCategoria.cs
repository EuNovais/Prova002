using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova002
{
    public class DescontoPorQuantidade : IDescontoStrategy
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            
            return pedido.Itens
                .Where(i => i.Quantidade >= 10)
                .Sum(i => i.Subtotal * 0.15m);
        }
    }
}
