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
            var existeLibro = await context.Libros.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == id);

            if(existeLibro == null)
            {
                return NotFound();
            }

            return existeLibro;
        }

        [HttpGet("titulo")]
        public async Task<ActionResult<Libro>> Get(string titulo)
        {
            var existeLibro = await context.Libros.FirstOrDefaultAsync(x => x.Titulo.Contains(titulo));

            if(existeLibro == null)
            {
                return NotFound();
            }

            return existeLibro;
        }

        [HttpGet("todos")]
        public async Task<ActionResult<List<Libro>>> Get()
        {
            return await context.Libros.ToListAsync();
        }

        [HttpGet("primero")]
        public async Task<ActionResult<Libro>> Primero()
        {
            return await context.Libros.FirstOrDefaultAsync();
        }

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

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Libro libro, int id)
        {
            var existeLibro = await context.Libros.AnyAsync(x => x.Id == id);

            if(!existeLibro)
            {
                return NotFound();
            }

            if(libro.Id != id)
            {
                return BadRequest("El id del libro no coincide con el id de la URL");
            }

            context.Update(libro);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeLibro = await context.Libros.AnyAsync(x => x.Id == id);

            if(!existeLibro)
            {
                return NotFound();
            }

            context.Remove(new Libro() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
