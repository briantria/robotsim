namespace RobotSimulator.Model;

public static class FaceDirections
{
    public const string NORTH = "NORTH";
    public const string EAST = "EAST";
    public const string SOUTH = "SOUTH";
    public const string WEST = "WEST";

    public static bool IsValid(string direction)
    {
        return direction == NORTH || direction == EAST || direction == SOUTH || direction == WEST;
    }
}