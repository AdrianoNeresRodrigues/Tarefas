using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Lista
    {
        [Key]
        public int ListaId { get; set; }

        [Required(ErrorMessage = "Necessário digitar um nome para a lista")]
        [MinLength(5)]
        [MaxLength(20)]
        public string? ListaNome { get; set; }
        public DateTime? ListaDataLembrete { get; set; }
        public string? ListaLembrete { get; set; }
        public Lista? ListaPai { get; set; }    
    }
}
