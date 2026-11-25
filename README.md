# Casual Runner Game

A hyper-casual 3D runner built with Unity for PC and Android. A ball runs forward automatically while you steer it left and right through gates. Green gates add points, red gates take them away, so every choice counts.

## Gameplay Video

https://github.com/user-attachments/assets/09364b6d-7cb8-47fd-abaf-4da86ec1e8cb

## Game Overview

The player ball moves forward on its own along a long track. Pairs of gates with random values appear in front of it: positive gates are green, negative gates are red. Steer through the gates you want to collect as much score as possible and reach the finish wall at the end of the track.

## Features

- **Auto-running player** – The ball moves forward constantly, you only steer
- **Two control schemes** – Keyboard on PC, device tilt on Android
- **Random gates** – Each gate gets a random score between 5 and 15 and randomly becomes positive or negative
- **Color-coded gates** – Green for positive values, red for negative, with the value shown on the gate
- **Score system** – Live score shown above the player, kept when the scene reloads
- **Finish wall** – Reaching the end reloads the level
- **Prefab-based gates** – Reusable left and right gate prefabs spawned from code
- **Android build** – Playable on phones and tablets as an `.apk`

## Controls

| Platform | Input              | Action          |
|----------|--------------------|-----------------|
| PC       | A                  | Steer left      |
| PC       | D                  | Steer right     |
| Android  | Tilt the device    | Steer left/right |

### Build for Android

1. In Unity Hub, add the **OpenJDK** and **Android SDK & NDK Tools** modules to your editor version.
2. Go to **File → Build Settings**, select **Android** and click **Switch Platform**.
3. In **Player Settings**, set a Company Name and Product Name, and allow only landscape orientations.
4. Click **Build** and save the `.apk`.
5. Copy the `.apk` to your device and install it (you may need to allow installing apps from unknown sources).

## Author

**Aleksandra Balažević**

---

Engine: Unity · Language: C# · Genre: Hyper-casual Runner · Platforms: PC, Android
