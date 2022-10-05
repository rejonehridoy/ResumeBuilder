using System.ComponentModel;

namespace Core.Enums
{
    public enum PasswordFormatType
    {
        [Description("Plain Text First")]
        PlainTextFirst = 1,
        [Description("Hashing First")]
        HashFirst = 2
    }
}
