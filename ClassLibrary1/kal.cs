using CommandSystem;
using CustomPlayerEffects;
using Exiled.API.Extensions;
using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class kal : ICommand
    {
        public IEnumerator<float> MyCoroutine()
        {
            for (; ; )
            {
                Log.Info("kek");
                yield return Timing.WaitForSeconds(5f);
            }
        }
        public string Command => "pizda";

        public string[] Aliases => new string[] {"pz", "pizdc", "pzdc"};
        public string Description => "nice cum";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            //throw new NotImplementedException();
            var PlayerGet = Player.Get(sender);
            var room = PlayerGet.CurrentRoom;
            room.TurnOffLights(5);
            PlayerGet.Broadcast(5, Plugin.Configs.testa);
            Timing.RunCoroutine(MyCoroutine());
            room.LockDown(5);
            response = "sveta net";
            return true;
        }
    }
}
