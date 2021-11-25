using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SISTEMAVENDAS.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.tipoproduto).IsRequired();
            builder.Property(p => p.quantidade).HasColumnType("float").IsRequired();
            builder.Property(p => p.valor).HasColumnType("float").IsRequired();

            builder.HasMany(p => p.pedidos).WithOne(p => p.produto).HasForeignKey(p => p.produtoID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Produtos");
        }
    }
}
