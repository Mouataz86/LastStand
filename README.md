# LastStand (GTA V Script Mod)

**LastStand** is a C# script mod for Grand Theft Auto V that grants players a temporary combat boost when their health drops below a critical level. It simulates a "last stand" mode with configurable armor, minigun, invincibility (optional), and a cooldown system.

This README is aimed at end users. For developer documentation or contributing, please see `README-DEV.md` if available.

---

## 📑 Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Requirements](#requirements)
- [Troubleshooting](#troubleshooting)
- [Credits](#credits)
- [License](#license)

---

## ✅ Features

- Automatically triggers when health drops below a specified threshold
- Temporary boost to:
  - Health
  - Armor
  - Optional invincibility
  - Minigun with full ammo
- Cooldown system to prevent re-triggering too soon
- Countdown timer displayed on screen
- Optional sound effect when activated
- INI-based configuration

---

## 📦 Installation

1. Make sure you have the following installed:
   - [ScriptHookV](http://www.dev-c.com/gtav/scripthookv/)
   - [ScriptHookVDotNet 3](https://github.com/crosire/scripthookvdotnet/releases)
2. Extract the following files into your `GTA V/scripts` folder:
   - `LastStand.dll`
   - `LastStand.ini`
3. Launch GTA V.

---

## 🎮 Usage

Once the mod is loaded:

- Engage in combat.
- When your health drops below the configured `TriggerHealth`, Last Stand will activate automatically.
- A timer will show on screen counting down.
- At the end of the duration, your health and armor will revert, and the cooldown will begin.

---

## ⚙️ Configuration (LastStand.ini)

All values are editable in the `scripts/LastStand.ini` file.

```ini
[General]
TriggerHealth=110         ; Health threshold to trigger Last Stand
BoostedHealth=500         ; Health during Last Stand (ignored if invincibility is enabled)
BoostedArmor=100          ; Armor given on trigger
Duration=20000            ; Duration of Last Stand in milliseconds
Cooldown=60000            ; Cooldown time before Last Stand can be used again (ms)
EnableNotifications=true  ; Show notifications
GiveMinigun=true          ; Give player a minigun during Last Stand
