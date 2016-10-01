﻿namespace SurveyMonkey.RequestSettings
{
    public class GetSurveyCategoryListSettings : IPagingSettings
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public string Language { get; set; } //TODO ideally would use an enum if they'll share a list
    }
}