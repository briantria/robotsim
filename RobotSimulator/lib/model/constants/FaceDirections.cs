namespace RobotSimulator.Model;

public static class FaceDirections
{
    public const int ROTATE_CLOCKWISE = 1;
    public const int ROTATE_COUNTERCLOCKWISE = -1;

    public const string NORTH = "NORTH";
    public const string EAST = "EAST";
    public const string SOUTH = "SOUTH";
    public const string WEST = "WEST";

    private static readonly string[] _directions = { NORTH, EAST, SOUTH, WEST };

    public static bool IsValid(string direction)
    {
        return direction == NORTH || direction == EAST || direction == SOUTH || direction == WEST;
    }

    public static string GetNextDirection(string currentDirection, int rotateDirection)
    {
        var currentIndex = Array.IndexOf(_directions, currentDirection);
        var nextIndex = (currentIndex + rotateDirection + _directions.Length) % _directions.Length;
        return _directions[nextIndex];
    }
}