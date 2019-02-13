using Project.Core.Domain.Shared.Entidades;
using System;
using System.Linq;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Pedidos : EntidadeBase
    {  
        public DateTime DataPedido { get; set; }
        public DateTime? DataEntrega { get; set; }
        public int IdCliente { get; set; }

        public override bool EstaConsistente()
        {
            DataPedidoDeveSerPreenchida();
            DataPedidoDeveSerSerSuperiorADataDoDia();
            DataEntregaDeveSerSuperiorOuIgualDataDoPedido();
            ClienteDeveSerPreenchido();

            return !ListErros.Any();
        }

        private void DataPedidoDeveSerPreenchida()
        {
            if (DataPedido == null) ListErros.Add("O campo Data do Pedido deve ser preenchido");
        }

        private void DataPedidoDeveSerSerSuperiorADataDoDia()
        {
            if (DataPedido < DateTime.Today) ListErros.Add("O campo Data do Pedido não pode ser superior a data de hoje");
        }

        private void DataEntregaDeveSerSuperiorOuIgualDataDoPedido()
        {
            if (DataEntrega != null && DataEntrega < DataPedido) ListErros.Add("O campo Data de Entrega deve ser superior a Data do Pedido");
        }

        private void ClienteDeveSerPreenchido()
        {
            if (IdCliente == 0) ListErros.Add("Cliente deve ser informado");
        }
    }
}
