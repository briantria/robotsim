# Robot Simulator

## Environment
- .Net 8.0

## Compiling the Project

1. Open terminal.
2. Move to project folder by running `cd ~/.../RobotSimulator/`.
3. Run `dotnet publish`.
4. Release version should be in `~/.../RobotSimulator/RobotSimulator/bin/Release/net8.0/publish/`

## Running the Application
1. Open Terminal.
2. Move to the compiled folder by running `cd ~/.../RobotSimulator/RobotSimulator/bin/Release/net8.0/publish/`
3. On Windows, run `.\RobotSimulator.exe`. For Mac or Linux, run `./RobotSimulator`. You can also run `dotnet RobotSimulator.dll` on any platform.

## Running with File Input
To use commands from external file, simply run the app followed by a space and the file path. For example,

```
dotnet RobotSimulator.dll ~/.../commands.txt
```

## Commands
- `PLACE X,Y,F` will put the toy robot on the table in position X,Y and facing (F) NORTH, SOUTH, EAST or WEST.
- `MOVE` will move the toy robot one unit forward in the direction it is currently facing.
- `LEFT` and `RIGHT` will rotate the robot 90 degrees in the specified direction without changing the position
of the robot.
- `REPORT` will announce the X,Y and F of the robot.