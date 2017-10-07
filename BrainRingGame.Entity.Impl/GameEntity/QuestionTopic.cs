using System;
using System.IO;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class QuestionTopic : BaseEntityWithChild<IQuestion> , IQuestionTopic
    {
        public string Text { get; set; }
        public MemoryStream Image { get; set ; }
    }
}