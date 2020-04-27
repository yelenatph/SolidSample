using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine.Logger, engine);

                case PolicyType.Land:
                    return new LandPolicyRater(engine.Logger, engine);

                case PolicyType.Life:
                    return new LifePolicyRater(engine.Logger, engine);

                default:
                    return new UnknownPolicyRater(engine.Logger, engine);
            }
        }
    }
}
