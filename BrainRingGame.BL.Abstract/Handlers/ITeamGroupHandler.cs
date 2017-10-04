using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.BL.Abstract.Handlers
{
    public interface ITeamGroupHandler
    {
        IDataResult<List<ISubStage>> GenerateTeamGroups(int stageNumber);
    }
}