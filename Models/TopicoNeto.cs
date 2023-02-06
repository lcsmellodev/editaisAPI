using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(TopicoNetoNome), nameof(TopicoFilhoNome), nameof(TopicoPaiNome), nameof(DisciplinaNome), nameof(ProvaId))]
    public class TopicoNeto
    {
        public TopicoNeto()
        {

        }
        [StringLength(180)]
        public string TopicoNetoNome { get; set; }
        [StringLength(180)]
        public string TopicoFilhoNome { get; set; }
        [StringLength(180)]
        public string TopicoPaiNome { get; set; }
        [StringLength(80)]
        public string DisciplinaNome { get; set; }
        public string ProvaId { get; set; }

        //navigation properties
        [ForeignKey("DisciplinaNome,ProvaId,TopicoPaiNome,TopicoFilhoNome")]
        public virtual TopicoFilho TopicoFilho { get; set; }

    }
}