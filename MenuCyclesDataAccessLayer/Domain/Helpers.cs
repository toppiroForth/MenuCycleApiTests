using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain
{
    public class Helpers
    {       
        private static Random _random = new Random(DateTime.Now.Millisecond);
        private static readonly Random random = new Random();

        public string RandomString(int size)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(
                    Math.Floor(26 * _random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

      
        public static double RandomNumberBetween(double minValue, double maxValue)
        {

            var next = random.NextDouble();
            return minValue + (next * (maxValue - minValue));

        }

        public static int RandomNumberBetween(int minValue, int maxValue)
        {
            var next = random.Next();
            return minValue + (next * (maxValue - minValue));

        }


    }
}
