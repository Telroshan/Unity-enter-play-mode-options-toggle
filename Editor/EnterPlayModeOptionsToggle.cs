using UnityEditor;

namespace EnterPlayModeOptionsToggle.Editor
{
    public static class EnterPlayModeOptionsToggle
    {
        [MenuItem("Fast Enter Play Mode/Enable", priority = 0)]
        public static void Enable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = true;
        }

        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Enable")]
        public static bool EnableValidation()
        {
            return !EditorSettings.enterPlayModeOptionsEnabled;
        }

        [MenuItem("Fast Enter Play Mode/Disable", priority = 1)]
        public static void Disable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = false;
        }

        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Disable")]
        public static bool DisableValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled;
        }

        
        [MenuItem("Fast Enter Play Mode/Enable domain reload", priority = 20)]
        public static void EnableDomainReload()
        {
            EditorSettings.enterPlayModeOptions &= ~EnterPlayModeOptions.DisableDomainReload;
        }

        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Enable domain reload")]
        public static bool EnableDomainReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableDomainReload) ==
                   EnterPlayModeOptions.DisableDomainReload;
        }
        [MenuItem("Fast Enter Play Mode/Disable domain reload", priority = 21)]
        public static void DisableDomainReload()
        {
            EditorSettings.enterPlayModeOptions |= EnterPlayModeOptions.DisableDomainReload;
        }
        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Disable domain reload")]
        public static bool DisableDomainReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableDomainReload) !=
                   EnterPlayModeOptions.DisableDomainReload;
        }
        

        [MenuItem("Fast Enter Play Mode/Enable scene reload", priority = 40)]
        public static void EnableSceneReload()
        {
            EditorSettings.enterPlayModeOptions &= ~EnterPlayModeOptions.DisableSceneReload;
        }

        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Enable scene reload")]
        public static bool EnableSceneReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableSceneReload) ==
                   EnterPlayModeOptions.DisableSceneReload;
        }
        [MenuItem("Fast Enter Play Mode/Disable scene reload", priority = 41)]
        public static void DisableSceneReload()
        {
            EditorSettings.enterPlayModeOptions |= EnterPlayModeOptions.DisableSceneReload;
        }
        [MenuItem("", true, menuItem = "Fast Enter Play Mode/Disable scene reload")]
        public static bool DisableSceneReloadValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled &&
                   (EditorSettings.enterPlayModeOptions & EnterPlayModeOptions.DisableSceneReload) !=
                   EnterPlayModeOptions.DisableSceneReload;
        }
    }
}