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
            };

        public string Convert(int input)
        {
            if (!dictionary.ContainsKey(input))
            {
                return string.Empty;
            }

            return dictionary[input];
        }
    }
}