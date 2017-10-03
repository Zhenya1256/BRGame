using BrainRingGame.Entity.Abstract.Common.Results.StageChangeResults;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.Entity.Impl.Common.Results.StageChangeResults
{
    public class StageChangeDataResult<T> : IStageChangeDataResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public ChangeStateType ChangeStateType { get; set; }
    }
}