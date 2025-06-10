using Prova002;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     
        var produto1 = new Produto(1, "Mouse", 50.00m, "Eletrônicos");
        var produto2 = new Produto(2, "Camiseta", 30.00m, "Promoção");
        var produto3 = new Produto(3, "Teclado", 120.00m, "Promoção");

        var cliente = new Cliente(1, "Victor", "victor@email.com", "12345678900");

        var itens = new List<ItemPedido>
        {
            new ItemPedido(produto1, 2),  
            new ItemPedido(produto2, 3),  
            new ItemPedido(produto3, 1)   
        };

        var pedidoFactory = new PedidoFactory();
        var pedido = pedidoFactory.CriarPedido(1, cliente, itens);
        

    }
}