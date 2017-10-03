namespace BrainRingGame.Entity.Abstract.Common.Results
{
    public interface IResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}