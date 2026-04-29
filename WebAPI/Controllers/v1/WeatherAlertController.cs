using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Delete;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetAll;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetById;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace WebAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class WeatherAlertController : BaseApiController
    {
        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para crear una alerta meteorológica.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateWeatherAlertCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPut("Update")]
        [SwaggerOperation(Summary = "Recibe los datos necesarios para editar una alerta meteorológica.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateWeatherAlertCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpDelete("Delete")]
        [SwaggerOperation(Summary = "Recibe el ID correspondiente para eliminar una alerta.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(DeleteWeatherAlertCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [AllowAnonymous]
        [HttpGet("All")]
        [SwaggerOperation(Summary = "Obtiene todas las alertas meteorológicas con filtros opcionales.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllWeatherAlertsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        [SwaggerOperation(Summary = "Obtiene una alerta por su ID.")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid id, [FromQuery] GetWeatherAlertByIdQuery query)
        {
            query.Id = id;
            return Ok(await Mediator.Send(query));
        }
    }
}