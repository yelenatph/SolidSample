using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArdalisRating.Refactoring
{
    public class FilePolicySource : IFilePolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
