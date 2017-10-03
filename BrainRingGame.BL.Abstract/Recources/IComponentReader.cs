using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.Component;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.BL.Abstract.Recources
{
    public interface IComponentReader
    {
        IDataResult<IStageComponent> GetComponent(DrawFileComponentType type);
    }
}