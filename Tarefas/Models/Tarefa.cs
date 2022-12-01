using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Tarefa
    {

        [Key]
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "Necessário digitar uma descrição para a tarefa")]
        [MinLength(5)]
        public string? TarefaDescricao { get; set; }
        [Required(ErrorMessage = "Necessário digitar uma descrição para a tarefa")]

        public int TarefaPrioridade { get; set; }
        public DateTime? TarefaDataCriacao { get; set; }
        public DateTime? TarefaDataLembrete { get; set; }
        public string? TarefaLembrete { get; set; }
        public DateTime? TarefaDataVencimento { get; set; }
        public DateTime? TarefaDataConclusao { get; set; }

        public Lista? ListaPai { get; set; }
        public Tarefa? TarefaPai { get; set; }
    }
}