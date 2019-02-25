using SurveyMonkey.Enums;

namespace SurveyMonkey.RequestSettings
{
    public class GetContactsSettings : IPagingSettings
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public ContactStatus? Status { get; set; }

        public enum SortOrderOption
        {
            ASC,
            DESC
        }

        public enum SortByOption
        {
            Id,
            Email,
            FirstName,
            LastName
        }

        public enum SearchByOption
        {
            Id,
            Email,
            FirstName,
            LastName
        }

        public SortOrderOption? SortOrder { get; set; }
        public SortByOption? SortBy { get; set; }
        public SearchByOption? SearchBy { get; set; }
        public string Search { get; set; }
    }
}