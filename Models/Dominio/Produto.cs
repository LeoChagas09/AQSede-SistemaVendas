using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Dominio
{
    public enum TipoProduto { Refrigerante, Cerveja, Cachaça, Agua, Suco }

    [Table("Produto")]

    public class Produto
    {
        public enum TipoProduto { Refrigerante, Cerveja, Cachaça, Agua, Suco }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35)]
        [DisplayName("Nome Produto")]
        [Required(ErrorMessage = "Campo Nome Produto  é obrigatorio")]
        public string nome { get; set; }

        [Display(Name = "Tipo Produto")]
        public TipoProduto tipoproduto { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        public float quantidade { get; set; }


        [DisplayName("Valor do Produto")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Campo Valor é obrigatorio")]
        public float valor { get; set; }

        public ICollection<Pedido> pedidos { get; set; }
    }
}
