using System;

namespace Xmas
{
    public class Holiday
    {
        public string GetXmasValue()
        {
            DateTime today = DateTime.Today;
            if (today.Month == 12 && today.Day == 25)
                return "Xmas";
            return "Today is not Xmas";
        }
    }
}