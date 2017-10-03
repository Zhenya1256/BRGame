using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainRingGame.Entity.Abstract.GameEntity;

namespace BrainRingGame.Entity.Abstract.EntityHolders
{
    
    public static class GameEntityHolder
    {
        public static string AutoSavePath { get; set; }
        public static List<ITeam> Teams { get; set; }
        public static IGame Game { get; set; }
        public static string PathToArchive { get; set; }
        public static List<Color> ExistingCommandColors { get; set; }

        
    }

    [Serializable]
    public class GameEntityInstanced
    {
        public  string AutoSavePath { get; set; }
        public  List<ITeam> Teams { get; set; }
        public  IGame Game { get; set; }
        public  string PathToArchive { get; set; }
        public  List<Color> ExistingCommandColors { get; set; }

        public GameEntityInstanced()
        {
            AutoSavePath = GameEntityHolder.AutoSavePath;
            ExistingCommandColors = GameEntityHolder.ExistingCommandColors;
            Game = GameEntityHolder.Game;
            PathToArchive = GameEntityHolder.PathToArchive;
            Teams = GameEntityHolder.Teams;

        }
    }
}
