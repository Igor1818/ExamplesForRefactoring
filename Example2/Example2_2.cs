
public class ExtPlayer : Player
{
	private Action innerChanged;

	public event Action Changed {
		add {
			innerChanged += value;
			value();
		}
		remove {
			innerChanged -= value;
		}
	}
}

class ExtProgram : Program
{
	// A widget that displays the player's health.
	private static TextView healthView = new TextView();

	private static int? previousHealth;

	public static void ExtMain(string[] args)
	{
		// Вызов кода по созданию игрока.
		Main(args);

		player.Changed += OnPlayerChanged;

		// Hit the player.
		HitPlayer();
	}

	private static void OnPlayerChanged()
	{
		healthView.Text = player.Health.ToString();
		if (previousHealth != null && player.Health - previousHealth < -10) {
			healthView.Color = Color.Red;
		} else {
			healthView.Color = Color.White;
		}
		previousHealth = player.Health;
	}
}


