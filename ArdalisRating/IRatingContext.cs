﻿using ArdalisRating.Refactoring;

namespace ArdalisRating
{

    public interface IRatingContext : ILogger
    {
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);
        Policy GetPolicyFromJsonString(string policyJson);
        Policy GetPolicyFromXmlString(string policyXml);
        Rater CreateRaterForPolicy(Policy policy);
        RatingEngine Engine { get; set; }
    }
}
