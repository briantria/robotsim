namespace RobotSimulator.Model;

public class Robot
{
    public bool IsPlaced { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Direction { get; private set; }

    private Map _map;

    public Robot(Map map)
    {
        IsPlaced = false;
        _map = map;
    }

    public void Place(int x, int y, string direction)
    {
        if (!_map.IsPositionWithinBounds(x, y) || !FaceDirections.IsValid(direction))
        {
            return;
        }

        X = x;
        Y = y;
        Direction = direction;
        IsPlaced = true;
    }

    public void Rotate(int direction)
    {
        Direction = FaceDirections.GetNextDirection(Direction, direction);
    }

    override public string ToString()
    {
        return $"{X},{Y},{Direction}";
    }
}