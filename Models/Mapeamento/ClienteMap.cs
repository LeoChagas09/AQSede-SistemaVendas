using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SISTEMAVENDAS.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure (EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.cpf).IsUnique();
            builder.Property(p => p.datanascimento).HasMaxLength(10).IsRequired();
            builder.Property(p => p.email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cep).HasMaxLength(20).IsRequired();
            builder.Property(p => p.cidade).HasMaxLength(35).IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(35).IsRequired();
            builder.Property(p => p.telefone).HasMaxLength(20).IsRequired();

            builder.HasMany(p => p.pedidos).WithOne(p => p.cliente).HasForeignKey(p => p.clienteID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Clientes");
        }
    }
}
