﻿using ArdalisRating.Refactoring;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }

        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

        public FilePolicySource FilePolicySource { get; set; } = new FilePolicySource();

        public PolicySerializer PolicySerializer { get; set; } = new PolicySerializer();

        public void Rate()
        {
            Logger.Log("Starting rate.");
            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = FilePolicySource.GetPolicyFromSource();

            var policy = PolicySerializer.GetPolicyFromJsonString(policyJson);

            var factory = new RaterFactory();
            var rater = factory.Create(policy, this);
            rater?.Rate(policy);

            Logger.Log("Rating completed.");
        }
    }
}
