using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IQuestionTopic : IBaseEntityWithChild<IQuestion>
    {
        string Text { get; set; }
    }
}