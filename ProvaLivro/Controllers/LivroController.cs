using Microsoft.AspNetCore.Mvc;
using ProvaLivro.Data;
using ProvaLivro.Models;
using System.Linq;

namespace ProvaLivro.Controllers
{
    [ApiController]
    [Route("api/livro")]
    public class LivroController : ControllerBase
    {

        private readonly DataContext _context;

        public LivroController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Livro livro)
        {
            _context.TabLivro.Add(livro);
            _context.SaveChanges();
            return Created("", livro);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.TabLivro.ToList());

    }
}