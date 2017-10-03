using BrainRingGame.Entity.Abstract.Common.Results.StageChangeResults;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.Entity.Impl.Common.Results.StageChangeResults
{
    public class StageChangeResult : IStageChangeResult
    {
        public ChangeStateType ChangeStateType { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
       
    }
}