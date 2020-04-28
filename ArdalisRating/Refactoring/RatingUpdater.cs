﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class RatingUpdater : IRatingUpdater
    {
        private readonly RatingEngine _engine;

        public RatingUpdater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void UpdateRating(decimal rating)
        {
            _engine.Rating = rating;
        }
    }
}
