
public class Player
{
    private List<Vector2> activeWalkPath = null;
    private bool isMoving;
    private Vector2 currentPosition;
    private Player currentEnemy;

    public void Update()
    {
        if (currentEnemy != null)
        {
            var builtPath = TryBuildPathToCoord(currentEnemy.currentPosition);
            if (builtPath == null)
            {
                currentEnemy = null;
                isMoving = false;
                activeWalkPath = null;
            }
            else
            {
                isMoving = true;
                activeWalkPath = builtPath;
            }
        }
    }


    private List<Vector2> TryBuildPathToCoord(Vector2 target)
    {
        return <many lines of code to create a path from currentPosition to target>;
    }
}



