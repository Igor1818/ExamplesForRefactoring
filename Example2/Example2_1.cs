public class ExtPlayer : Player
{
	public delegate void HealthChangedDelegate(int oldHealth, int newHealth);

	public event HealthChangedDelegate HealthChanged;
}

class ExtProgram : Program
{
	// A widget that displays the player's health.
	private static TextView healthView = new TextView();

	public static void ExtMain(string[] args)
	{
		// Calling the code to create a player.
		Main(args);

		healthView.Text = player.Health.ToString();
		player.HealthChanged += OnPlayerHealthChanged;

		// Hit the player.
		HitPlayer();
	}

	private static void OnPlayerHealthChanged(int oldHealth, int newHealth)
	{
		healthView.Text = newHealth.ToString();
		if (newHealth - oldHealth < -10) {
			healthView.Color = Color.Red;
		} else {
			healthView.Color = Color.White;
		}
	}
}



