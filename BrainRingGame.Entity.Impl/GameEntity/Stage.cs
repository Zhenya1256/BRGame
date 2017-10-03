using System;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class Stage : BaseStageEntityWithChild, IStage
    {
        public string Name { get; set; }
        public StageState StageState { get; set; }
        public int StageNumber { get; set; }
    }
}