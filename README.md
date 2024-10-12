# Unpathed

![UnpathedGIF3](https://github.com/user-attachments/assets/08ed9127-510d-42d6-8095-affdcd7cfeb9)

Lead the ball by rotating the stage to the unknown. Beware of the traps, and interact with the platforms to make the ball way through.

## About Game
Unpathed is a single player game where you control the stage to move the ball through the next stage. There's a bunch of platforms and traps the ball can interact to, including a one-way, a moving cart, a pressure plate, to a laser trap that can disintegrate the ball.
You also have a skill where you can freeze a platform by clicking on it to help the ball go through the stage. The skill have a cooldown and duration, so use it wisely.

## Mechanics

### Stage Transition
When the ball get to the next stage by going through the exit / enter path, the ball will spawn on the determined position on the stage said.

![Unpathed stage transition](https://github.com/user-attachments/assets/4d8a54f5-cea8-4c1d-bc8e-59946a6bb299)

The stage rotation also persist throughout stages.

### Freeze skill
When the ball collect the freeze orb in stage 3, player will have the ability to stop platform in time.

![Unpathed freeze skill](https://github.com/user-attachments/assets/a32b7499-9bff-497e-bea5-61f6d905eefe)

The player can freeze moving cart, moving block, spike trap, and laser trap.

### Platforms and Traps
Some platforms and traps:

![Unpathed platforms](https://github.com/user-attachments/assets/523672fb-550f-4f4a-a607-19d90965e5a9)

Top left: Open and close door by rolling the ball through a button
Top right: Laser and spike trap. Spike trap only cover a short area, while laser will shoot until it detects an object.
Bottom: A moving block that triggered by a pressure plate (off screen).

## Scripts
Each platform / trap has it's own scripts. Scripts shown below are the major ones.

| Script | Description |
| --- | --- |
| `GameManager.cs` | Manages the game mechanics that persist through scenes like stage rotation, freeze skill cooldown, spawn point, etc. |
| `ArenaController.cs` | Handles the rotation of the stage (arena), where it actually rotates around the ball to prevent the ball getting glitched. |
| SO Folder | Consists of `DoorSO.cs`, `HallwaySO.cs`, and `Moveblock.cs`. Which handles the Scriptable Objects of said object. |
| `etc` | |

## Assets

All 3d models in this game were made by myself (although some of them is incomplete). We used texture from other people which can be downloaded here:
- https://www.poliigon.com
- https://freepbr.com

