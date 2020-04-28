using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(IRatingContext context) : base(context)
        {
        }

        public override void Rate(Policy policy)
        {
            Logger.Log("Unknown policy type");
        }
    }
}
