using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BrainRingGame.BL.Abstract.Recources;
using BrainRingGame.Entity.Abstract.Common.Results;
using BrainRingGame.Entity.Abstract.EntityHolders;
using BrainRingGame.Entity.Abstract.Enums;
using BrainRingGame.Entity.Impl.Common.Results;
using BrainRingGame.Entity.Impl.GameEntity;

namespace BrainRingGame.BL.Impl.Recources
{
    public class ComponentSaver  : IComponentSaver
    {
        

        public IResult SaveComponents()
        {
            try
            {
                using (FileStream fs = new FileStream(GameEntityHolder.AutoSavePath, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, new GameEntityInstanced());
                }

                return new Result()
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                //TODO Log here 
                return new Result()
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }
    }
}