using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdCategoria { get; set; }
        public string Titulo { get; set; }
        [NotMapped]
        public IFormFile Imagem { get; set; }
        public string UrlImagem { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
