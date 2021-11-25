using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SISTEMAVENDAS.Models;
using SISTEMAVENDAS.Models.Consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly Contexto contexto;

        public ConsultaController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult ListarItensPedidos(int cliID)
        {
            IEnumerable<ConsultaPedidos> lstItens = from item in contexto.Pedidos
                                                    .Include(c => c.cliente)
                                                    .Include(p => p.produto)
                                                    .OrderBy(cli => cli.cliente.nome)
                                                    .ToList()
                                                    select new ConsultaPedidos {
                                                        id = item.id,
                                                        cliente = item.cliente.nome,
                                                        produto = item.produto.nome,
                                                        quantidade = item.quantidade,
                                                        valor = item.produto.valor,
                                                        total = item.quantidade * item.produto.valor
                                                    };
            return View(lstItens);
        }
    }
}
