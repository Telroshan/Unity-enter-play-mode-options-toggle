using UnityEditor;

namespace TelroshanTools.EnterPlayModeOptionsToggle.Editor
{
    public static class EnterPlayModeOptionsToggle
    {
        private const string MenuName = "Enter Play Mode Options";

        [MenuItem(MenuName + "/Enable", priority = 0)]
        public static void Enable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = true;
        }

        [MenuItem("", true, menuItem = MenuName + "/Enable")]
        public static bool EnableValidation()
        {
            return !EditorSettings.enterPlayModeOptionsEnabled;
        }

        [MenuItem(MenuName + "/Disable", priority = 1)]
        public static void Disable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = false;
        }

        [MenuItem("", true, menuItem = MenuName + "/Disable")]
        public static bool DisableValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled;
        }


        [MenuItem(MenuName + "/Enable domain reload", priority = 20)]
        public static void EnableDomainReload()
        {
            EditorSettings.enterPlayModeOptions &= ~EnterPlayModeOptions.DisableDomainReload;
        }

        [MenuItem("", true, menuItem = MenuName + "/Enable domain reload")]
        public static bool EnableDomainReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableDomainReload) ==
                   EnterPlayModeOptions.DisableDomainReload;
        }

        [MenuItem(MenuName + "/Disable domain reload", priority = 21)]
        public static void DisableDomainReload()
        {
            EditorSettings.enterPlayModeOptions |= EnterPlayModeOptions.DisableDomainReload;
        }

        [MenuItem("", true, menuItem = MenuName + "/Disable domain reload")]
        public static bool DisableDomainReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableDomainReload) !=
                   EnterPlayModeOptions.DisableDomainReload;
        }


        [MenuItem(MenuName + "/Enable scene reload", priority = 40)]
        public static void EnableSceneReload()
        {
            EditorSettings.enterPlayModeOptions &= ~EnterPlayModeOptions.DisableSceneReload;
        }

        [MenuItem("", true, menuItem = MenuName + "/Enable scene reload")]
        public static bool EnableSceneReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableSceneReload) ==
                   EnterPlayModeOptions.DisableSceneReload;
        }

        [MenuItem(MenuName + "/Disable scene reload", priority = 41)]
        public static void DisableSceneReload()
        {
            EditorSettings.enterPlayModeOptions |= EnterPlayModeOptions.DisableSceneReload;
        }

        [MenuItem("", true, menuItem = MenuName + "/Disable scene reload")]
        public static bool DisableSceneReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableSceneReload) !=
                   EnterPlayModeOptions.DisableSceneReload;
        }
    }
}