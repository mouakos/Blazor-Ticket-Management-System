namespace Domain.DTOs.Responses;

public class BaseResponse
{
    #region Public properties declaration

    public string? ErrorMessage { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }

    #endregion
}

public class BaseResponse<T>
{
    #region Public properties declaration

    public string? ErrorMessage { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }
    public T? Value { get; set; }

    #endregion
}