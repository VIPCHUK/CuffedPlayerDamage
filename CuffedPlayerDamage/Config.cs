using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CuffedPlayerDamage
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        
        public bool Debug { get; set; } = false;

        [Description("Duration of the slowness effect in seconds.")]
        public float SlowdownDuration { get; set; } = 1.5f;
        
        [Description("Slowness intensity.")]
        public byte SlowdownIntensity { get; set; } = 90;
    }
}