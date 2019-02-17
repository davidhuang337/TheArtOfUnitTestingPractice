using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfUnitTestingPractice.Ch1
{
    class TestUtil
    {
        public static void ShowProblem(string test, string message)
        {
            string msg = $"---{test}---    {message}";
            Console.WriteLine(msg);
        }
    }
}
