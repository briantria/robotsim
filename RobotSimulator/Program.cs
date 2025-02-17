﻿namespace RobotSimulator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Robot Simulator!");
        Console.WriteLine("Commands: PLACE, MOVE, LEFT, RIGHT, REPORT");
        Console.WriteLine("Type 'EXIT' to quit the program.");

        while (true)
        {
            //Console.WriteLine("Enter a command: ");
            var command = Console.ReadLine();

            if (!string.IsNullOrEmpty(command) && command.ToUpper() == "EXIT")
            {
                break;
            }

            Console.WriteLine($"You entered: {command}");
        }
    }
}
