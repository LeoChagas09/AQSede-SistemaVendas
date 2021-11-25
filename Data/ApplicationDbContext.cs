using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SISTEMAVENDAS.Models.Dominio;
using SISTEMAVENDAS.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMAVENDAS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
       
    }
}
