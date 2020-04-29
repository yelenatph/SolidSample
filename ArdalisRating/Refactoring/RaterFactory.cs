using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class RaterFactory : IRaterFactory
    {
        private readonly ILogger _logger;

        public RaterFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Rater Create(Policy policy)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.Refactoring.{policy.Type}PolicyRater"),
                    new object[] { _logger });
            }
            catch
            {
                return new UnknownPolicyRater(_logger);
            }
        }
    }
}
