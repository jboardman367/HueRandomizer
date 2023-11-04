# HueRandomizer
HueRandomizer is a mod for [Hue](https://www.huethegame.com/) that randomizes the order of all puzzle levels.

New in version 2.0.0, the randomizer begins with no colours, and can generate paths that include completing levels backward. (An option to make the randomizer behave equivalently to 1.0.0 is planned)

The seed that is used to randomize the levels can be found and changed in the settings menu (open/close with `ctrl + F10` by default).
Setting the seed to 0 will cause the game to generate a random seed.

There is also a setting to toggle whether hallway rooms are to be included.

If you get stuck, a file containing the computed solution called `randoPath.txt` is created in the same folder as `Hue.exe`.

A record of the minimum requirements for each level is kept in [this spreadsheet](https://docs.google.com/spreadsheets/d/1TzeneD9vT-d-aaSYlykEpIK6WxXXFhot4BF3BWjdtfI)

# Setup

1. Download `UnityModManager.zip` from https://www.nexusmods.com/site/mods/21/ (you can use the mirror download if you don't have a login)
1. Extract the archive (e.g. to desktop, do not copy it to the game folder.) and run `UnityModManager.exe` (recommended to run as administrator)
1. If the program does not open, try to install [Net Framework 4](https://dotnet.microsoft.com/download/dotnet-framework-runtime/), otherwise go to next
1. Select `Hue` from the game list.
1. Select the game folder based on the version of the game that you have.
1. Click the `Install` button.

Version | Folder
------------|-------------------------
Steam | `C:\Program Files (x86)\Steam\steamapps\common\Hue`
Epic | `C:\Program Files\Epic Games\Hue`

# Mod Installation
1. Download the latest version of `HueRandomizer.zip` from https://github.com/jboardman367/HueRandomizer/releases (you do not need to extract it)
1. Open `UnityModManager.exe` and change to the `Mods` tab. Drop the zip file in the designated area or use the `Install Mod` button.

# Before A Normal Speedrun
If you want to do a normal speedrun after using the HueRandomizer mod you have to make sure that the game is unmodified.
To do so close the game, then open `UnityModManager.exe` and click the `Uninstall` button (on the `Install` tab).

# Acknowledgements

Development:

- Modesius
- luminousLamp367

Contributions to constraints spreadsheet:

- luminousLamp367
- Druwu
