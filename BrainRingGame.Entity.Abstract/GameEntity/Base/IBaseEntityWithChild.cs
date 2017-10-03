using System.Collections.Generic;

namespace BrainRingGame.Entity.Abstract.GameEntity.Base
{
    public interface IBaseEntityWithChild<T>
    {
        T CurrentChild { get; set; }
        List<T> ChildItemss { get; set; }
    }
}