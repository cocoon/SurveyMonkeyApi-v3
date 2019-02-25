namespace SurveyMonkey.RequestSettings
{
    public class GetContactsListsSettings : IPagingSettings
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
    }
}