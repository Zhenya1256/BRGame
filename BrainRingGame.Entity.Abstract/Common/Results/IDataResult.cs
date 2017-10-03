namespace BrainRingGame.Entity.Abstract.Common.Results
{
    public interface IDataResult<TData> : IResult
    {
        TData Data { get; set; }
    }
}