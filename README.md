## Setup
*This setup guide assumes you're on Windows.*
*This mod has been tested to work on game version 1.5.10.2.*

- Create a new Class Library project in VS2019 (though this should also work in VS2022) targeting .NET Framework 4.8.  
- Add references to the following DLLs from the game's Managed folder, which is by default
  C:\Program Files (x86)\Steam\steamapps\common\Spaceflight Simulator\Spaceflight Simulator Game\Spaceflight Simulator_Data\Managed  
  - Assembly-CSharp.dll  
  - UnityEngine.dll  
  - UnityEngine.CoreModule.dll  
  - UnityEngine.TextRenderingModule.dll  
  - UnityEngine.UI.dll  
- Also add UITools.dll from the game’s Mods\UITools folder, by default C:\Program Files (x86)\Steam\steamapps\common\Spaceflight Simulator\Spaceflight Simulator Game\Mods\UITools .  

Build, then place your mod DLL in the game's Mods folder, by default C:\Program Files (x86)\Steam\steamapps\common\Spaceflight Simulator\Spaceflight Simulator Game\Mods .  
