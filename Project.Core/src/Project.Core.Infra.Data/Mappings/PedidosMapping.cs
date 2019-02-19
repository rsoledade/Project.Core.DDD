using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Infra.Data.Mappings
{
    public class PedidosMapping : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasKey(p => p.Id);

            //builder.Property()
        }
    }
}
