using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Pedidos.Entidades;

namespace Project.Core.Infra.Data.Mappings
{
    public class ProdutosMapping : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            
        }
    }
}
