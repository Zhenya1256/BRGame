using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using BrainRingGame.BL.Abstract.Handlers;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.Common.Results;
using BrainRingGame.Entity.Impl.GameEntity;

namespace BrainRingGame.BL.Impl.Handlers
{
    public class TeamGroupHandler : ITeamGroupHandler
    {
        public IResult GenerateTeamGroups(int stageNumber)
        {
            if (GameEntityHolder.Teams == null ||
                !GameEntityHolder.Teams.Any())
            {
                return new Result()
                {
                    //TODO Set Error message from errorholder
                    Success = false
                };
            }

            Random rand = new Random();
            int currentCommand;
            int minRange = 0, maxRange = GameEntityHolder.Teams.Count;
            IResult methodResult = new Result()
            {
                Success = false
            };

            switch (stageNumber)
            {
                case 1:
                    List<ITeam> teams = new List<ITeam>();
                    teams.AddRange(GameEntityHolder.Teams);

                    foreach (var subStage in GameEntityHolder.Game.CurrentChild.ChildItemss)
                    {
                        currentCommand = rand.Next(minRange, maxRange);
                        ITeam team = teams.FirstOrDefault(p => p.Id == currentCommand);
                        if (team != null)
                        {
                            GroupTeam teamToAdd = new GroupTeam()
                            {
                                Id = team.Id,
                                TeamType = team.TeamType,
                                IsExisting = team.IsExisting,
                                Name = team.Name,
                                TeamColor = team.TeamColor,
                                Place = 0,
                                Points = 0
                            };

                            subStage.TeamInformation.TeamsInGroup.Add(teamToAdd);
                            teams.Remove(team);
                        }
                    }

                    methodResult = new Result()
                    {
                        Success = true
                    };

                    break;

                case 2:
                    List<IGroupTeam> teamsSecondStage = new List<IGroupTeam>();

                    var childItemss = GameEntityHolder.Game.ChildItemss
                        .FirstOrDefault(p => p.StageNumber == 1)?.ChildItemss;

                    if (childItemss != null)
                    {
                        foreach (ISubStage subStage in childItemss)
                        {
                            teamsSecondStage.AddRange(subStage.TeamInformation.TeamsInGroup);
                        }
                    }

                    GameEntityHolder.Game.CurrentChild.CurrentChild.TeamInformation
                        .TeamsInGroup = new List<IGroupTeam>();
                    //TODO Remove 4 => to config section
                    for (int i = 1; i <= 4; i++)
                    {
                        GameEntityHolder.Game.CurrentChild.CurrentChild.TeamInformation
                            .TeamsInGroup.AddRange(teamsSecondStage.Where(p => p.Place == i));
                    }

                    methodResult = new Result()
                    {
                        Success = true
                    };

                    break;

                    default:
                        break;
            }

            return methodResult;
        }
    }
}