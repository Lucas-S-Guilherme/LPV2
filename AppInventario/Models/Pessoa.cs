using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppInventario.Models
{

    [Table("pessoa")]
    public class Pessoa
    {
        [Column("id")]
        public int Id {get; set;}
        
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Column("nome")]
        public string? Nome {get; set;}
        
        [Column("cpf")]
        public string? Cpf {get; set;}

        [Column("data_nascimento")]
        public DateTime? DataNasc {get; set;}

        [Column("telefone")]
        public string? Telefone {get; set;}

        //Mapeamento da relação das tabelas no banco de dados (1:N)

        //lista de propriedades da pessoa
        public List<Propriedade>? Propriedades {get; set;}
    }
}
