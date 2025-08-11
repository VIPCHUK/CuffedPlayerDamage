using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace CuffedPlayerDamage
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "CuffedPlayerDamage";
        public override string Author => "VIPCHUK";
        public override Version Version => new Version(1, 0, 0);

        private Handlers.PlayerHandler _playerHandler;

        public override void OnEnabled()
        {
            _playerHandler = new Handlers.PlayerHandler(Config);
            Player.Hurting += _playerHandler.OnHurting;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Hurting -= _playerHandler.OnHurting;
            _playerHandler = null;
            base.OnDisabled();
        }
    }
}