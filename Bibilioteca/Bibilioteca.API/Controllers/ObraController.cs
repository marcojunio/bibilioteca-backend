using Bibilioteca.API.Data;
using Bibilioteca.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Controllers
{
    [Route("api/obras")]
    public class ObraController : Controller
    {
        private readonly DevLibraryDbContext _dbContext;

        public ObraController(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult ObterTodasObras()
        {
            var obras = _dbContext.Obras
                .Include(e => e.Autores)
                .ToList();

            if (obras == null)
            {
                return NotFound();
            }

            return Ok(obras);
        }

        [HttpPost]
        public IActionResult CadastrarObra([FromBody] Obra obra)
        {
            _dbContext.Obras.Add(obra);
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id ,[FromBody] Obra obra)
        {
            var livro = _dbContext.Obras.Where(e => e.Id == id).FirstOrDefault();

            if (livro == null) 
            {
                return NotFound();
            }

            livro.Foto = obra.Foto;
            livro.Titulo = obra.Titulo;

            _dbContext.Obras.Update(livro);
            _dbContext.SaveChanges();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeletarObra(int id)
        {
            var obra = _dbContext.Obras.Where(e => e.Id == id);

            if(obra == null)
            {
                return BadRequest();
            }

            _dbContext.Remove(obra);
            _dbContext.SaveChanges();

            return NoContent();
        }


    }
}
