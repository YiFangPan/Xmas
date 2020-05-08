using System;

namespace Xmas
{
    public class Holiday
    {
        public string GetXmasValue()
        {
            var today = GetToday();
            if (today.Month == 12 && today.Day == 25 || today.Day == 24)
            {
                return "Xmas";
            }

            return "Today is not Xmas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Now;
        }
    }
}