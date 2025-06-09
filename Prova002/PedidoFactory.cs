using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova002
{
    public class PedidoFactory
    {
        
        public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens)
        {
            return new Pedido(id, cliente, itens); 
        }
    }
}