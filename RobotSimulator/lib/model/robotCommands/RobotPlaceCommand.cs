namespace RobotSimulator.Model;

public class RobotPlaceCommand : IRobotCommand
{
    public void Execute(string command)
    {
        Console.WriteLine("Executing PLACE Command");
    }
}