namespace Core.Settings
{
    public class PasswordAndSecuritySettings
    {
        // Password minimum length
        public int PasswordMinimumLength { get; set; }

        // Password must have at least one lowercase
        public bool RequireAtLeastOneLowercase { get; set; }

        // Password must have at least one uppsercase
        public bool RequireAtLeastOneUppercase { get; set; }

        // password must have at least one non alphanumeric character like symbols
        public bool RequireAtLeastOneNonAlphanumeric { get; set; }

        // password must have at least one digit
        public bool RequireAtLeastOneDigit { get; set; }

        // maximum login failure
        public int MaximumLoginFailure { get; set; }

        // Lock time in Seconds
        public int LockTimeSeconds { get; set; }

        // Password format type
        public int PasswordFormatType { get; set; }
    }
}
