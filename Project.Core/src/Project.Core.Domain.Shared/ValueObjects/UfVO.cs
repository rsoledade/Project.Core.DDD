using System.Collections.Generic;

namespace Project.Core.Domain.Shared.ValueObjects
{
    public class UfVO
    {
        public string UF { get; set; }

        public List<Estado> ObterEstados()
        {
            return new List<Estado>()
            {
                new Estado() { Codigo = "AC" },
                new Estado() { Codigo = "AL" },
                new Estado() { Codigo = "AP" },
                new Estado() { Codigo = "AM" },
                new Estado() { Codigo = "BA" },
                new Estado() { Codigo = "CE" },
                new Estado() { Codigo = "DF" },
                new Estado() { Codigo = "ES" },
                new Estado() { Codigo = "GO" },
                new Estado() { Codigo = "MA" },
                new Estado() { Codigo = "MG" },
                new Estado() { Codigo = "MT" },
                new Estado() { Codigo = "MS" },
                new Estado() { Codigo = "PA" },
                new Estado() { Codigo = "PB" },
                new Estado() { Codigo = "PI" },
                new Estado() { Codigo = "PR" },
                new Estado() { Codigo = "RJ" },
                new Estado() { Codigo = "RN" },
                new Estado() { Codigo = "RS" },
                new Estado() { Codigo = "RO" },
                new Estado() { Codigo = "RR" },
                new Estado() { Codigo = "SC" },
                new Estado() { Codigo = "SE" },
                new Estado() { Codigo = "SP" },
                new Estado() { Codigo = "TO" }
            };
        }
    }
}
