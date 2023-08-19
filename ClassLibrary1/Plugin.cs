using CommandSystem.Commands.RemoteAdmin.ServerEvent;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using PluginAPI.Events;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary1
{
    public class Plugin: Plugin<Config>
    {
        public static Plugin Instance { get; } = new();
        public static Config Configs = Instance.Config;
        private Plugin()
        {
        }
        public override string Name => "welcome";
        public override string Author => "yjjx";
        public override string Prefix => "wc";

        public override void OnEnabled()
        {
            Log.Info("piZda");
            base.OnEnabled();
            Exiled.Events.Handlers.Player.ActivatingGenerator += Player_ActivatingGenerator;
            Exiled.Events.Handlers.Player.Shooting += Player_Shooting;

        }

        private void Player_Shooting(ShootingEventArgs ev)
        {
            //throw new System.NotImplementedException();

        }

        private void Player_ActivatingGenerator(ActivatingGeneratorEventArgs ev)
        {
            //throw new System.NotImplementedException();
            ev.Player.Broadcast(10, "сообщение от 079: ВЫРУБИ СУКА");
        }

        private void Player_Verified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(5, "hello epta");
            //throw new System.NotImplementedException();
            Cassie.Message("nu is now");
        }
    }
}
