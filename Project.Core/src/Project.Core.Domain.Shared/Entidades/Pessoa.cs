using Project.Core.Domain.Shared.ValueObjects;

namespace Project.Core.Domain.Shared.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public Pessoa()
        {
            CPFCNPJ = new CpfCnpjVO();
            Email = new EmailVO();
            Endereco = new EnderecoVO();
        }

        public string Apelido { get; set; }
        public string Nome { get; set; }
        public CpfCnpjVO CPFCNPJ { get; set; }
        public EmailVO Email { get; set; }
        public EnderecoVO Endereco { get; set; }

        protected void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListErros.Add("Apelido deve ser preenchido");
        }

        protected void ApelidoDeveTerTamanhoLimite(int tamanho)
        {
            if (Apelido.Trim().Length > tamanho) ListErros.Add("O campo Apelido deve ter no máximo " + tamanho + " caracteres");
        }

        protected void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) ListErros.Add("Nome deve ser preenchido");
        }

        protected void NomeDeveTerTamanhoLimite(int tamanho)
        {
            if (Nome.Trim().Length > tamanho) ListErros.Add("O campo Nome deve ter no máximo " + tamanho + " caracteres");
        }

        protected void CpfCnpjDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CPFCNPJ.Numero)) ListErros.Add("CPF ou CNPJ deve ser preenchido");
        }

        protected void CpfCnpjDeveSerValido()
        {
            if (!CPFCNPJ.Validar(CPFCNPJ.Numero)) ListErros.Add("CPF ou CNPJ inválido");
        }

        protected void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.Endereco)) ListErros.Add("Digite um e-mail válido");
        }

        protected void EmailDeveTerTamanhoLimite(int tamanho)
        {
            if (Email.Endereco.Trim().Length > tamanho) ListErros.Add("O campo E-mail deve ter no máximo " + tamanho + " caracteres");
        }

        protected void EnderecoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Logradouro)) ListErros.Add("Endereço deve ser preenchido");
        }

        protected void EnderecoDeveTerTamanhoLimite(int tamanho)
        {
            if (Endereco.Logradouro.Trim().Length > tamanho) ListErros.Add("O campo Endereço deve ter no máximo " + tamanho + " caracteres");
        }

        protected void BairroDeveTerTamanhoLimite(int tamanho)
        {
            if (Endereco.Bairro.Trim().Length > tamanho) ListErros.Add("O campo Bairro deve ter no máximo " + tamanho + " caracteres");
        }

        protected void CidadeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Cidade)) ListErros.Add("Cidade deve ser preenchida");
        }

        protected void CidadeDeveTerTamanhoLimite(int tamanho)
        {
            if (Endereco.Cidade.Trim().Length > tamanho) ListErros.Add("O campo Cidade deve ter no máximo " + tamanho + " caracteres");
        }

        protected void UFDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.UF.UF)) ListErros.Add("UF deve ser preenchido");
        }

        protected void UFDeveSerValida()
        {
            if (!Endereco.UF.Validar(Endereco.UF.UF)) ListErros.Add("Digite uma UF válida");
        }

        protected void CepDeveSerValido()
        {
            if (!Endereco.CEP.Validar(Endereco.CEP.Codigo)) ListErros.Add("Digite um CEP válido");
        }
    }
}
