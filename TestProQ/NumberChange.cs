namespace TestProQ
{
    public class NumberChange
    {
        public static List<string> ReplaceNumbers(List<int> numbers)
        {
            List<string> replacedNumbers = new List<string>();

            foreach (int number in numbers)
            {
                string replacedNumber = "";

                if (number % 3 == 0 && number % 5 == 0)
                {
                    replacedNumber += "good-boy";
                }

                if (number % 3 == 0 && number % 5 != 0)
                {
                    if (!string.IsNullOrEmpty(replacedNumber))
                        replacedNumber += "-";
                    replacedNumber += "dog";
                }

                if (number % 5 == 0 && number % 3 != 0)
                {
                    if (!string.IsNullOrEmpty(replacedNumber))
                        replacedNumber += "-";
                    replacedNumber += "cat";
                }

                if (number % 4 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedNumber))
                        replacedNumber += "-";
                    replacedNumber += "muzz";
                }

                if (number % 7 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedNumber))
                        replacedNumber += "-";
                    replacedNumber += "guzz";
                }

                if (string.IsNullOrEmpty(replacedNumber))
                    replacedNumber = number.ToString();

                replacedNumbers.Add(replacedNumber);
            }

            return replacedNumbers;
        }
    }
}
