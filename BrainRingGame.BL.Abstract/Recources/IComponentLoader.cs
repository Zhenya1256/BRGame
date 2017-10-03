using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.Component;

namespace BrainRingGame.BL.Abstract.Recources
{
    public interface IComponentLoader : IComponentReader, IComponentValidator
    {
        IDataResult<IStageComponent> GetRootWithChildInstance();
    }
}