using Microsoft.EntityFrameworkCore;
using SISTEMAVENDAS.Models.Dominio;
using SISTEMAVENDAS.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISTEMAVENDAS.Models.Consulta;

namespace SISTEMAVENDAS.Models
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public object Pedido { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new PedidoMap());
            builder.ApplyConfiguration(new ProdutoMap());
        }

        public DbSet<SISTEMAVENDAS.Models.Consulta.ConsultaPedidos> ConsultaPedidos { get; set; }

        public DbSet<SISTEMAVENDAS.Models.Consulta.ProdutoGrp> ProdutoGrp { get; set; }
    }
}
