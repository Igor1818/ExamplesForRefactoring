[Serializable]
public class Player
{
	public int Health {
		get;
		private set;
	}

	public Player() {
	}

	public void Hit(int damage) {
		Health -= damage;
	}
}

[Serializable]
public class Settings
{
	public int Damage { get; }
}

class Program
{
	private const string NewPlayerPath = "NewPlayer.json";
	private const string SettingsPath = "Settings.json";

	protected static Player player;

	public static void Main(string[] args)
	{
		// Create a new player.
		player = Serializer.LoadFromFile<Player>(NewPlayerPath);
		
		// Hit the player.
		var settings = Serializer.LoadFromFile<Settings>(SettingsPath);
		player.Hit(settings.Damage);
	}
}


