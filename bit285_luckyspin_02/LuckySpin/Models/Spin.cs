using System;
namespace LuckySpin.Models;

public class Spin
{
    // Properties (notice their data types)
    public int Luck { get; set; }
    public int[]? Numbers { get; set; } //The question mark means that these properties are nullable
    public string? ImageDisplay { get; set; }
}
