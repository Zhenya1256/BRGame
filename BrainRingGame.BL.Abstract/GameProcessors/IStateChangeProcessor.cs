using BrainRingGame.Entity.Abstract.Common.Results.StageChangeResults;

namespace BrainRingGame.BL.Abstract.GameProcessors
{
    public interface IStateChangeProcessor
    {
        IStageChangeResult CheckChange();
    }
}