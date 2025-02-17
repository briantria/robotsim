namespace RobotSimulator.Model;

public class RobotRotateLeftCommand : RobotRotateCommand
{
    protected override void Rotate(Robot robot)
    {
        robot.Rotate(FaceDirections.ROTATE_COUNTERCLOCKWISE);
    }
}