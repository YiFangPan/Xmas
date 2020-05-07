using System;

namespace Xmas
{
    public interface IHoliday
    {
        string GetXmasValue();
    }

    public class Holiday1224 : Holiday
    {
        public Holiday1224(IDateTimeWrapper wrapper) : base(wrapper)
        {
        }

        protected override bool IsXmasDay(DateTime today)
        {
            return today.Month == 12 && today.Day == 24;
        }
    }
    
    public class Holiday : IHoliday
    {
        private readonly IDateTimeWrapper _wrapper;
        
        public Holiday(IDateTimeWrapper wrapper)
        {
            _wrapper = wrapper;
        }
        
        public string GetXmasValue()
        {
            var today = _wrapper.GetNow();
            return IsXmasDay(today) ? "Xmas" : "Today is not Xmas";
        }

        protected virtual bool IsXmasDay(DateTime today)
        {
            return today.Month == 12 && today.Day == 25;
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