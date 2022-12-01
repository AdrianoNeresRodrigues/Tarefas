using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Lista
    {
        [Key]
        public int ListaId { get; set; }

        [Required(ErrorMessage = "Necessário digitar um nome para a lista"), MinLength(5), MaxLength(20)]
        [Display(Name = "Nome da lista")]
        public string? ListaNome { get; set; }

        [Display(Name = "Exibir lembrete em")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? ListaDataLembrete { get; set; }
        [Display(Name = "Lembrete")]
        public string? ListaLembrete { get; set; }
        [Display(Name = "Lista pai")]
        public Lista? ListaPai { get; set; }    
    }
}
