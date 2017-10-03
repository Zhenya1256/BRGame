using System;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity.Base
{
    [Serializable]
    public class BaseStageEntityWithChild  : BaseEntityWithChild<ISubStage>,  IBaseStageEntityWithChild 
    {
        public ISubStageConfig CurrentSubStageConfig { get; set; }
    }
}