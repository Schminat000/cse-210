# Jumper
Jumper is a game in which the player seeks to solve a puzzle by guessing
the letters of a secret word, one at a time. If you guess incorrectly,
one line of the parachute is cut. If all lines of the parachute are cut,
the man dies and the game ends. Guess all correctly before the lines are
cut, you win!

## Getting Started
---
Make sure you have dotnet 6.0 or newer installed on your machine. Open 
a terminal and browse to the project's root folder. Start the program 
by running the following commands.
```
dotnet build
dotnet run 
```
You can also run the program from an IDE like Visual Studio Code. 
Start your IDE and open the project folder. Select "Run and Debug" on 
the Activity Bar. Next, select the project you'd like to run from the 
drop down list at the top of the Side Bar. Lastly, click the green 
arrow or "start debugging" button.

## Project Structure
---
The project files and folders are organized as follows:
```
root                    (project root folder)
+-- Game                (source code folder)
+-- Program.cs          (program entry point)    
+-- README.md           (general info)
+-- words.txt           (words used in the game)
+-- Unit02.csproj       (dotnet project file)
```

## Required Technologies
---
* dotnet 6.0

## Authors
---
* Nathan Schmidt