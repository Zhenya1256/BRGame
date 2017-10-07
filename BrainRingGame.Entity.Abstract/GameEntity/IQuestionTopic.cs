using BrainRingGame.Entity.Abstract.GameEntity.Base;
using System.IO;

namespace BrainRingGame.Entity.Abstract.GameEntity
{
    public interface IQuestionTopic : IBaseEntityWithChild<IQuestion>
    {
        string Text { get; set; }
        MemoryStream Image { get; set; }
    }
}