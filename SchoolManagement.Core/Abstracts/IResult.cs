namespace SchoolManagement.Libraries.Core.Abstracts
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}