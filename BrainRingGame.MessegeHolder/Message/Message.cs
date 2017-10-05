using BrainRingGame.MessegeHolder.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.MessegeHolder.Message
{
    public static class Message
    {
        private readonly static Dictionary<MessageType, string> _warningDictionary;

        static Message()
        {
            _warningDictionary = new Dictionary<MessageType, string>();
            Initialize();
        }

        private static void Initialize()
        {
            _warningDictionary.Add(MessageType.Exit,
                "Ви дійсно хочете покинути гру ?");
            _warningDictionary.Add(MessageType.LoadArchiv,
              "Зачекайте, будь ласка, йде загрузка та перевірка даних");
            _warningDictionary.Add(MessageType.FinichLoadArchiv,
            "Pагрузка та перевірка даних виконана успішно");

        }

        public static string GetWarningMessag(MessageType type)
        {
            if (_warningDictionary.ContainsKey(type))
            {
                return _warningDictionary[type];
            }

            return null;
        }


    }
}
