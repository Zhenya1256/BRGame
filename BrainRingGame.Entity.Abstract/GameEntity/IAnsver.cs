using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IAnsver : INumericEntity
    {
        IQuestion Question { get; set; }
        IStage Stage { get; set; }
    }
}