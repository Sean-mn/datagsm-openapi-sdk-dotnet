using Datagsm.OpenApi.Models;

namespace Datagsm.OpenApi.Clients;

/// <summary>학생 데이터 API 클라이언트. 필요 스코프: STUDENT_READ</summary>
public sealed class StudentClient : BaseClient
{
    internal StudentClient(HttpClient httpClient) : base(httpClient) { }

    /// <summary>학생 목록을 조회합니다.</summary>
    /// <param name="request">필터 및 페이지 옵션. null이면 기본값 적용.</param>
    /// <param name="cancellationToken">취소 토큰.</param>
    public Task<StudentResponse> GetStudentsAsync(
        StudentRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        var r = request ?? new StudentRequest();

        var queryParams = new (string, string?)[]
        {
            ("studentId",              r.StudentId?.ToString()),
            ("name",                   r.Name),
            ("email",                  r.Email),
            ("grade",                  r.Grade?.ToString()),
            ("classNum",               r.ClassNum?.ToString()),
            ("number",                 r.Number?.ToString()),
            ("sex",                    ToApiString(r.Sex)),
            ("role",                   ToApiString(r.Role)),
            ("dormitoryRoom",          r.DormitoryRoom?.ToString()),
            ("includeGraduates",       r.IncludeGraduates?.ToString().ToLowerInvariant()),
            ("includeWithdrawn",       r.IncludeWithdrawn?.ToString().ToLowerInvariant()),
            ("onlyEnrolled",           r.OnlyEnrolled?.ToString().ToLowerInvariant()),
            ("page",                   r.Page?.ToString()),
            ("size",                   r.Size?.ToString()),
            ("sortBy",                 ToApiString(r.SortBy)),
            ("sortDirection",          ToApiString(r.SortDirection)),
        };

        return GetAsync<StudentResponse>("/v1/students", queryParams, cancellationToken);
    }
}
