using BrainRingGame.BL.Abstract.Recources;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.Component;
using BrainRingGame.Entity.Abstract.Enums;

namespace BrainRingGame.BL.Impl.Recources
{
    public class ComponentReader :  IComponentReader
    {
        public IDataResult<IStageComponent> GetComponent(DrawFileComponentType type)
        {
            throw new System.NotImplementedException();
        }
    }
}