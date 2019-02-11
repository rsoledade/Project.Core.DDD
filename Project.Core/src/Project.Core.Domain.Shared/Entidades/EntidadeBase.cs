using System.Collections.Generic;

namespace Project.Core.Domain.Shared.Entidades
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public List<string> ListErros { get; set; }
        public abstract bool EstaConsistente();
    }
}
