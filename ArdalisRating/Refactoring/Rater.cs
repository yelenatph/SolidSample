using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public abstract class Rater
    {
        protected readonly ConsoleLogger _logger;
        protected readonly IRatingContext _context;

        public Rater(IRatingContext context)
        {
            _logger = context.Logger;
            _context = context;
        }

        public abstract void Rate(Policy policy);
    }
}
