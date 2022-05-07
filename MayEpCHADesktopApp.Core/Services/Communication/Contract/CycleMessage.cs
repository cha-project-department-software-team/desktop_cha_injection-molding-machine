using System;
namespace ImmServiceContainers;
public class CycleMessage
{
    public string ProductId { get; set; }
    public DateTime Timestamp { get; set; }
    public double CycleTime { get; set; }
    public double OpenTime { get; set; }
    public int Mode { get; set; }
    public int CounterShot { get; set; }
    public string MoldId { get; set; }
    public double SetCycle { get; set; }
}
