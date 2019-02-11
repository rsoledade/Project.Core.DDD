using Project.Core.Domain.Shared.ValueObjects;

namespace Project.Core.Domain.Shared.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public CpfCnpjVO CPFCNPJ { get; set; }
        public EmailVO Email { get; set; }
        public EnderecoVO Endereco { get; set; }
    }
}
