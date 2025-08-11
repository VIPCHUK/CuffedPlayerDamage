Disables damage to the cuffed player, but slows them down when shot at.

## Config
- Duration of the slowness effect in seconds
```
public float SlowdownDuration { get; set; } = 1.5f;
```
- Slowness intensity
```
public byte SlowdownIntensity { get; set; } = 90;
```
- Disable or Enable plugin:
```
public bool IsEnabled { get; set; } = true;
```
