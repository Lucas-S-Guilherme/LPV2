using System.ComponentModel.DataAnnotations.Schema;

namespace AppInventario.Models
{
    [Table("propriedade")]
    public class Propriedade
    {
        [Column("id")]
        public int Id {get; set;}

        [Column("descricao")]
        public string? Descricao {get; set;}

        [Column("valor")]
        public double? Valor {get; set;}

        [Column("id_pessoa")]
        public int? IdPessoaaa {get; set;}

        //informa qual o atributo da classe vai armazenar a FK
        [ForeignKey("IdPessoa")]
        public Pessoa? Pessoa {get; set;} // indica a pessoa que é o dono da propriedade
    }
}