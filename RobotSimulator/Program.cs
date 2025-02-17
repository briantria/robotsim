using RobotSimulator.Controller;
using RobotSimulator.Model;

namespace RobotSimulator;

class Program
{
    static void Main(string[] args)
    {
        var map = new Map(5, 5);
        var robot = new Robot(map);
        var robotCommandParser = new RobotCommandParser();

        Console.WriteLine("Welcome to the Robot Simulator!");

        if (args.Length > 0)
        {
            RunFromFile(args[0], robot, robotCommandParser);
        }
        else
        {
            RunFromConsole(robot, robotCommandParser);
        }
    }

    static void RunFromFile(string filePath, Robot robot, RobotCommandParser robotCommandParser)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File {filePath} does not exist.");
            return;
        }

        Console.WriteLine($"Running commands from {filePath} {Environment.NewLine}");
        var commands = File.ReadAllLines(filePath);
        foreach (var command in commands)
        {
            if (string.IsNullOrEmpty(command))
            {
                continue;
            }
            
            Console.WriteLine(command);
            if (!robotCommandParser.TryParse(robot, command))
            {
                Console.WriteLine($"{command} is invalid.");
            }
        }
    }

    static void RunFromConsole(Robot robot, RobotCommandParser robotCommandParser)
    {
        Console.WriteLine($"{Environment.NewLine}Commands: PLACE, MOVE, LEFT, RIGHT, REPORT");
        Console.WriteLine($"Type 'EXIT' to quit the program.{Environment.NewLine}");

        while (true)
        {
            var command = Console.ReadLine();

            if (!string.IsNullOrEmpty(command) && command.ToUpper() == CommandKeys.EXIT)
            {
                break;
            }
            
            if (!robotCommandParser.TryParse(robot, command))
            {
                Console.WriteLine($"{command} is invalid.");
            }
        }
    }
}
