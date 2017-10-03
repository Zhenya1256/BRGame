using System;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Abstract.GameEntity.Base;
using BrainRingGame.Entity.Impl.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity
{
    [Serializable]
    public class Ansver : NumericEntity, IAnsver 
    {
        public IQuestion Question { get; set; }
        public IStage Stage { get; set; }
    }
}