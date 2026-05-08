# RutaLimpiaBackend

Backend API for the Ruta Limpia project — a platform to manage community cleaning activities, routes, reports and notifications.

> Lightweight, modular .NET 10 backend with Identity, EF Core persistence, SignalR tracking and a CQRS-style application layer.

## Badges

![dotnet](https://img.shields.io/badge/dotnet-10-informational)

## What this project does

RutaLimpiaBackend implements the server-side API and services for a community cleaning application. Main responsibilities:

- Manage cleaning days and participations
- Manage routes and sectors for collection
- Handle citizen reports (with file uploads) and report lifecycle
- Send notifications and weather alerts
- Real-time location/tracking via SignalR
- User management and authentication using ASP.NET Core Identity

The solution is split into small projects (Domain, Application, Persistence, Identity, Shared, and the WebAPI) to keep concerns separated.

## Why this project is useful

- Designed for maintainability: layered architecture and feature folders
- Ready-to-use authentication/authorization via Identity and seeded default users/roles
- Includes database migrations and local file upload service for quick development
- Swagger UI for API exploration and SignalR hub for real-time features

## Tech stack

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core (migrations in Infrastructure.Persistence)
- ASP.NET Core Identity (Infrastructure.Identity)
- MediatR (CQRS-style handlers)
- SignalR (real-time tracking)
- Swagger (OpenAPI)

## Quickstart — get running locally

Prerequisites

- .NET 10 SDK
- SQL Server (local or remote) or use the in-memory option for quick testing
- (Optional) Visual Studio 2022/2026 or VS Code

Clone

git clone https://github.com/Jam1ll/RutaLimpiaBackend.git
cd RutaLimpiaBackend

Configuration

1. Copy WebAPI/appsettings.json to WebAPI/appsettings.Development.json (or edit the existing file) and set at least:

- ConnectionStrings: DefaultConnection and IdentityConnection
- JWTSettings: Key/Issuer/Audience/DurationInMinutes
- GoogleSettings: ClientID (if you use Google login)

To use an in-memory database for quicker dev runs, set UseInMemoryDatabase to true in WebAPI/appsettings.Development.json.

Run database migrations

This project includes EF Core migrations. From the repository root you can run:

dotnet ef database update --project RutaLimpiaBackend.Infrastructure.Persistence --startup-project WebAPI

(Make sure the dotnet-ef tool is available: dotnet tool install --global dotnet-ef)

Run the API

dotnet run --project WebAPI

When running in Development, Swagger is available at: http://localhost:5000/swagger (port may vary)

Seeding

On startup the app runs seeding logic to create default roles and an admin user. See Infrastructure/Identity/Seeds for details.

## Common usage examples

1) Authenticate (example)

curl -X POST "http://localhost:5000/api/v1/auth/login" -H "Content-Type: application/json" -d '{"email":"admin@example.com","password":"P@ssw0rd"}'

2) Get all routes

curl -H "Authorization: Bearer <TOKEN>" http://localhost:5000/api/v1/Route

3) Create a report with file upload

curl -X POST "http://localhost:5000/api/v1/Report" -H "Authorization: Bearer <TOKEN>" -F "file=@/path/to/photo.jpg" -F "description=Broken glass on 5th St" -F "latitude=..." -F "longitude=..."

Notes: API routes use API versioning: /api/v{version}/[controller] (examples use v1). Check Swagger for exact contracts.

## Project structure

- WebAPI — API entry point, controllers, minimal endpoints, middlewares, SignalR hub, static files
- RutaLimpiaBackend.Core.Domain — domain entities and settings
- RutaLimpiaBackend.Core.Application — DTOs, MediatR handlers, validators, mappings and application services
- RutaLimpiaBackend.Infrastructure.Persistence — EF Core DbContext, configurations, repositories, migrations, local file upload
- RutaLimpiaBackend.Infrastructure.Identity — Identity DbContext, user/role seeds and account services
- RutaLimpiaBackend.Infrastructure.Shared — shared infrastructure (e.g., DateTime service)

## Where to get help

- Create an issue: https://github.com/Jam1ll/RutaLimpiaBackend/issues
- Use the repository Discussions or open a pull request with questions
- Inspect Swagger UI when running locally for endpoint documentation

## Contributing

Contributions are welcome. Please follow the repository's contribution guidelines (if present):

- See CONTRIBUTING.md for the contribution workflow (create this file if missing): CONTRIBUTING.md
- Open issues for bugs or feature requests
- Use branches and open pull requests against the default branch

## Maintainers

This repository is maintained on GitHub. For maintainers and contact, please check the repository owners and open an issue if you need direct contact.

## License

See the LICENSE file in this repository: LICENSE

## Additional notes

- Swagger and SignalR endpoints are enabled by default in development
- Static files (uploaded reports) are served from WebAPI/wwwroot/reports
- Check Infrastructure.Persistence/Migrations for existing EF migrations
