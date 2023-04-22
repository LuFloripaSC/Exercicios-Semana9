using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Exercicio_Semana9.Models
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }

        [NotNull]
        [Column("DATA")]
        public DateTime DataSemana { get; set; }

        [MaxLength(100)]
        [Column("CONTEUDO")]
        public string Conteudo { get; set;}

        [NotNull]
        [Column ("APLICADOCONTEUDO")]
        public bool AplicadoConteudo { get; set; }
    }
}
