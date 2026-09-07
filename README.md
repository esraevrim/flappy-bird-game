\# Flappy Bird - Unity Project



A classic Flappy Bird-style 2D game built with Unity.



\## Features



\- Bird character with jump mechanics and collision detection

\- Moving pipe obstacles, spawned procedurally

\- Score system: points earned for each pipe passed

\- Game Over screen with a restart function



\## Tech Stack



\- Unity 6 (6000.5.9f1)

\- C#



\## Project Structure



\- `BirdScript.cs` — handles the bird's movement, jump, and alive state (`isAlive`)

\- `PipeMoveScript.cs` — moves pipes leftward and destroys them once off-screen

\- `PipeSpawner.cs` — spawns pipes at regular intervals

\- `LogicScript.cs` — handles score tracking, the Game Over screen, and restarting the game



\## How to Run



1\. Open the project via Unity Hub (Unity 6.5 or a compatible version required).

2\. Open the main scene (`SampleScene`) under `Assets/Scenes`.

3\. Press Play to test the game.



\## Controls



\- Jump: (add your control here, e.g. Space / Left Click)



\## Status



This project is under active development.

