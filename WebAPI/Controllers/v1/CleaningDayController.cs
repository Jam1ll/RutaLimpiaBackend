using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class CleaningDayController : BaseApiController
    {
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear una jornada de limpieza.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateCleaningDayCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para editar una jornada de limpieza.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateCleaningDayCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Recibe el ID correspondiente para eliminar una jornada.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteCleaningDayCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [AllowAnonymous]
        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todas las jornadas de limpieza con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCleaningDaysQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene una jornada de limpieza por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetCleaningDayByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}