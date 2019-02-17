using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfUnitTestingPractice.Ch1
{
    class SimpleParseTests
    {
        public static void Main(string[] args)
        {           
            try
            {
                TestReturnZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }

            Console.ReadKey();
        }

        public static void TestReturnZeroWhenEmptyString()
        {
            var testName = MethodBase.GetCurrentMethod().Name;

            try
            {
                var simpleParser = new SimpleParser();
                var result = simpleParser.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    var msg = "Parse and sum should have returned 0 on an empty";
                    TestUtil.ShowProblem(testName, msg);
                }
                else
                {
                    TestUtil.ShowProblem(testName, "test success!");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}
