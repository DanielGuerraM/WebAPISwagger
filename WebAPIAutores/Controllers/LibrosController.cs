using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController: ControllerBase
    {
        private readonly ApplicationDBContext context;

        public LibrosController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> Get(int id)
        {
            return await context.Libros.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpGet("listado")]
        public async Task<ActionResult<List<Libro>>> Get()
        {
            return await context.Libros.ToListAsync();
        }

        //[HttpGet("AutorId:int")]
        //public async Task<ActionResult<Libro>> LibrosPorAutor(int AutorId)
        //{
        //    return await context.Libros.Include(x => x.AutorId).FirstOrDefaultAsync(x => x.AutorId == AutorId);
        //}



        [HttpPost]
        public async Task<ActionResult<Libro>> Post(Libro libro)
        {
            var existeAutor = await context.Autores.AnyAsync(x => x.Id == libro.AutorId);

            if(!existeAutor)
            {
                return BadRequest($"No existe el autor de Id: {libro.AutorId}");
            }

            context.Add(libro);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
