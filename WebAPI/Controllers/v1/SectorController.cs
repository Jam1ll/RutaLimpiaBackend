using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class SectorController : BaseApiController
    {
        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear un sector.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateSectorCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para editar un sector existente.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateSectorCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Recibe el ID correspondiente para eliminar un sector.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteSectorCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [AllowAnonymous]
        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todos los sectores con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllSectorsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene un sector por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetSectorByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}