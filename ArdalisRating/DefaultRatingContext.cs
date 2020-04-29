using ArdalisRating.Refactoring;
using System;

namespace ArdalisRating
{
    public class DefaultRatingContext : IRatingContext
    {
        private readonly IFilePolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;
        private readonly IRaterFactory _raterFactory;

        public RatingEngine Engine { get; set; }

        public DefaultRatingContext(IFilePolicySource policySource, IPolicySerializer policySerializer, IRaterFactory raterFactory)
        {
            _policySource = policySource;
            _policySerializer = policySerializer;
            _raterFactory = raterFactory;
        }

        public Rater CreateRaterForPolicy(Policy policy)
        {
            return _raterFactory.Create(policy);
        }

        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return _policySerializer.GetPolicyFromJsonString(policyJson);
        }

        public Policy GetPolicyFromXmlString(string policyXml)
        {
            throw new NotImplementedException();
        }

        public string LoadPolicyFromFile()
        {
            return _policySource.GetPolicyFromSource();
        }

        public string LoadPolicyFromURI(string uri)
        {
            throw new NotImplementedException();
        }

        public void Log(string message)
        {
            new ConsoleLogger().Log(message);
        }
    }
}
