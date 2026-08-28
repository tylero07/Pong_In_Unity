# Pong

A two-player Pong game created in Unity for Assignment 1 in CS 3383 at the University of Idaho.

## Acknowledgments

- Special thanks to [Erkberg on YouTube](https://youtu.be/DnBTmYXThOY?si=zjpdK3Lzv7-ze1NP) for the tutorial used as a reference.
- This project was created for CS 3383 at the University of Idaho, taught by [Dr. Joules Beeston](https://www.uidaho.edu/people/jbeeston).

## Unity Version

This game was developed on Windows using Unity **[ADD EXACT UNITY VERSION]**.

The version can be found in `ProjectSettings/ProjectVersion.txt`. Teammates should use the same version to avoid an automatic project upgrade and unnecessary file changes.

## Play the Game

No Unity or Git installation is required to play a prebuilt version.

1. Open this repository's **Releases** page from the link on the right side of GitHub.
2. Open the newest release and, under **Assets**, download the ZIP file for your operating system and device architecture.
3. Right-click the downloaded ZIP file and select **Extract All**. Keep all extracted files together in the same folder.
4. Open the extracted folder and double-click the game executable. On Windows, this is the `.exe` file.
5. Press **Start** to begin.

If Windows displays a security warning, confirm that the file came from this repository before choosing **More info > Run anyway**. If no compatible release is available, follow the development instructions below and run the game in Unity.

## Controls

Prevent the ball from passing your paddle. The first player to score **3 points** wins.

| Player | Paddle | Move up | Move down |
| --- | --- | --- | --- |
| Player 1 | Left | `W` | `S` |
| Player 2 | Right | `Up Arrow` | `Down Arrow` |

- `H` - Pause the game and display instructions
- `Esc` - Exit the game immediately

## Join the Development Team

### 1. Install the Required Software

1. Download and install [GitHub Desktop](https://desktop.github.com/download/). It provides a visual interface, so no Git command-line experience is required.
2. Download and install [Unity Hub](https://unity.com/download).
3. In Unity Hub, open **Installs**, select **Install Editor**, and install the Unity version listed above. If it is unavailable, ask the team before opening the project with a newer version.
4. Add the Windows Build Support module, plus build support for any other platform you intend to target.

> Unity's download links and installation screens may change over time.

<img width="2472" height="1378" alt="Unity Hub editor installation screen" src="https://github.com/user-attachments/assets/4a11d555-3f99-425d-8b40-8c602acaa1a2" />

### 2. Download the Source Code

1. On this repository's GitHub page, select **Code > Open with GitHub Desktop**.
2. In GitHub Desktop, choose where the project should be stored and select **Clone**.
3. To get later team changes, open the project in GitHub Desktop and select **Fetch origin**, followed by **Pull origin** when that option appears.

For a one-time copy that will not receive team updates, select **Code > Download ZIP** on GitHub and extract the ZIP file instead.

### 3. Open and Test the Project

1. In Unity Hub, select **Add > Add project from disk**.
2. Choose the cloned project folder containing the `Assets`, `Packages`, and `ProjectSettings` folders.
3. Open the project with the required Unity version and wait for the first import to finish.
4. Open the main game scene `Pong` from the `Assets` folder if it is not already open.
6. Select the **Play** button at the top of the Unity editor to test the game. Select it again to stop testing before editing files.

### 4. Build the Game

1. In Unity, select **File > Build Profiles**.
2. Select or add the target platform. If Unity requests a missing module, install it through Unity Hub and reopen the project.
3. Confirm that the game's scenes are included in the build profile.
4. Select **Build**, create or choose an empty output folder, and wait for Unity to finish.
5. Test the resulting executable before sharing it. Distribute the entire output folder as a ZIP because the executable depends on the other generated files.

<img width="3162" height="1164" alt="Unity Build Profiles window" src="https://github.com/user-attachments/assets/cf32fd31-d502-4282-9b58-25b91ee09112" />

## Gameplay Preview

<!-- Add gameplay screenshots, a GIF, or a video link here. -->
