using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals {
    public class RomanNumeralConvertor {
        private IDictionary<int, string> dict;

        public RomanNumeralConvertor() {
            dict = new Dictionary<int, string> {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };
        }

        public string ConvertNumberToRomanNumeral(int number) {
            StringBuilder romanNumeral = new StringBuilder();

            var n = number;

            while (n > 0) {
                foreach (var item in dict) {
                    if (n >= item.Key) {
                        romanNumeral.Append(item.Value);
                        n -= item.Key;
                        break;
                    }
                }
            }

            return romanNumeral.ToString();
        }

        public int ConvertRomanNumeralToNumber(string romanNumeral) {
            var romanNumerals = romanNumeral.Select(s => s.ToString()).ToArray();
            var number = 0;

            for (var i = 0; i < romanNumerals.Length; i++) {
                foreach (var item in dict) {
                    if (i < romanNumerals.Length - 1 && romanNumerals[i] + romanNumerals[i + 1] == item.Value) {
                        number += item.Key;
                        i++;
                    }
                    else if (romanNumerals[i] == item.Value) {
                        number += item.Key;
                    }
                }
            }

            return number;
        }
    }
}