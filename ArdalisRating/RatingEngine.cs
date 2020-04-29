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
        private readonly ILogger _logger;
        private readonly IFilePolicySource _policySource;

        private readonly IPolicySerializer _policySerializer;
        private readonly RaterFactory _raterFactory;

        public decimal Rating { get; set; }

        public RatingEngine(
            ILogger logger, 
            IFilePolicySource policySource, 
            IPolicySerializer policySerializer,
            RaterFactory raterFactory)
        {
            _logger = logger;
            _policySource = policySource;
            _policySerializer = policySerializer;
            _raterFactory = raterFactory;
        }

        public void Rate()
        {
            _logger.Log("Starting rate.");
            _logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyString = _policySource.GetPolicyFromSource();

            var policy = _policySerializer.GetPolicyFromJsonString(policyString);

            var rater = _raterFactory.Create(policy);

            Rating = rater.Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}
