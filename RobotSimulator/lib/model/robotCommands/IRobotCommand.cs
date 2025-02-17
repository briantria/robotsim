namespace RobotSimulator.Model;

interface IRobotCommand
{
    public void Execute(Robot robot, string command);
}