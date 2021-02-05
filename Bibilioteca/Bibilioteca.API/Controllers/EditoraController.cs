using Bibilioteca.API.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Controllers
{
    [Route("api/editora")]
    public class EditoraController : Controller
    {
        private readonly DevLibraryDbContext _dbContext;

        public EditoraController(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
