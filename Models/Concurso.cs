using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace editaisAPI.Models
{
    
    public class Concurso
    {
        public Concurso()
        {
            this.Provas = new Collection<Prova>();
        }
        public int ConcursoId { get; set; }
        public DateTime ConcursoData { get; set; }
        [StringLength(180)]
        public string? Banca { get; set; }
        [StringLength(180)]
        public string? Orgao { get; set; }


        //navigation properties
        public virtual ICollection<Prova> Provas { get; set; }

    }
}
