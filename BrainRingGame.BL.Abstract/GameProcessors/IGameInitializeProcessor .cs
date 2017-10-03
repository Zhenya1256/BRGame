using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.BL.Abstract.GameProcessors
{
    public interface IGameInitializeProcessor
    {
        IDataResult<IGame> InitGame(string archivePath);
    }
}