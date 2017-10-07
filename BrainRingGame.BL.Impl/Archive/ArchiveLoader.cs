using BrainRingGame.Entity.Abstract.Common.Config;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Impl.Common.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.BL.Impl.Archive
{
   public class ArchiveLoader
    {
        public IResult Loader(string pathArchiv)
        {
            IResult result = new Result() { Success = true };
            SaveTempFile save = new SaveTempFile();
            GameStageConfigSection configSection = ConfigurationHolder.ApiConfiguration;
            ValidataArchive validate = new ValidataArchive(configSection);


            //name Game
            string name = @"Game\";
            string pathTemp = Path.GetTempPath();
            string path = pathTemp + name;
            result.Success= save.CreateDirectory(name).Success;

            if (!result.Success)
            {
                result.Message = "Щось пішло не так";
                return result;
            }

            List<IResult> results = validate.ValidateDirectory(path);

            IResult resultDirectory = new Result() { Success = true };

            foreach(var res in results)
            {
                if (!res.Success)
                {
                    resultDirectory.Success = false;
                    resultDirectory.Message += res.Message;
                }
            }

            if (!resultDirectory.Success)
            {
                return resultDirectory;
            }

            results = validate.ValidateFiles(path);
            IResult resultFiles = new Result() { Success = true };

            foreach (var res in results)
            {
                if (!res.Success)
                {
                    resultFiles.Success = false;
                    resultFiles.Message += res.Message;
                }
            }

            if (!resultFiles.Success)
            {
                return resultFiles;
            }

            BuildGame buildGame = new BuildGame(configSection);

            buildGame.Build(path);

            return result;
        }
    }
}
