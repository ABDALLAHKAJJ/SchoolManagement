namespace SchoolManagement.Libraries.Core.Abstracts
{
    public interface IDataResult<out TEntity> : IResult
    {
        TEntity Data { get; }
    }
}