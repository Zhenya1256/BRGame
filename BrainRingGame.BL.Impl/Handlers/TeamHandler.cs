using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using BrainRingGame.BL.Abstract.Handlers;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.Common.Results;
using BrainRingGame.Entity.Impl.GameEntity;

namespace BrainRingGame.BL.Impl.Handlers
{
    public class TeamHandler : ITeamHandler
    {
        public IResult BuildTeams(List<ITeam> teams, int totalCount)
        {
            if (GameEntityHolder.Teams == null)
            {
                GameEntityHolder.Teams = new List<ITeam>();
            }

            foreach (ITeam team in teams)
            {
                team.TeamType = TeamType.User;
                team.IsExisting = true;
                //TODO check
                team.Id = teams.IndexOf(team);
            }

            GameEntityHolder.Teams.AddRange(teams);

            return new Result()
            {
                Success = true

            };
        }

        public IResult AppendTeamsBuild(int totalCount)
        {
            if (GameEntityHolder.Teams != null &&
                GameEntityHolder.Teams.Any())
            {
                //TODO Load data from config section
                if (GameEntityHolder.Teams.Count < 16)
                {
                    for (int i = 0; i < 16 - GameEntityHolder.Teams.Count; i++)
                    {
                        GameEntityHolder.Teams.Add(new GroupTeam()
                        {
                            Id = i,
                            IsExisting = true,
                            TeamType = TeamType.Machine,
                            Place = 0,
                            TeamColor = Color.DarkGray,
                            //TODO remove to recource holder
                            Name =
                            $"Авто згенерована команда_{i + 1}",
                            Points = 0
                        });
                    }
                }
            }

            return new Result()
            {
                Success = true
            };
        }
    }
}