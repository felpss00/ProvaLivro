using Microsoft.AspNetCore.Mvc;
using ProvaLivro.Data;
using ProvaLivro.Models;

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
        public Livro Create(Livro livro)
        {
            _context.TabLivro.Add(livro);
            return livro;
        }

        [HttpGet]
        [Route("list")]
        public Livro list(Livro livro)
        {
            _context.TabLivro.Add(livro);
            return livro;
        }

    }
}