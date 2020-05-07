using System;
using NUnit.Framework;

namespace Xmas.UnitTests
{
    public class HolidayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Today_Is_Not_Xmas_Value()
        {
            IDateTimeWrapper wrapper = new FakeDateTimeWrapper();
            
            var holiday = new Holiday(wrapper);
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Today is not Xmas", result);
        }

        private class FakeDateTimeWrapper : IDateTimeWrapper
        {
            public DateTime GetNow()
            {
                return new DateTime(2020, 12, 1);
            }
        }

        
        [Test]
        public void Get_Today_Is_Xmas_Value()
        {
            IDateTimeWrapper wrapper = new FakeXmasDateTimeWrapper();
            var holiday = new Holiday(wrapper);
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Xmas", result);
        }
        
        private class FakeXmasDateTimeWrapper : IDateTimeWrapper
        {
            public DateTime GetNow()
            {
                return new DateTime(2020, 12, 25);
            }
        }
    }
}