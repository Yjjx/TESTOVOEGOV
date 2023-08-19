using CommandSystem;
using CustomPlayerEffects;
using Exiled.API.Extensions;
using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
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
        public string Command => ".changeinfo";

        public string[] Aliases => new string[] {"ci"};
        public string Description => "Меняет информацию о вашей роли";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            string time = string.Concat(arguments);
            var PlayerGet = Player.Get(sender);
            time = PlayerGet.DisplayNickname;
            //throw new NotImplementedException();
            response = "изменино";
            return true;
        }
    }
}
