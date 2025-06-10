using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova002
{
    public class PedidoService
    {
        private readonly IDescontoStrategy _descontoStrategy; 
        private readonly ILogService _log;                    

        // Injeção de dependências via construtor
        public PedidoService(IDescontoStrategy descontoStrategy, ILogService log)
        {
            _descontoStrategy = descontoStrategy; 
            _log = log;                           
        }

        
        public decimal CalcularTotalComDesconto(Pedido pedido)
        {
            decimal desconto = _descontoStrategy.CalcularDesconto(pedido); 
            _log.Registrar($"Desconto aplicado: {desconto:C}");             
            return pedido.ValorTotal - desconto;                            
        }
    }
}
