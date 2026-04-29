using Mapster;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Domain.Entities;

// Usings para Commands
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Update;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Create;
using RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Update;

namespace RutaLimpiaBackend.Core.Application.Mappings
{
    public class GeneralMappings : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            // COMMANDS TO ENTITIES (Input)

            // Sector
            config.NewConfig<CreateSectorCommand, Sector>();
            config.NewConfig<UpdateSectorCommand, Sector>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // Route
            config.NewConfig<CreateRouteCommand, Route>();
            config.NewConfig<UpdateRouteCommand, Route>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // Truck
            config.NewConfig<CreateTruckCommand, Truck>();
            config.NewConfig<UpdateTruckCommand, Truck>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // CollectionSchedule
            config.NewConfig<CreateCollectionScheduleCommand, CollectionSchedule>();
            config.NewConfig<UpdateCollectionScheduleCommand, CollectionSchedule>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // Report
            config.NewConfig<CreateReportCommand, Report>();
            config.NewConfig<UpdateReportCommand, Report>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // CleaningDay
            config.NewConfig<CreateCleaningDayCommand, CleaningDay>();
            config.NewConfig<UpdateCleaningDayCommand, CleaningDay>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // CleaningDayParticipation
            config.NewConfig<CreateCleaningDayParticipationCommand, CleaningDayParticipation>();
            config.NewConfig<UpdateCleaningDayParticipationCommand, CleaningDayParticipation>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // Notification
            config.NewConfig<CreateNotificationCommand, Notification>();
            config.NewConfig<UpdateNotificationCommand, Notification>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);

            // WeatherAlert
            config.NewConfig<CreateWeatherAlertCommand, WeatherAlert>();
            config.NewConfig<UpdateWeatherAlertCommand, WeatherAlert>()
                .Ignore(dest => dest.Id)
                .IgnoreNullValues(true);


            // ENTITIES TO DTOs (Output)

            config.NewConfig<Sector, SectorResponseDTO>();
            config.NewConfig<Route, RouteResponseDTO>();
            config.NewConfig<Truck, TruckResponseDTO>();
            config.NewConfig<CollectionSchedule, CollectionScheduleResponseDTO>();
            config.NewConfig<Report, ReportResponseDTO>();
            config.NewConfig<CleaningDay, CleaningDayResponseDTO>();
            config.NewConfig<CleaningDayParticipation, CleaningDayParticipationResponseDTO>();
            config.NewConfig<Notification, NotificationResponseDTO>();
            config.NewConfig<WeatherAlert, WeatherAlertResponseDTO>();
        }
    }
}