using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Model
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public ICollection<Autor> Autores { get; set; }
        public ICollection<Obra> Obras { get; set; }
    }
}
