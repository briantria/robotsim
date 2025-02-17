namespace RobotSimulator.Model;

public class RobotRotateRightCommand : RobotRotateCommand
{
    protected override void Rotate(Robot robot)
    {
        robot.Rotate(FaceDirections.ROTATE_CLOCKWISE);
    }
}