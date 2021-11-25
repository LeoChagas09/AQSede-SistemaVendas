using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SISTEMAVENDAS.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Mapeamento
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.clienteID).IsRequired();
            builder.Property(p => p.produtoID).IsRequired();
            builder.Property(p => p.quantidade).HasColumnType("float").IsRequired();

            builder.HasOne(p => p.cliente).WithMany(p => p.pedidos).HasForeignKey(p => p.clienteID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.produto).WithMany(p => p.pedidos).HasForeignKey(p => p.produtoID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Pedidos");
        }
    }
}
