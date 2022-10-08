namespace Core.Settings
{
    public class CommonSettings
    {
        // Tabs
        public bool OpenAccountSettingsTab { get; set; }
        public bool OpenCachingSettingsTab { get; set; }
        public bool OpenPasswordSecuritySettingsTab { get; set; }
        public bool OpenUserSettingsTab { get; set; }

        // False = Light theme, True = Dark Theme
        public bool DarkTheme { get; set; }
    }
}
