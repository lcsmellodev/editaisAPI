using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace editaisAPI.Models
{
    
    public class TopicoFilho
    {
        public TopicoFilho()
        {
            this.TopicoNetos = new Collection<TopicoNeto>();
        }

        public int TopicoFilhoId { get; set; }
        public string TopicoFilhoNome { get; set; }
        public int? NumTopicoFilho { get; set; }


        //navigation properties
        public virtual TopicoPai TopicoPai { get; set; }
        public virtual ICollection<TopicoNeto> TopicoNetos { get; set; }

    }
}