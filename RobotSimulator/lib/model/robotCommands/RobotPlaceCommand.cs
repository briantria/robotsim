namespace RobotSimulator.Model;

public class RobotPlaceCommand : IRobotCommand
{
    public void Execute(Robot robot, string command)
    {
        Console.WriteLine("Executing PLACE Command");
    }
}