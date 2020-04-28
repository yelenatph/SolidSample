using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public abstract class Rater
    {
        public ILogger Logger { get; set; } = new ConsoleLogger();
        protected readonly IRatingContext _context;

        public Rater(IRatingContext context)
        {
            _context = context;
        }

        public abstract void Rate(Policy policy);
    }
}
