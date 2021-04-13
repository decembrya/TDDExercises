using System.Collections.Generic;
using System.Text;

namespace TddExercises
{
    //Challenge: +
    //a functionality that converts arabic numbers to roman numerals
    //input will be int 
    //output will be string
    //examples:
    //1-> I
    //11-> XI
    public class RomanNumeralsConverter
    {
        private readonly Dictionary<int, string> dictionary =
            new Dictionary<int, string>
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
            };

        public string Convert(int input)
        {
            if (!dictionary.ContainsKey(input))
            {
                return string.Empty;
            }

            var response  = new StringBuilder();

            while(input > 0)
            {
                if(input >= 5)
                {
                    response.Append("V");
                    input -= 5;
                }
                else if (input == 4)
                {
                    response.Append("IV");
                    input -= 4;
                }
                else if(input < 4)
                {
                    response.Append("I");
                    input -= 1;
                }
            }

            return response.ToString();
        }
    }
}