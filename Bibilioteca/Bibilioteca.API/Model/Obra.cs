using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Model
{
    public class Obra
    {
        public int Id { get; set; }
        public int IdEditora { get; set; }
        public string Titulo { get; set; }
        public string Foto { get; set; }
        public Editora Editora { get; set; }
        public ICollection<Autor> Autores { get; set; }
    }
}
