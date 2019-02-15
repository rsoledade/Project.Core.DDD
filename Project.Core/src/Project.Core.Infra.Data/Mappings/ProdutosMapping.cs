using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Pedidos.Entidades;

namespace Project.Core.Infra.Data.Mappings
{
    public class ProdutosMapping : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Apelido).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Nome).HasColumnType("varchar(150)").IsRequired();
            builder.Property(p => p.Valor).HasColumnType("decimal").IsRequired();
            builder.Property(p => p.Unidade).HasColumnType("varchar(2)").IsRequired();
            builder.HasOne(p => p.Fornecedor).WithMany(f => f.Produtos).HasForeignKey(f => f.IdFornecedor);

            builder.Ignore(p => p.ListErros);

            builder.ToTable("Produtos");
        }
    }
}
