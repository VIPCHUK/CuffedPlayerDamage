### CuffedPlayerDamage
Disables damage to the cuffed player, but slows them down when shot at.
## Installation
1. **Prerequisites**: Ensure you have EXILED 9.6.0+ installed on your SCP:SL server
2. **Download**: Get the latest release from the releases page
3. **Install**: Place `CuffedPlayerDamage.dll` in your `EXILED/Plugins` folder
4. **Configure**: Edit the generated config file to your preferences
5. **Restart**: Restart your server to load the plugin
   
## ⚙️ Configuration

```yaml
# CuffedPlayerDamage Configuration
cuffed_player_damage:
  is_enabled: true
  debug: false

  # Slowness intensity
  SlowdownIntensity: 80

  # Duration of the slowness effect in seconds
  SlowdownDuration: 1.5
```

## Compatibility
- **EXILED**: 9.6.0+
- **SCP:SL**: Compatible with latest versions
- **.NET Framework**: 4.8
