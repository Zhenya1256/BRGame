using BrainRingGame.Entity.Abstract.Common.Results;

namespace BrainRingGame.Entity.Impl.Common.Results
{
    public class Result :  IResult
    {
       public bool Success { get; set; }
       public string Message { get; set; }
    }
}