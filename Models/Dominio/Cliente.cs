using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMAVENDAS.Models.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35)]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo Nome do Cliente é obrigatorio")]
        public string nome { get; set; }


        [Display(Name = "CPF")]
        [StringLength(20, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        public string cpf { get; set; }

        [StringLength(35)]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo de Data de Nascimento é obrigatorio")]
        public string datanascimento { get; set; }

        [Display(Name = "E-Mail")]
        [StringLength(35, ErrorMessage = "E-Mail maior que 35 caracteres")]
        [RegularExpression("^[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[a-zA-Z0-9_+-]+@[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "Email invalido")]
        public string email { get; set; }

        [Display(Name = "CEP")]
        [StringLength(20, ErrorMessage = "Não aceita CEP com mais de 20 dígitos")]
        public string cep { get; set; }

        [StringLength(35)]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo Cidade é obrigatorio")]
        public string cidade { get; set; }

        [StringLength(35)]
        [DisplayName("Endereco")]
        [Required(ErrorMessage = "Campo Endereço é obrigatorio")]
        public string endereco { get; set; }

        [StringLength(20)]
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo Telefone é obrigatorio")]
        public string telefone { get; set; }

        public ICollection<Pedido> pedidos { get; set; }
    }
}
