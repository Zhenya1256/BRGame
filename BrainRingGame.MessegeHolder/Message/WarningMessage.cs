using BrainRingGame.MessegeHolder.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.MessegeHolder.Message
{
    public static class WarningMessage
    {
        private readonly static Dictionary<WarningType, string> _warningDictionary;

        static WarningMessage()
        {
            _warningDictionary = new Dictionary<WarningType, string>();
            Initialize();
        }

        private static void Initialize()
        {
            _warningDictionary.Add(WarningType.Exit,
                "Ви дійсно хочете покинути гру ?");
        }

        public static string GetWarningMessag(WarningType type)
        {
            if (_warningDictionary.ContainsKey(type))
            {
                return _warningDictionary[type];
            }

            return null;
        }


    }
}
