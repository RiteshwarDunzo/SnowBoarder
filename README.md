# SnowBoarder

`SnowBoarder` is a small 2D Unity game prototype where the player rides across a snowy track, balances the board, boosts for speed, avoids crashes, and reaches the finish line.

This project is built with Unity and C#, and it demonstrates a simple but complete gameplay loop using 2D physics, trigger/collision events, particle effects, audio feedback, and scene reloads.

## Game Overview

The player controls a snowboarder moving across a 2D slope.

- Use the left and right arrow keys to rotate the board in the air or while riding.
- Use the up arrow key to increase riding speed.
- Touching dangerous objects causes a crash and restarts the level after a short delay.
- Reaching the finish line plays a success effect and reloads the level.

## Controls

- `Left Arrow`: rotate left
- `Right Arrow`: rotate right
- `Up Arrow`: boost speed

## Core Process

The game flow is organized around a few small scripts in `Assets/Scripts`.

### 1. Player Movement

[`Assets/Scripts/PlayerController.cs`](/C:/Users/Riteshwar%20Singh/SnowBoarder/Assets/Scripts/PlayerController.cs) handles the player's movement behavior.

It does two main things:

- Applies torque to the `Rigidbody2D` so the snowboarder can rotate.
- Changes the `SurfaceEffector2D` speed so the player can switch between normal speed and boosted speed.

The script also exposes tuning values through serialized fields:

- `torqueAmount`
- `baseSpeed`
- `boostSpeed`

When the player crashes, this script disables controls so the rider cannot keep moving during the restart delay.

### 2. Crash Detection

[`Assets/Scripts/CrashDetector.cs`](/C:/Users/Riteshwar%20Singh/SnowBoarder/Assets/Scripts/CrashDetector.cs) manages failure states.

The process is:

1. Detect contact with tagged hazard objects.
2. Stop player control by calling `DisableControls()`.
3. Play crash audio and visual feedback.
4. Wait for a short delay.
5. Reload the scene.

This creates a simple restart loop that keeps the game fast and arcade-like.

### 3. Finish Line Logic

[`Assets/Scripts/FinishLine.cs`](/C:/Users/Riteshwar%20Singh/SnowBoarder/Assets/Scripts/FinishLine.cs) handles level completion.

When the player enters the finish trigger:

1. A completion particle effect is played.
2. A success sound is triggered.
3. The scene reloads after a short delay.

Right now, the game loops back into the same scene instead of loading a new level, which fits this prototype structure.

### 4. Dust Trail Effects

[`Assets/Scripts/DustTrail.cs`](/C:/Users/Riteshwar%20Singh/SnowBoarder/Assets/Scripts/DustTrail.cs) improves visual feedback.

The particle system starts when the board collides with a surface tagged `dust` and stops when the board leaves that surface. This makes movement feel more physical and responsive.

## Project Structure

Key folders in the project:

- `Assets/Scenes`: contains the playable scene
- `Assets/Scripts`: contains the gameplay scripts
- `Assets/Sprites`: art and visual assets
- `Assets/audio`: sound assets
- `Packages`: Unity package dependencies
- `ProjectSettings`: Unity project configuration

## Unity Setup

The project uses:

- Unity `6000.5.0a7`
- C# scripts attached to GameObjects
- `Rigidbody2D` for physics
- `SurfaceEffector2D` for slope movement
- `ParticleSystem` for crash, finish, and dust feedback
- `AudioSource` for sound effects

## How To Open And Run

1. Open Unity Hub.
2. Add this folder as an existing project:
   `C:\Users\Riteshwar Singh\SnowBoarder`
3. Open the project with Unity version `6000.5.0a7` or the closest compatible version.
4. Open the main gameplay scene from `Assets/Scenes`.
5. Press Play in the Unity Editor.

## Development Process Behind This Game

This project follows a straightforward beginner-friendly Unity workflow:

1. Build a 2D track scene with colliders and a finish area.
2. Add a player object with `Rigidbody2D` physics.
3. Use `SurfaceEffector2D` to move the rider along the slope.
4. Write a controller script to rotate the rider and change speed.
5. Add collision and trigger detection for crash zones and level completion.
6. Add particle effects and audio to make the feedback clearer.
7. Reload the level on failure or success to keep the loop simple.

This makes the project a good example of how small scripts can work together to create a complete gameplay cycle.

## Notes

- The repository currently contains `Assets/Scenes/level1.unity`.
- `ProjectSettings/EditorBuildSettings.asset` still references `Assets/Scenes/SampleScene.unity`, so the build settings may need to be updated inside Unity before creating a build.
- Some plugin/demo scripts are also present under `Assets/Scripts/Plugins`, but the main gameplay logic is in the four top-level scripts inside `Assets/Scripts`.

## Future Improvements

Possible next steps for the project:

- Add multiple levels instead of reloading the same scene
- Add a score or timer system
- Add checkpoints
- Improve crash and landing detection
- Add UI for restart, win state, and instructions
- Tune movement values for smoother control

## Summary

`SnowBoarder` is a clean Unity prototype focused on one simple gameplay loop: ride, balance, boost, avoid crashing, and finish the course. It is a good small project for learning Unity 2D physics, player control, collisions, triggers, particles, and audio feedback.
