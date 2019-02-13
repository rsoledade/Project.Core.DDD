using Project.Core.Domain.Shared.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
        public ICollection<Pedidos> Pedidos { get; set; }
        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerTamanhoLimite(20);
            NomeDeveSerPreenchido();
            NomeDeveTerTamanhoLimite(100);
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
