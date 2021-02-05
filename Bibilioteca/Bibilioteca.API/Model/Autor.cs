using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public int IdEditora { get; set; }
        public Editora Editora { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento{ get; set; }
        public ICollection<Obra> Obras { get; set; }
    }
}
