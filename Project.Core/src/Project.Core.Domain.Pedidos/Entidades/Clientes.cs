using Project.Core.Domain.Shared.Entidades;
using System.Linq;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerTamanhoLimite();
            NomeDeveSerPreenchido();
            NomeDeveTerTamanhoLimite();
            CpfCnpjDeveSerPreenchido();
            CpfCnpjDeveSerValido();
            EmailDeveSerValido();
            EmailDeveTerTamanhoLimite();
            EnderecoDeveSerPreenchido();
            EnderecoDeveTerTamanhoLimite();
            BairroDeveTerTamanhoLimite();
            CidadeDeveSerPreenchido();
            CidadeDeveTerTamanhoLimite();
            UFDeveSerPreenchido();
            UFDeveSerValida();
            CepDeveSerValido();

            return !ListErros.Any();
        }

        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListErros.Add("Apelido deve ser preenchido");
        }

        private void ApelidoDeveTerTamanhoLimite()
        {
            if (Apelido.Trim().Length > 20) ListErros.Add("O campo Apelido deve ter no máximo 20 caracteres");
        }

        private void NomeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) ListErros.Add("Nome deve ser preenchido");
        }

        private void NomeDeveTerTamanhoLimite()
        {
            if (Nome.Trim().Length > 100) ListErros.Add("O campo Nome deve ter no máximo 100 caracteres");
        }

        private void CpfCnpjDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CPFCNPJ.Numero)) ListErros.Add("CPF ou CNPJ deve ser preenchido");
        }

        private void CpfCnpjDeveSerValido()
        {
            if (!CPFCNPJ.Validar(CPFCNPJ.Numero)) ListErros.Add("CPF ou CNPJ inválido");
        }

        private void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.Endereco)) ListErros.Add("Digite um e-mail válido");
        }

        private void EmailDeveTerTamanhoLimite()
        {
            if (Email.Endereco.Trim().Length > 100) ListErros.Add("O campo E-mail deve ter no máximo 100 caracteres");
        }

        private void EnderecoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Logradouro)) ListErros.Add("Endereço deve ser preenchido");
        }

        private void EnderecoDeveTerTamanhoLimite()
        {
            if (Endereco.Logradouro.Trim().Length > 100) ListErros.Add("O campo Endereço deve ter no máximo 100 caracteres");
        }

        private void BairroDeveTerTamanhoLimite()
        {
            if (Endereco.Bairro.Trim().Length > 30) ListErros.Add("O campo Bairro deve ter no máximo 30 caracteres");
        }

        private void CidadeDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.Cidade)) ListErros.Add("Cidade deve ser preenchida");
        }

        private void CidadeDeveTerTamanhoLimite()
        {
            if (Endereco.Cidade.Trim().Length > 30) ListErros.Add("O campo Cidade deve ter no máximo 30 caracteres");
        }

        private void UFDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Endereco.UF.UF)) ListErros.Add("UF deve ser preenchido");
        }

        private void UFDeveSerValida()
        {
            if (!Endereco.UF.Validar(Endereco.UF.UF)) ListErros.Add("Digite uma UF válida");
        }

        private void CepDeveSerValido()
        {
            if (!Endereco.CEP.Validar(Endereco.CEP.Codigo)) ListErros.Add("Digite um CEP válido");
        }
    }
}
