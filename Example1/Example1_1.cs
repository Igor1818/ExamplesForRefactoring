
public class Player
{
    public int Health {
        get; private set;
    }

    public Player(int health) {
        Health = health;
    }

    public void SetHealth(int value) {
        Health = value;
    }
}

class Program
{
    private const int NewPayerHealth = 100;
    private const int Damage = 10;

    protected static Player player;

    public static void Main(string[] args)
    {
        // Create a new player.
        player = new Player(NewPayerHealth);
        // Hit the player.
        player.SetHealth(player.Health - Damage);
    }
}



