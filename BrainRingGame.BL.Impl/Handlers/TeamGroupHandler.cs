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
       private Random _random = new Random();

        public IDataResult<List<ISubStage>> GenerateTeamGroups(int stageNumber)
        {
            if (GameEntityHolder.Teams == null ||
                !GameEntityHolder.Teams.Any())
            {
                return new DataResult<List<ISubStage>>()
                {
                    //TODO Set Error message from errorholder
                    Success = false
                };
            }

            DataResult<List<ISubStage>> methodResult = new DataResult<List<ISubStage>>()
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

        private void StageNumberOne(ref DataResult<List<ISubStage>> methodResult)
        {
            List<ITeam> teams = new List<ITeam>();
            teams.AddRange(GameEntityHolder.Teams);
            int currentCommand;
            int minRange = 0, maxRange = GameEntityHolder.Teams.Count;
            GameEntityHolder.Game = new Game();
            GameEntityHolder.Game.CurrentChild = new Stage();
            GameEntityHolder.Game.CurrentChild.ChildItemss = new List<ISubStage>();
         

            for (int i = 0; i < 4; i++)
            {
                GameEntityHolder.Game.CurrentChild.ChildItemss.Add(new SubStage());
            }
            List<ISubStage> stages=null;
            stages = new List<ISubStage>();
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
                    GameEntityHolder.Game.CurrentChild.StageNumber = 1;
                    subStage.TeamInformation = new TeamGroup();
                    subStage.TeamInformation.TeamsInGroup = new List<IGroupTeam>();
                    subStage.TeamInformation.TeamsInGroup.Add(teamToAdd);
                    stages.Add(subStage);
                    teams.Remove(team);
                }
            }

            methodResult = new DataResult<List<ISubStage>>()
            {
                Success = true,
                Data = stages
            };
        }

        private void StageNumberTwo(ref DataResult<List<ISubStage>> methodResult)
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

            GameEntityHolder.Game.CurrentChild.CurrentChild.TeamInformation
                .TeamsInGroup = new List<IGroupTeam>();
            //TODO Remove 4 => to config section
            for (int i = 1; i <= 4; i++)
            {
                GameEntityHolder.Game.CurrentChild.CurrentChild.TeamInformation
                    .TeamsInGroup.AddRange(teamsSecondStage.Where(p => p.Place == i));
            }

            methodResult = new DataResult<List<ISubStage>>()
            {
                Success = true
            };
        }
    }
}