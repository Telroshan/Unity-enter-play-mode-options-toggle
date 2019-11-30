using UnityEditor;

namespace FastEnterPlayModeToggle.Editor
{
    public static class FastEnterPlayModeToggle
    {
        [MenuItem("Fast Enter Play Mode/Enable")]
        public static void Enable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = true;
        }
        [MenuItem("Enabled", true, menuItem = "Fast Enter Play Mode/Enable")]
        public static bool EnableValidation()
        {
            return !EditorSettings.enterPlayModeOptionsEnabled;
        }
        
        [MenuItem("Fast Enter Play Mode/Disable")]
        public static void Disable()
        {
            EditorSettings.enterPlayModeOptionsEnabled = false;
        }
        [MenuItem("Disabled", true, menuItem = "Fast Enter Play Mode/Disable")]
        public static bool DisableValidation()
        {
            return EditorSettings.enterPlayModeOptionsEnabled;
        }
    }
}
