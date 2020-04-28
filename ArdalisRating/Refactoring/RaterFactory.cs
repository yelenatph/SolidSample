using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, IRatingContext context)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.Refactoring.{policy.Type}PolicyRater"),
                    new object[] { context });
            }
            catch
            {
                return new UnknownPolicyRater(context);
            }
        }
    }
}
