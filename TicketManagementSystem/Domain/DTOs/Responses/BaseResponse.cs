namespace Domain.DTOs.Responses;

public class BaseResponse
{
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; } = string.Empty;
}

public class BaseResponse<T>
{
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; } = string.Empty;
    public T? Value { get; set; }
}