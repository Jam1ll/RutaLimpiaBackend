using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class NotificationController : BaseApiController
    {
        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear una notificación.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateNotificationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Actualiza una notificación (ej. marcar como leída).")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateNotificationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Elimina una notificación.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteNotificationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todas las notificaciones del usuario.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllNotificationsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene una notificación por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetNotificationByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}