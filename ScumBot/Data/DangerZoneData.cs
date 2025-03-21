namespace ScumBot.Data;

public class DangerZoneData
{
    private string name;
    private List<ZombieSpawnerData> zombieSpawners = new List<ZombieSpawnerData>();
    private double x1, y1, x2, y2;

    public DangerZoneData(string name, ZombieSpawnerData[] zombieSpawners, double x1, double y1, double x2, double y2)
    {
        this.name = name;
        this.zombieSpawners.AddRange(zombieSpawners);
        this.x1 = Math.Max(x1, x2);
        this.y1 = Math.Max(y1, y2);
        this.x2 = Math.Min(x1, x2);
        this.y2 = Math.Min(y1, y2);
    }

    public string Name { get { return this.name; } }
    public List<ZombieSpawnerData> ZombieSpawners { get { return this.zombieSpawners; } }
    public double X1 { get { return this.x1; } }
    public double Y1 { get { return this.y1; } }
    public double X2 { get { return this.x2; } }
    public double Y2 { get { return this.y2; } }
}