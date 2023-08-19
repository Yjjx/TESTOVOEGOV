using CommandSystem.Commands.RemoteAdmin;
using CommandSystem.Commands.RemoteAdmin.ServerEvent;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using InventorySystem;
using PlayerRoles;
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
            Exiled.Events.Handlers.Player.Spawned += Player_Spawned1;
            Exiled.Events.Handlers.Warhead.Detonated += Warhead_Detonated;

        }

        private void Player_Spawned1(SpawnedEventArgs ev)
        {
            //throw new System.NotImplementedException();
            if (ev.Player.Role.Type is RoleTypeId.Scientist)
            {
                ev.Player.Health = 500;
                ev.Player.Inventory.ServerAddItem(ItemType.SCP500);
                ev.Player.Inventory.ServerAddAmmo(ItemType.Ammo9x19, 100);


            }
        }

        private void Warhead_Detonated()
        {
            //throw new System.NotImplementedException();
            foreach (Exiled.API.Features.Player Player in Exiled.API.Features.Player.List)
            {
                Player.Kill("у вас сгорело очко");
            }
        }

        private void Player_ChangingRole(ChangingRoleEventArgs ev)
        {
            //throw new System.NotImplementedException();
            if ( ev.NewRole is RoleTypeId.Scientist)
            {
                ev.Player.Health = 500;
                ev.Player.Inventory.ServerAddItem(ItemType.SCP500);
                ev.Player.Inventory.ServerAddAmmo(ItemType.Ammo9x19, 100);
     

            }
        }

        private void Player_Spawned(SpawnedEventArgs ev)
        {
            //throw new System.NotImplementedException();
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
            //testcoment
            Cassie.Message("nu is now");
        }
    }
}
