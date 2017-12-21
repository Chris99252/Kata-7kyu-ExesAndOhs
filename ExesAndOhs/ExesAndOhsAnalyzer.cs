using System;

namespace ExesAndOhs
{
    public class ExesAndOhsAnalyzer
    {
        public bool VaildStringHasSameAmountXandO(string text)
        {
            bool result = false;

            if (string.IsNullOrEmpty(text))
            {
                result = true;
            }

            var textLength = text.Length;

            var oAmount = 0;

            var xAmount = 0;

            for (int i = 0; i < textLength; i++)
            {
                var singleChar = text.Substring(i, 1);

                if (singleChar.EndsWith("O", StringComparison.CurrentCultureIgnoreCase))
                {
                    oAmount++;
                }

                if (singleChar.EndsWith("X", StringComparison.CurrentCultureIgnoreCase))
                {
                    xAmount++;
                }
            }

            if (oAmount == xAmount)
            {
                result = true;
            }

            return result;

            ////  Best Practices
            ////  return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }
    }
}