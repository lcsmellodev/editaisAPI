using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace editaisAPI.Models
{
    [PrimaryKey(nameof(TopicoFilhoNome), nameof(TopicoPaiNome), nameof(DisciplinaNome), nameof(ProvaId))]
    public class TopicoFilho
    {
        public TopicoFilho()
        {
            this.TopicoNetos = new Collection<TopicoNeto>();
        }

        [StringLength(180)]
        public string TopicoFilhoNome { get; set; }
        [StringLength(180)]
        public string TopicoPaiNome { get; set; }
        [StringLength(80)]
        public string DisciplinaNome { get; set; }
        public int ProvaId { get; set; }

        //navigation properties
        [ForeignKey("DisciplinaNome,ProvaId,TopicoPaiNome")]
        public virtual TopicoPai TopicoPai { get; set; }
        public virtual ICollection<TopicoNeto> TopicoNetos { get; set; }

    }
}