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

            Window window = UIToolsBuilder.CreateClosableWindow(uiHolder.transform, windowID, 300, 180, -1280, 720, true, true, 0.85f, "ExampleMod", false);
            window.CreateLayoutGroup(Type.Vertical);

            Container windowContainer = Builder.CreateContainer(window);

            Builder.CreateButton(window, 230, 50, 0, 0, () => DoSomething(), "ExampleMod");
        }

        private static void DoSomething() { }
    }
}
