namespace RobotSimulator.Model;

public class RobotMoveCommand : IRobotCommand
{
    public void Execute(Robot robot, string command)
    {
        if (!robot.IsPlaced)
        {
            return;
        }

        robot.Move();
    }
}