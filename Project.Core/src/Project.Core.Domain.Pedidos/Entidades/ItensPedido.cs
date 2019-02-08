namespace Project.Core.Domain.Pedidos.Entidades
{
    public class ItensPedido
    {
        public int Id { get; set; }
        public int Qtd { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
    }
}
