using System.Collections.Generic;

namespace Project.Core.Domain.Shared.Entidades
{
    public abstract class EntidadeBase
    {
        public EntidadeBase()
        {
            ListErros = new List<string>();
        }

        public int Id { get; set; }
        public List<string> ListErros { get; set; }
        public abstract bool EstaConsistente();
    }
}
