using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TruckController : BaseApiController
    {
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear un camion de basura.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateTruckCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para editar un camion de basura.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateTruckCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Recibe el ID correspondiente para eliminar un camion de basura.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteTruckCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [AllowAnonymous]
        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todas los camiones de basura con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTrucksQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene los camiones de basura por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetTruckByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}