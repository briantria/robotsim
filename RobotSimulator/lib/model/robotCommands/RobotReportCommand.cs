namespace RobotSimulator.Model;

public class RobotReportCommand : IRobotCommand
{
    public void Execute(Robot robot, string command)
    {
        if (robot.IsPlaced)
        {
            Console.WriteLine(robot.ToString());
        }
    }
}