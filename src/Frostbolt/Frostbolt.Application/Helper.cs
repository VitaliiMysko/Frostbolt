using System;

namespace ConsoleRestaurant.Application
{
    public static class Helper
    {
        public static string[] ParseActionLine(string actionLine, string separator = " ")
        {
            var actionArr = actionLine.Split(separator);

            actionArr[0] = FirstCharToUpper(actionArr[0].ToLower());

            for (int i = 0; i < actionArr.Length; i++)
            {
                actionArr[i] = actionArr[i].Trim();
            }

            return actionArr;
        }

        public static string FirstCharToUpper(string input)
        {
            return input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };
        }

    }
}
