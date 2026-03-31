# CLAUDE.md

## Project Overview

**Datagsm.OpenApi** is an official .NET SDK for the DataGSM OpenAPI — a data platform for Gwangju Software Meister High School (GSM). It is published as a NuGet package and provides typed access to student, club, project, and NEIS (school meal/schedule) data.

- NuGet package ID: `Datagsm.OpenApi`
- Target framework: `net8.0`
- Current version tracked in `Datagsm.OpenApi.csproj`

## Repository Structure

```
datagsm_openapi/
├── Datagsm.OpenApi/
│   ├── Clients/              # API client implementations
│   ├── Models/               # DTOs, request/response models, enums
│   │   ├── Student/
│   │   ├── Club/
│   │   ├── Project/
│   │   ├── Neis/
│   │   ├── Shared/           # PersonDto, ClubInfo, ApiResponse<T>
│   │   └── Enums/
│   ├── Exceptions/           # Custom exception hierarchy
│   ├── DataGsmClient.cs      # Main SDK entry point (sealed)
│   ├── DataGsmClientOptions.cs
│   └── Datagsm.OpenApi.csproj
└── datagsm_openapi.sln
```

## Build & Release

```bash
# Build
dotnet build

# Pack for NuGet
dotnet pack -c Release

# Release is automated via CI/CD on git tag push (v*)
# See: .github/workflows/publish.yml
```

There are no test projects. Changes are validated manually.

## Architecture

### Main Entry Point

`DataGsmClient` is a sealed class that composes four specialized clients:

```csharp
var client = new DataGsmClient("your-api-key");
client.Students  // StudentClient
client.Clubs     // ClubClient
client.Projects  // ProjectClient
client.Neis      // NeisClient  (GetMealsAsync, GetSchedulesAsync)
```

### Client Pattern

All clients extend `BaseClient`, which provides:
- `GetAsync<T>(path, queryParams, cancellationToken)` — core HTTP GET
- `ToApiString<T>(enum)` — converts enum values to snake_case_upper API strings
- HTTP error → typed exception mapping

Client methods follow this signature:
```csharp
public Task<XxxResponse> GetXxxAsync(XxxRequest? request = null, CancellationToken cancellationToken = default)
```

### Model Convention

Each resource has three files:
| Suffix | Purpose | Mutability |
|--------|---------|------------|
| `*Request` | Query parameters / filters | Mutable (`set`) |
| `*Response` | Paginated response wrapper | Immutable (`init`) |
| `*Dto` | Data transfer object | Immutable (`init`) |

### JSON Serialization

Uses `System.Text.Json` with:
- Case-insensitive property matching
- `SnakeCaseUpper` naming policy for enum serialization (e.g., `MajorClub` → `MAJOR_CLUB`)
- No external serialization libraries

### Exception Hierarchy

```
DataGsmException (base)
├── BadRequestException      (400)
├── UnauthorizedException    (401)
├── ForbiddenException       (403)
├── RateLimitException       (429)
└── ServerErrorException     (500)
```

## Coding Conventions

- **All public types:** PascalCase
- **Async methods:** suffix with `Async`, return `Task<T>`
- **DTOs and Responses:** immutable via `init` accessors; default string values use `= string.Empty`
- **Enums:** defined in `Models/Enums/`; serialized as `SNAKE_CASE_UPPER`
- **Nullable reference types:** enabled — avoid `null!` suppressions without justification
- **No external NuGet dependencies** — use only .NET built-in libraries
- **Clients are sealed** — do not make them inheritable unless there is a clear reason
- **XML documentation:** write in Korean to match existing style

## Authentication

The SDK uses the `X-API-KEY` HTTP header. API keys are obtained from the DataGSM portal and expire every 30 days.

## Adding a New Resource

1. Create `Models/<Resource>/` with `<Resource>Dto.cs`, `<Resource>Request.cs`, `<Resource>Response.cs`
2. Add any needed enums to `Models/Enums/`
3. Create `Clients/<Resource>Client.cs` extending `BaseClient`
4. Expose the new client as a property on `DataGsmClient`
5. Update `README.md` with a usage example
