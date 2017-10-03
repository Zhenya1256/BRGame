namespace BrainRingGame.Entity.Abstract.GameEntity.Base
{
    public interface IBaseStageEntityWithChild : IBaseEntityWithChild<ISubStage>
    {
        ISubStageConfig CurrentSubStageConfig { get; set; }
    }
}