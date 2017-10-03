using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.Entity.Abstract.Common.Results.StageChangeResults
{
    public interface IStageChangeResult : IResult
    {
        ChangeStateType ChangeStateType { get; set; }
    }
}