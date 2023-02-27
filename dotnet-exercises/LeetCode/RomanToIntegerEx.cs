using System;

/*
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
Given a roman numeral, convert it to an integer.
*/
namespace dotnet_exercises.LeetCode
{
	public class RomanToIntegerEx
	{
        public int RomanToInt(string s)
        {
            Dictionary<string, int> RomanValues = new()
            {
                {"I", 1},
                {"V", 5 },
                {"X", 10},
                {"L", 50},
                {"C", 100 },
                {"D", 500 },
                {"M", 1000 }
            };

            int value = 0;
            for (int i = 0; i < s.Length; i++)
            {

                //last element is always added
                if (i == s.Length - 1)
                {
                    value += RomanValues[s[i].ToString()];
                    break;
                }

                var val = RomanValues[s[i].ToString()];
                var nextVal = RomanValues[s[i + 1].ToString()];

                if (val >= nextVal)
                {
                    value += val;
                    continue;
                }

                value -= val;
            }
            return value;
        }
    }
}

