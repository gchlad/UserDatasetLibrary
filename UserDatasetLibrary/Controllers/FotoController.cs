using Microsoft.AspNetCore.Mvc;
using UserDatasetLibrary.Core.Dtos.Foto;
using UserDatasetLibrary.Core.Services.Interfaces;

namespace UserDatasetLibrary.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FotoController : ControllerBase
    {
        private readonly IFotoService fotoService;

        public FotoController(IFotoService fotoService)
        {
            this.fotoService = fotoService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            FotoDto? dto = fotoService.GetFotoById(id);
            if(dto is null)
            {
                return NotFound();
            }
            return Ok(dto); // TODO: add message object and mapping
        }

        [HttpPost]
        public async Task<IActionResult> CreateFoto([FromBody] FotoDto foto) // TODO: use request object instead of core dto
        {
            await fotoService.CreateFoto(foto);
            return Created(nameof(GetById), foto);
        }
    }
}
