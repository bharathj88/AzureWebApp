namespace MvcApp.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class ErrorResponse
{
    public ErrorDetails Error { get; set; }
}

public class ErrorDetails
{
    public int Status { get; set; }
    public int Code { get; set; }
    public string Message { get; set; }
    public string DocUrl { get; set; }
}
