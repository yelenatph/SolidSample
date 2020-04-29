using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Unknown policy type");
            return 0m;
        }
    }
}
