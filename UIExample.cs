using SFS.UI.ModGUI;
using UITools;
using UnityEngine;

namespace SFS_ExampleMod
{
    public class UIExample
    {
        static GameObject uiHolder;
        static readonly int windowID = Builder.GetRandomID();

        public static void LoadUI()
        {
            uiHolder = Builder.CreateHolder(Builder.SceneToAttach.CurrentScene, "ExampleMod GUI Container");

            // disabled default position saving for UITools permanent saving compatibility
            Window window = UIToolsBuilder.CreateClosableWindow(uiHolder.transform, windowID, 300, 180, -1280, 720, true, false, 0.85f, "ExampleMod", false);
            window.RegisterPermanentSaving("examplemod.ExampleModWindow");
            window.CreateLayoutGroup(Type.Vertical);

            Container windowContainer = Builder.CreateContainer(window);

            Builder.CreateButton(window, 230, 50, 0, 0, () => DoSomething(), "ExampleMod");
        }

        private static void DoSomething() { }
    }
}
