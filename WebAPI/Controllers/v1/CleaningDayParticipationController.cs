using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class CleaningDayParticipationController : BaseApiController
    {
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Registra la participación de un usuario en una jornada.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateCleaningDayParticipationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Edita los detalles de una participación existente.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateCleaningDayParticipationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Elimina una participación.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteCleaningDayParticipationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todas las participaciones con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCleaningDayParticipationsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene una participación por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetCleaningDayParticipationByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}