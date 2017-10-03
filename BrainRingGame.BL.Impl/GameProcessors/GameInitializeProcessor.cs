using System;
using System.Threading;
using BrainRingGame.BL.Abstract.GameProcessors;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.BL.Impl.GameProcessors
{
    public class GameInitializeProcessor : IGameInitializeProcessor
    {
        public IDataResult<IGame> InitGame(string archivePath)
        {
            throw  new NotImplementedException();
        }
    }
}