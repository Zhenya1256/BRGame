using System;
using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.GameEntity.Base;

namespace BrainRingGame.Entity.Impl.GameEntity.Base
{
    [Serializable]
    public class BaseEntityWithChild<T> : NumericEntity, IBaseEntityWithChild<T>
    {
        public T CurrentChild { get; set; }
        public List<T> ChildItemss { get; set; }
    }
}