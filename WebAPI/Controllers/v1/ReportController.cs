using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class ReportController : BaseApiController
    {
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear un reporte ciudadano.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateReportCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para editar un reporte (ej. actualizar estado).")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateReportCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Recibe el ID correspondiente para eliminar un reporte.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteReportCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todos los reportes con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllReportsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene un reporte por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetReportByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}