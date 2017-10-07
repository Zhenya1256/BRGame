using BrainRingGame.Entity.Abstract.Common.Config;
using SimpleConfig;

namespace BrainRingGame.Entity.Abstract.EntityHolders
{
    public class ConfigurationHolder
    {
            private static GameStageConfigSection _stageConfigSection;

            public static GameStageConfigSection ApiConfiguration
            {
                get
                {
                    if (_stageConfigSection == null)
                    {

                        lock (typeof(ConfigurationHolder))
                        {
                            if (_stageConfigSection == null)
                            {

                                _stageConfigSection = Configuration.Load<GameStageConfigSection>("GameStageConfigSection");
                            }
                        }
                    }

                    return _stageConfigSection;
                }
            }
     }
}