using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerTest.Utils
{
    public static class Generators
    {
        public static string GenerateRandomEmail()
        {
            var random = new Random();
            var uniqueId = random.Next();
            return $"testuser_{uniqueId}@example.com";
        }
    }
}
