using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.Refactoring.{policy.Type}PolicyRater"),
                    new object[] { engine.Logger, engine });
            }
            catch
            {
                return null;
            }
        }
    }
}
