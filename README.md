# Dead Block 🧟

A top-down **zombie shooter** built with **C# Windows Forms** (.NET Framework 4.7.2).

Survive as long as you can: zombies chase you from every side, each kill raises your score,
and ammo is limited, so grab the ammo drops (+5) when you run low.

## Controls

| Key | Action |
|---|---|
| ← ↑ → ↓ | Move |
| Space | Shoot in the direction you're facing |
| Enter | Restart after game over |

## Run

1. Open `dead_block.sln` in **Visual Studio** (with the .NET desktop development workload).
2. Press **F5** (Start).

The game has a start screen (`Form1`), a help screen (`HelpScreen`) and the game itself
(`GameScreen`): a timer-driven loop that moves zombies toward the player, checks bullet hits,
and tracks health, ammo and kills.
