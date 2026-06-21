# MOPMAN

An asymmetric two-player cooperative VR game built with Unity and Ubiq for the Immersive Technologies course (A.Y. 2025–2026).

## Group Members

| Member | Role | Main Contributions |
| --- | --- | --- |
| Bergström Ella | Developer | Project Setup, Coins |
| Colosimo Davide | Developer | Second Floor, Communication, Player Motion |
| Facchinelli Davide | Project Manager | Project Setup, General Polishment, Sounds & Music |
| Filippo Marcon | Developer | Keys, Graphics & Models |
| Nejati Zadeh Daryaei Sam | Developer | Mop, End Game |
| Stevan Pietro | Developer | Monsters, GUI |

## Description

Cooperative asymmetric VR games usually assume fixed player roles and a stable communication channel, while locomotion in confined spaces is limited by physical boundaries and Visually Induced Motion Sickness (VIMS). MOPMAN challenges these assumptions.

One player is the **executive**, navigating a maze haunted by an autonomous monster to collect the three keys needed to escape. The other is the **coordinator**, overseeing the maze from above through a glass floor and guiding the teammate. Asymmetry becomes a resource-dependent loop: the glass floor progressively gets dirty and must be cleaned with a mop to preserve the coordinator's "god-view". Collaboration is further stressed by two communication-degradation mechanics: 2D proximity-based spatialized voice that ignores vertical distance, and a monster that jams the channel until signal loss, while hardware-agnostic arm-swinging locomotion raises physical exertion to complement the horror theme.

## Requirements

- **Unity** 6000.3.11f1 TODO: (is this correct?)
- **Ubiq** (`com.ucl.ubiq`, UPM package)
TODO: [anything else maybe?]
- An OpenXR-compatible VR headset (e.g. Meta Quest). The desktop/editor path is supported for testing.

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/evemp01/Immersive-Technologies-Project.git
   ```
2. Open the project in Unity **6000.3.11f1** via Unity Hub. Required packages are restored automatically from `Packages/manifest.json`.
3. Open the main scene: `Assets/MopMan/Scenes/Maze.unity`.

## Usage

1. Start a Ubiq room (the players must join the same room to play together).
2. Both players spawn in the lobby. The teleport pads appear only once both players are in the room; each pad assigns a role:
   - **Executive** → teleported inside the maze.
   - **Coordinator** → teleported above the maze, looking down through the glass floor.
3. **Executive:** move with arm-swinging locomotion, avoid the monster, collect the three keys, and reach the exit door.
4. **Coordinator:** guide the executive over voice, buy mop upgrades, and keep the glass floor clean with the mop so you can keep seeing the maze.
5. **End game:**
   - **Win** → both players return to the lobby with all keys collected.
   - **Lose** → the executive loses all three lives to the monster; both players are sent back to the lobby.
   - A "Play Again" sign then lets either player restart the match for both.

## Build (APK)

Build for Android (Meta Quest) via **File → Build Settings → Android → Build**.
