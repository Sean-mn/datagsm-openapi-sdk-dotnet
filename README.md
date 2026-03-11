# DataGSM OpenAPI SDK for .NET
[![NuGet](https://img.shields.io/nuget/v/Datagsm.OpenApi.svg)](https://www.nuget.org/packages/Datagsm.OpenApi/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-9.0%2B-blue.svg)](https://dotnet.microsoft.com/)

DataGSM의 OpenAPI를 추상화된 환경에서 제공합니다.

### 설치 - .NET CLI
```bash
dotnet add package Datagsm.OpenApi
```

### 설치 - PackageReference
```xml
<PackageReference Include="Datagsm.OpenApi" Version="1.0.0" />
```

### 사용법

```csharp
using Datagsm.OpenApi;
using Datagsm.OpenApi.Models;

// API 키로 클라이언트 생성
using var client = new DataGsmClient("your-api-key");

// 학생 조회
var students = await client.Students.GetStudentsAsync(new StudentRequest
{
    Grade = 2,
    ClassNum = 1
});

// 동아리 조회
var clubs = await client.Clubs.GetClubsAsync(new ClubRequest
{
    ClubType = ClubType.MajorClub
});

// 프로젝트 조회
var projects = await client.Projects.GetProjectsAsync();

// 오늘 급식 조회
var meals = await client.Neis.GetMealsAsync();

// 학사일정 범위 조회
var schedules = await client.Neis.GetSchedulesAsync(new ScheduleRequest
{
    FromDate = new DateOnly(2025, 3, 1),
    ToDate   = new DateOnly(2025, 3, 31)
});
```

> API 키는 [DataGSM 클라이언트 포털](https://datagsm-front-client.vercel.app)에서 발급받을 수 있습니다.

자세한 사용법은 [기술 문서](https://datagsm-front-docs.vercel.app/)를 참고하십시오.
