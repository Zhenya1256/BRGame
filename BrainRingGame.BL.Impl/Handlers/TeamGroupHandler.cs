﻿using System;
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
       private Random _random = new Random();

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

            Result methodResult = new Result()
            {
                Success = true
            };

            switch (stageNumber)
            {
                case 1:
                    StageNumberOne(ref methodResult);

                    break;

                case 2:
                    StageNumberTwo(ref methodResult);
                    break;

                    default:
                        break;
            }

            return methodResult;
        }

        private void StageNumberOne(ref Result methodResult)
        {
            List<ITeam> teams = new List<ITeam>();
            teams.AddRange(GameEntityHolder.Teams);
            int currentCommand;
            int minRange = 0, maxRange = GameEntityHolder.Teams.Count;         


            foreach (SubStage subStage in GameEntityHolder.Game.CurrentChild.ChildItemss)
            {
                currentCommand = _random.Next(minRange, maxRange);
           
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
                Success = true,
            };
        }

        private void StageNumberTwo(ref Result methodResult)
        {
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

            for (int i = 1; i <= 4; i++)
            {
                GameEntityHolder.Game.CurrentChild.CurrentChild.TeamInformation
                    .TeamsInGroup.AddRange(teamsSecondStage.Where(p => p.Place == i));
            }

            methodResult = new Result()
            {
                Success = true
            };
        }
    }
}