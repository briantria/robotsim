using RobotSimulator.Model;

namespace RobotSimulator.Controller;

public class RobotCommandParser
{
    private static readonly Dictionary<string, IRobotCommand> _commands = new Dictionary<string, IRobotCommand>
    {
        { RobotCommandKeys.PLACE, new RobotPlaceCommand() },
        { RobotCommandKeys.REPORT, new RobotReportCommand() },
        { RobotCommandKeys.LEFT, new RobotRotateLeftCommand() },
        { RobotCommandKeys.RIGHT, new RobotRotateRightCommand() }
    };

    public bool TryParse(Robot robot, string command)
    {
        var tokens = command.Split(' ');
        var key = tokens[0].ToUpper();

        if (!_commands.ContainsKey(key))
        {
            return false;
        }

        var robotCommand = _commands[key];
        robotCommand.Execute(robot, command);
        return true;
    }
}