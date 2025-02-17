namespace RobotSimulator.Model;

public abstract class RobotRotateCommand : IRobotCommand
{
    public void Execute(Robot robot, string command)
    {
        if (!robot.IsPlaced)
        {
            return;
        }

        Rotate(robot);
    }

    protected abstract void Rotate(Robot robot);
}