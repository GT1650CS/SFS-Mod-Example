using ModLoader;
using ModLoader.Helpers;

using System.Collections.Generic;

namespace SFS_ExampleMod
{
    public class Main : Mod
    {
        public override string ModNameID => "examplemod";
        public override string DisplayName => "ExampleMod";
        public override string Author => "Your name";
        public override string MinimumGameVersionNecessary => "1.5.10.2";
        public override string ModVersion => "1.0.0";
        public override string Description => "Example SFS Mod with a simple example UI. Uses UITools.";

        public override Dictionary<string, string> Dependencies { get; } = new Dictionary<string, string> { { "UITools", "1.1.6" } };

        public override void Early_Load()
        {
            base.Early_Load();
        }

        public override void Load()
        {
            SceneHelper.OnWorldSceneLoaded += UIExample.LoadUI;
        }
    }
}
