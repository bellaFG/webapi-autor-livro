using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi8.Dto.Autor;
using WebApi8.Models;
using WebApi8.Services.Autor;

namespace WebApi8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);

        }

        [HttpGet("BuscarAutorPorId/{idAutor}")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> BuscarAutorPorId(int idAutor)

        {

            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);

        }

        [HttpGet("BuscarAutorPorIdLivro/{idLivro}")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> BuscarAutorPorIdLivro(int idLivro)

        {

            var autor = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(autor);

        }

        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>>CriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            var autores = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autores);
        }


        [HttpPut("EditarAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> EditarAutor(int idAutor, AutorEdicaoDto autorEdicaoDto)
        {
            var resposta = await _autorInterface.EditarAutor(idAutor, autorEdicaoDto);
            return Ok(resposta);
        }

        [HttpDelete("ExcluirAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ExcluirAutor(int idAutor)
        {
            var resposta = await _autorInterface.ExcluirAutor(idAutor);
            return Ok(resposta);
        }
    }



}
