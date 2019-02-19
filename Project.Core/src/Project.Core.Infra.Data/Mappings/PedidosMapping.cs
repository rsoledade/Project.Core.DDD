using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Pedidos.Entidades;

namespace Project.Core.Infra.Data.Mappings
{
    public class PedidosMapping : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido).HasColumnType("DateTime").IsRequired();

            builder.Property(p => p.DataEntrega).HasColumnType("DateTime");

            builder.HasOne(p => p.Cliente).WithMany(c => c.Pedidos).HasForeignKey(p => p.IdCliente);

            builder.Ignore(p => p.ListErros);

            builder.ToTable("Pedidos");
        }
    }
}
