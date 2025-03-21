namespace ScumBot.Data;

public class PlayerData
{
    private int scumPlayerId;
    private string playerName;
    private string steamName;
    private long steamId;
    private int famePoints;
    private int accountBalance;
    private double x;
    private double y;
    private double z;

    public PlayerData(int scumPlayerId, string playerName, string steamName, long steamId, int famePoints, int accountBalance,double x, double y, double z)
    {
        this.scumPlayerId = scumPlayerId;           // Eindeutig
        this.playerName = playerName;               // Eindeutig
        this.steamName = steamName;                 // Nicht Eindeutig (Kann sich verändern)
        this.steamId = steamId;                     // Eindeutig
        this.famePoints = famePoints;               // Nicht Eindeutig (Verändert sich unregelmäßig)
        this.accountBalance = accountBalance;       // Nicht Eindeutig (Verändert sich unregelmäßig)
        this.x = x;                                 // Nicht Eindeutig (Verändert sich unregelmäßig)
        this.y = y;                                 // Nicht Eindeutig (Verändert sich unregelmäßig)
        this.z = z;                                 // Nicht Eindeutig (Verändert sich unregelmäßig)
    }

    public int ScumPlayerId { get { return this.scumPlayerId; } }
    public string PlayerName { get { return this.playerName; } }
    public string SteamName { get { return this.steamName; } }
    public long SteamId { get { return this.steamId; } }
    public int FamePoints { get { return this.famePoints; } }
    public int AccountBalance { get { return this.accountBalance; } }
    public double X { get { return this.x; } }
    public double Y { get { return this.y; } }
    public double Z { get { return this.z; } }
}