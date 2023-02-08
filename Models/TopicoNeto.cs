using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace editaisAPI.Models
{
    public class TopicoNeto
    {

        public int TopicoNetoId { get; set; }
        public string TopicoNetoNome { get; set; }
        public int? NumTopicoNeto { get; set; }

        //navigation properties
        public virtual TopicoFilho TopicoFilho { get; set; }

    }
}