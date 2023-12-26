namespace ALevelSample.Dtos.Responses;

public sealed class BaseResponse<T>
    where T : class
{
    public T Data { get; set; }
    public SupportDto Support { get; set; }
}