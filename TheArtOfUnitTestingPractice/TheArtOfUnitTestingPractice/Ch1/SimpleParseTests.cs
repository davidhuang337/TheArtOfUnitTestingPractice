using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfUnitTestingPractice.Ch1
{
    class SimpleParseTests
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
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
            try
            {
                var simpleParser = new SimpleParser();
                var result = simpleParser.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    Console.WriteLine(
                        @"***SimpleParsweTests.TestReturnZeroWhenEmptyString:
                         -----
                        Parse and sum should have returned 0 on an empty ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
