using System.Linq;
using Project.Core.Domain.Shared.Entidades;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Fornecedores : Pessoa
    { 
        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerTamanhoLimite(100);
            NomeDeveSerPreenchido();
            NomeDeveTerTamanhoLimite(20);
            CpfCnpjDeveSerPreenchido();
            CpfCnpjDeveSerValido();
            EmailDeveSerValido();
            EmailDeveTerTamanhoLimite(100);
            EnderecoDeveSerPreenchido();
            EnderecoDeveTerTamanhoLimite(100);
            BairroDeveTerTamanhoLimite(30);
            CidadeDeveSerPreenchido();
            CidadeDeveTerTamanhoLimite(30);
            UFDeveSerPreenchido();
            UFDeveSerValida();
            CepDeveSerValido();

            return !ListErros.Any();
        }
    }
}
