using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Tarefa
    {

        [Key]
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "Necessário digitar uma descrição para a tarefa"), MinLength(5)]
        [Display(Name = "Tarefa")]
        public string? TarefaDescricao { get; set; }
        [Required(ErrorMessage = "Necessário digitar uma descrição para a tarefa")]
        [Display(Name = "Prioridade")]
        public int TarefaPrioridade { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de criação")]
        public DateTime? TarefaDataCriacao { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Exibir lembrete em")]
        public DateTime? TarefaDataLembrete { get; set; }
        [Display(Name = "Lembrete")]
        public string? TarefaLembrete { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)] 
        [Display(Name = "Concluir até")]
        public DateTime? TarefaDataVencimento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Concluído em")]
        public DateTime? TarefaDataConclusao { get; set; }
        [Display(Name = "Lista")]
        public Lista? ListaPai { get; set; }
        [Display(Name = "Tarefa pai")]
        public Tarefa? TarefaPai { get; set; }
    }
}