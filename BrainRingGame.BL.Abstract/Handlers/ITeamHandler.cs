using System.Collections.Generic;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.BL.Abstract.Handlers
{
    public interface ITeamHandler
    {
        IResult BuildTeams(List<ITeam> teams, int totalCount);
        IResult AppendTeamsBuild(int totalCount);
    }

    //public interface GameInitializer
}