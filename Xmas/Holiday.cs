using System;

namespace Xmas
{
    public class Holiday
    {
        private IDateTimeWrapper _wrapper;
        
        public Holiday(IDateTimeWrapper wrapper)
        {
            _wrapper = wrapper;
        }
        
        public string GetXmasValue()
        {
            
            DateTime today = _wrapper.GetNow();
            if (today.Month == 12 && today.Day == 25)
                return "Xmas";
            return "Today is not Xmas";
        }
        
        
        
    }

    public interface IDateTimeWrapper
    {
        DateTime GetNow();
    }
    
    public class DateTimeWrapper : IDateTimeWrapper
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}