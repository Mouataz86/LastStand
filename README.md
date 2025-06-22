<h1 align="center">LastStand - GTA V Mod</h1>

<p align="center">
  <img src="https://img.shields.io/badge/version-v1.0.0-blue" alt="Version">
  <img src="https://img.shields.io/badge/platform-PC-brightgreen" alt="Platform">
  <img src="https://img.shields.io/badge/license-MIT-lightgrey" alt="License">
</p>

<p align="center">
  <i>Never say die.</i>
</p>

**LastStand** is a C# script mod for Grand Theft Auto V that gives you a fighting chance when you're on the brink of death. When your health drops to a critical level, this mod automatically triggers a "last stand" mode, giving you a temporary but powerful combat boost to turn the tide.

---

## 📑 Table of Contents

- [Features](#-features)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [Usage](#-usage)
- [Configuration](#-configuration)
- [Contributing](#-contributing)
- [Credits](#-credits)
- [License](#-license)

---

## ✅ Features

- **Automatic Activation**: Triggers a combat boost when player health falls below a configurable threshold.
- **Temporary Invincibility**: Become invincible for a short duration to survive fatal encounters.
- **Full Armor**: Instantly gain a full armor bar.
- **Minigun Mayhem**: A minigun with maximum ammo is automatically equipped.
- **Heads-Up Display**: On-screen timer shows the remaining duration of the Last Stand.
- **Cooldown System**: Prevents the ability from being abused by enforcing a cooldown period.
- **Customizable**: Fine-tune all aspects of the mod through a simple `.ini` configuration file.
- **Audio Cue**: Optional sound effect on activation.

---

## 🔧 Requirements

Before installing, ensure you have the following prerequisites installed:

- [**ScriptHookV**](http://www.dev-c.com/gtav/scripthookv/)
- [**ScriptHookVDotNet 3**](https://github.com/crosire/scripthookvdotnet/releases)

---

## 📦 Installation

1.  **Download** the latest release from the [releases page](https://github.com/your-username/LastStand/releases).
2.  **Extract** the archive.
3.  **Copy** `LastStand.dll` and `LastStand.ini` into your `Grand Theft Auto V/scripts/` directory. If the `scripts` folder doesn't exist, create it.
4.  **Launch** Grand Theft Auto V. The mod will load automatically.

---

## 🎮 Usage

Using the mod is straightforward:

1.  Play the game as usual.
2.  When your health drops below the `TriggerHealth` value defined in `LastStand.ini`, the mod will activate.
3.  A timer will appear, indicating the remaining duration of the Last Stand.
4.  Once the timer expires, your stats will return to normal, and the cooldown period will begin.

---

## ⚙️ Configuration

All settings can be adjusted in the `LastStand.ini` file located in your `scripts` folder.

```ini
[General]
; Health threshold to trigger Last Stand.
TriggerHealth=110

; Health value during Last Stand. (Note: Ignored if Invincible is true)
BoostedHealth=500

; Armor amount granted on activation.
BoostedArmor=100

; Duration of Last Stand in milliseconds (e.g., 20000 = 20 seconds).
Duration=20000

; Cooldown time in milliseconds before Last Stand can be used again (e.g., 60000 = 1 minute).
Cooldown=60000

; If true, you will be invincible during Last Stand.
Invincible=true

; If true, a minigun with full ammo is granted.
GiveMinigun=true

; If true, a sound effect will play upon activation.
PlaySound=true

; If true, notifications will be displayed.
EnableNotifications=true
```

---

## 🤝 Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/your-feature-name`).
3.  Make your changes.
4.  Commit your changes (`git commit -m 'Add some feature'`).
5.  Push to the branch (`git push origin feature/your-feature-name`).
6.  Open a Pull Request.

Please see `README-DEV.md` for developer-specific information.

---

## ✨ Credits

- **You**: For using this mod.
- **Rockstar Games**: For creating Grand Theft Auto V.
- **ScriptHookV & ScriptHookVDotNet authors**: For their essential scripting tools.

---

## 📜 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details. 
