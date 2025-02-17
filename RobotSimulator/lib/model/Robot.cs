namespace RobotSimulator.Model;

public class Robot
{
    public bool IsPlaced { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string Direction { get; set; }

    override public string ToString()
    {
        return $"{X},{Y},{Direction}";
    }
}