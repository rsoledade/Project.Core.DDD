using System.Linq;
using Project.Core.Domain.Shared.Entidades;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class ItensPedidos : EntidadeBase
    {   
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public virtual Pedidos Pedido { get; set; }
        public int IdProduto { get; set; }
        public virtual Produtos Produto { get; set; }

        public override bool EstaConsistente()
        {
            QtdDeveSerSuperiorAZero();
            ItemDePedidoDeveSerAssociadoAoPedido();
            ProdutoDeveSerPreenchido();

            return !ListErros.Any();
        }

        private void QtdDeveSerSuperiorAZero()
        {
            if (Qtd <= 0) ListErros.Add("O campo Quantidade deve ser informada");
        }

        private void ItemDePedidoDeveSerAssociadoAoPedido()
        {
            if (IdPedido <= 0) ListErros.Add("Número do pedido inválido");
        }

        private void ProdutoDeveSerPreenchido()
        {
            if (IdProduto <= 0) ListErros.Add("O campo Produto deve ser informado");
        }
    }
}
