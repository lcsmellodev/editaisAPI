using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(ProvaId))]
    public class Prova
    {
        public Prova()
        {
            this.Disciplinas = new Collection<Disciplina>();
        }
       
        public int ProvaId { get; set; }
        public DateTime ProvaData { get; set; }
        [StringLength(80)]
        public string Cargo { get; set; }
        public int ConcursoId { get; set; }


        //navigation properties
        [ForeignKey("ConcursoId")]
        public virtual Concurso Concurso { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }

    }
}
