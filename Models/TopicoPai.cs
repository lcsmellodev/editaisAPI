using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    public class TopicoPai
    {
        public TopicoPai()
        {
            this.TopicoFilhos = new Collection<TopicoFilho>();
        }

        public int TopicoPaiId { get; set; }
        public string TopicoPaiNome { get; set; }
        public int DisciplinaId{ get; set;}
        public int? NumTopicoPai { get; set;  }

        //navigation properties
        public virtual Disciplina Disciplina { get; set; }
        public virtual ICollection<TopicoFilho> TopicoFilhos{ get; set; } 


    }
}