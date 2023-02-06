using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(ConcursoId))]
    public class Concurso
    {

        public Concurso()
        {
            this.Provas = new Collection<Prova>();
        }
        public int ConcursoId { get; set; }
        public DateTime ConcursoData { get; set; }
        public string? Banca { get; set; }
        public string? Orgao { get; set; }


        //navigation properties
        public virtual ICollection<Prova> Provas { get; set; }

    }
}
