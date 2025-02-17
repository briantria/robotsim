namespace RobotSimulator.Model;

public class RobotPlaceCommand : IRobotCommand
{
    public void Execute(Robot robot, string command)
    {
        var parts = command.Split(' ');
        if (parts.Length < 2)
        {
            return;
        }

        var positionParts = parts[1].Split(',');
        if (positionParts.Length < 3) 
        {
            return;
        }

        if (!int.TryParse(positionParts[0], out int x) ||
            !int.TryParse(positionParts[1], out int y)) 
        {
            return;
        }

        var dir = positionParts[2].ToUpper();
        if (!FaceDirections.IsValid(dir)) 
        {
            return;
        }

        robot.Place(x, y, dir);
    }
}