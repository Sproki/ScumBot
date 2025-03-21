namespace ScumBot.Data;

public class ZombieSpawnerData
{
    private string name;
    private string zombieTyp;
    private double x;
    private double y;
    private double z;
    private int minZombies;
    private int maxZombies;
    private int minInterval;
    private int maxInterval;

    public ZombieSpawnerData(string name, string zombieTyp, double x, double y, double z, int minZombies, int maxZombies, int minInterval, int maxInterval)
    {
        this.name = name;
        this.zombieTyp = zombieTyp;
        this.x = x;
        this.y = y;
        this.z = z;

        if (minZombies > 0 && minZombies <= maxZombies)
        {
            this.minZombies = minZombies;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Die minimal Anzahl für Zombies die bei einer iteration Spawnen können müssen größer als 0 sein und kleiner als die miaxmal Anzahl an Zombies die spawen können.");
        }

        if (maxZombies > 0 && maxZombies >= minZombies)
        {
            this.maxZombies = maxZombies;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Die maximal Anzahl für Zombies die bei einer iteration Spawnen können müssen größer als 0 sein und größer oder gleich als die minimal Anzahl an Zombies die spawen können.");
        }

        if (minInterval > 0 && minInterval <= maxInterval)
        {
            this.minInterval = minInterval;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Die minimale Sekundenangabe darf nicht kleiner als 0 sein und muss kleiner oder gleich der maxmimalen Sekunden anzahl sein.");
        }

        if (maxInterval > 0 && maxInterval >= minInterval)
        {
            this.maxInterval = maxInterval;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Die miaxmlae Sekundenangabe darf nicht kleiner als 0 sein und muss größer oder gleich der maxmimalen Sekunden anzahl sein.");
        }
    }

    public string Name { get { return this.name; } }
    public string ZombieTyp { get { return this.zombieTyp; } }
    public double X { get { return this.x; } }
    public double Y { get { return this.y; } }
    public double Z { get { return this.z; } }
    public int MinZombies { get { return this.minZombies; } }
    public int MaxZombies { get { return this.maxZombies; } }
    public int MinInterval { get { return this.minInterval; } }
    public int MaxInterval { get { return this.maxInterval; } }
}