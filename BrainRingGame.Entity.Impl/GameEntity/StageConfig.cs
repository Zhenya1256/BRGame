using System;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class  SubStageConfig : ISubStageConfig
    {
        public int TopicCount { get; set; }
    }
}