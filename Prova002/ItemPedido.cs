using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova002
{
    public class ItemPedido
    {
        public Produto Produto { get; }      
        public int Quantidade { get; }       

        
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;               
            Quantidade = quantidade;         
        }

        public decimal Subtotal => Produto.Preco * Quantidade;
    }
}
