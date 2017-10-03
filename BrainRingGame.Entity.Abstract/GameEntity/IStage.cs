using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IStage : INumericEntity, IBaseStageEntityWithChild
    {
        string Name { get; set; }
        StageState StageState { get; set; }
        int StageNumber { get; set; }
    }
}