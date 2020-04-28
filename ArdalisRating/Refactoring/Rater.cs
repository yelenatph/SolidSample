using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public abstract class Rater
    {
        public ILogger Logger { get; set; } = new ConsoleLogger();
        protected readonly IRatingUpdater _ratingUpdater;

        public Rater(IRatingUpdater ratingUpdater)
        {
            _ratingUpdater = ratingUpdater;
        }

        public abstract void Rate(Policy policy);
    }
}
