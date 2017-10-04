using BrainRingGame.BL.Impl.Handlers;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.GameEntity;
using BrainRingGame.Entity.Impl.Common.Results;
using BrainRingGame.Entity.Impl.GameEntity;
using BrainRingGame.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.ViewModel.ViewModelForWindow
{
    public class VMRandomComannds : ViewModelBase
    {

        private List<List<string>> groups;

        public VMRandomComannds()
        {
            TeamGroupHandler handler = new TeamGroupHandler();
            IDataResult<List<ISubStage>> result = handler.GenerateTeamGroups(1);
            groups = new List<List<string>>();

            if (result.Success)
            {
                List<ISubStage> substages = result.Data;

                foreach (ISubStage teams in substages)
                {

                    List<IGroupTeam> groupsTeam=  teams.TeamInformation.TeamsInGroup;
                    List<string> names = new List<string>();

                    foreach(var s in groupsTeam)
                    {
                        names.Add(s.Name);
                    }
                    groups.Add(names);
                }
            }

            SubStage stage = new SubStage();

        }


        public List<string> CommandsOne
        {
            get
            {
              
                return groups[0];
            }
        }
        public List<string> CommandsTwo
        {
            get
            {
              
                return groups[1];
            }
        }
        public List<string> CommandsThree
        {
            get
            {
               
                return groups[2];
            }
        }
        public List<string> CommandsFour
        {
            get
            {
                return groups[3];
            }
        }

    }
}
