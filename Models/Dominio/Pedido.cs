using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Dominio
{

    [Table("Pedido")]

    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome Cliente")]
        public Cliente cliente { get; set; }
        [DisplayName("Nome Cliente")]
        public int clienteID { get; set; }
       
        [DisplayName("Nome Produto")]
        public Produto produto { get; set; }
        [DisplayName("Nome Produto")]
        public int produtoID { get; set; }

        [DisplayName("Valor do Produto")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Campo Valor do Produto é obrigatorio")]
        public double valor { get; set; }

        
        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        public float quantidade { get; set; }

        [Display(Name = "Valor total do Pedido")]
        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public virtual double total
        {
            get { return (float) (this.quantidade * this.valor); }
        } 

        public ICollection <Produto> produtos { get; set; }

    }
}
