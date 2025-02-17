namespace RobotSimulator.Model;

public class Map
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Map (int width, int height)
    {
        Width = width;
        Height = height;
    }

    public bool IsPositionWithinBounds (int x, int y)
    {
        return x >= 0 && x < Width && y >= 0 && y < Height;
    }
}