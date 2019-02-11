﻿using Project.Core.Domain.Shared.Entidades;
using System;

namespace Project.Core.Domain.Pedidos.Entidades
{
    public class Pedidos : EntidadeBase
    {   
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Status { get; set; }
        public int IdCliente { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
