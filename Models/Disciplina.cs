using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(DisciplinaNome), nameof(ProvaId))]
    public class Disciplina
    {
        public Disciplina()
        {
            this.TopicoPais = new Collection<TopicoPai>();
        }

        [StringLength(80)]
        public string DisciplinaNome { get; set; }
        public int ProvaId { get; set; }

        //navigation properties
        [ForeignKey("ProvaId")]
        public virtual Prova Prova { get; set; }
        public virtual ICollection<TopicoPai> TopicoPais { get; set; }
    }
}
