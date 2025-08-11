using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace CuffedPlayerDamage.Handlers
{
    public class PlayerHandler
    {
        private readonly Config _config;
        public PlayerHandler(Config config) => _config = config;

        public void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Player == null || ev.Attacker == null || !ev.Player.IsCuffed)
                return;

            if (ev.Player.Role.Team == Team.SCPs || ev.Player.Role == RoleTypeId.Tutorial)
                return;
            
            if (ev.Player == ev.Attacker)
                return;

            if (ev.Attacker.Role.Team == Team.SCPs)
                return;

            ev.IsAllowed = false;

            if (_config.SlowdownDuration > 0)
            {
                ev.Player.EnableEffect(EffectType.AmnesiaVision, _config.SlowdownIntensity, _config.SlowdownDuration, false);
                ev.Player.EnableEffect(EffectType.Slowness, _config.SlowdownIntensity, _config.SlowdownDuration, false);
            }
        }
    }
}