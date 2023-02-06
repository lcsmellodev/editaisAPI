using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(TopicoNetoNome), nameof(TopicoFilhoNome), nameof(TopicoPaiNome), nameof(DisciplinaNome), nameof(ProvaId))]
    public class TopicoNeto
    {
   
        [StringLength(180)]
        public string TopicoNetoNome { get; set; }
        [StringLength(180)]
        public string TopicoFilhoNome { get; set; }
        [StringLength(180)]
        public string TopicoPaiNome { get; set; }
        [StringLength(80)]
        public string DisciplinaNome { get; set; }
        public int ProvaId { get; set; }

        //navigation properties
        [ForeignKey("TopicoFilhoNome, TopicoPaiNome,DisciplinaNome, ProvaId")]
        public virtual TopicoFilho TopicoFilho { get; set; }

    }
}