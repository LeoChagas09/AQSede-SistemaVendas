using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Consulta
{
    public class ConsultaPedidos
    {
        public int id { get; set; } //pedido
        public string cliente { get; set; } //cliente
        public string produto { get; set; }//produto
        public float quantidade { get; set; }//pedido
        public float valor { get; set; }//produto
        public float total { get; set; } //calcular
    }
}
