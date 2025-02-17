using RobotSimulator.Controller;
using RobotSimulator.Model;

namespace RobotSimulator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Robot Simulator!");
        Console.WriteLine("Commands: PLACE, MOVE, LEFT, RIGHT, REPORT");
        Console.WriteLine("Type 'EXIT' to quit the program.");

        var robotCommandParser = new RobotCommandParser();
        var robot = new Robot();

        while (true)
        {
            //Console.WriteLine("Enter a command: ");
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
