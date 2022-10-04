using System.ComponentModel;

namespace Core.Enums
{
    public enum CachingPriority
    {
        [Description("High")]
        High = 1,
        [Description("Low")]
        Low = 2,
        [Description("Normal")]
        Normal = 3,
        [Description("Nerver Remove")]
        NeverRemove = 4
    }
}
