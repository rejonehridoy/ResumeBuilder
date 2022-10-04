namespace Core.Settings
{
    public class UserSettings
    {
        public bool RequiredUserEmailValidation { get; set; }
        public bool NotifyOfNewCustomerRegistration { get; set; }
        public string DefaultStoreTimezone { get; set; }
        public int ShowNumberOfResultsPerPage { get; set; }
    }
}
