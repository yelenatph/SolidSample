﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
