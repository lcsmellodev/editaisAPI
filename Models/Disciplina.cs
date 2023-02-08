using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace editaisAPI.Models
{
    
    public class Disciplina
    {
        public Disciplina()
        {
            this.TopicoPais = new Collection<TopicoPai>();
        }
        public int DisciplinaId { get; set; }
        public string DisciplinaNome { get; set; }
        public int ProvaId { get; set; }

        //navigation properties
       
        public virtual Prova Prova { get; set; }
        public virtual ICollection<TopicoPai> TopicoPais { get; set; }
    }
}
