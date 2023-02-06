using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(TopicoPaiNome), nameof(DisciplinaNome),nameof(ProvaId))]
    public class TopicoPai
    {
        public TopicoPai()
        {
            this.TopicoFilhos = new Collection<TopicoFilho>();
        }
        
        [StringLength(180)]
        public string TopicoPaiNome { get; set; }
        [StringLength(80)]
        public string DisciplinaNome { get; set; }
        public int ProvaId { get; set; }

        //navigation properties

        [ForeignKey("DiscipddddddlinaNome,ProvaId")]
        public virtual Disciplina Disciplina { get; set; }
        public virtual ICollection<TopicoFilho> TopicoFilhos{ get; set; } 


    }
}