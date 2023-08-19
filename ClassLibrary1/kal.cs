using CommandSystem;
using CustomPlayerEffects;
using Exiled.API.Extensions;
using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class kal : ICommand
    {
        public IEnumerator<float> MyCoroutine(int x)
        {
            for (; ; )
            {
                Log.Info("kek");
                yield return Timing.WaitForSeconds(x);
            }
        }
        public string Command => "pizda";

        public string[] Aliases => new string[] {"pz", "pizdc", "pzdc"};
        public string Description => "nice cum";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var time = arguments;

            if (arguments.Count != 1)
            {
                response = "введите длительность";
                return false;
            }
            if (int.TryParse(arguments.At(0), out int value))
            {
                Timing.RunCoroutine(MyCoroutine(value));
                response = "ЖДЕМ СУКА";
            }
            //throw new NotImplementedException();
            var PlayerGet = Player.Get(sender);
            var room = PlayerGet.CurrentRoom;
            room.TurnOffLights(5);
            PlayerGet.Broadcast(5, Plugin.Configs.testa);
            room.LockDown(5);
            response = "sveta net";
            return true;
        }
    }
}
