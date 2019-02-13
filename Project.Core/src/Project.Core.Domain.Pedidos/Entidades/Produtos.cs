using System.Collections.Generic;
using System.Linq;
using Project.Core.Domain.Shared.Entidades;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Produtos : EntidadeBase
    {        
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }
        public int IdFornecedor { get; set; }

        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerTamanhoLimite();
            ValorPrecisaSerSuperiorAZero();
            UniadeDeveSerValida();

            return !ListErros.Any();
        }

        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListErros.Add("O campo Apelido deve ser preenchido");
        }

        private void ApelidoDeveTerTamanhoLimite()
        {
            if (Apelido.Length > 20) ListErros.Add("O campo Apelido deve ter no máximo 20 caracteres");
        }

        private void ValorPrecisaSerSuperiorAZero()
        {
            if (Valor <= 0) ListErros.Add("O campo Valor deverá ser maior que zero");
        }

        private void UniadeDeveSerValida()
        {
            var listUnidade = new List<string> { "KL", "GR", "MT", "CM", "QT" };
            if (!listUnidade.Contains(Unidade)) ListErros.Add("O campo Unidade deve ser KL, GR, MT, CM ou QT");
        }
    }
}
