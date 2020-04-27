using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(ConsoleLogger logger, RatingEngine engine) : base(logger, engine)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}
