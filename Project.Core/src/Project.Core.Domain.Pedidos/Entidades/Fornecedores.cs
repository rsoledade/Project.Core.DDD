﻿namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Fornecedores
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}
