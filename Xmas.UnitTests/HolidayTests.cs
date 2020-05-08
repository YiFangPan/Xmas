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
        public void Today_Is_Not_Xmas()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2020, 5, 8));
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Today is not Xmas", result);
        }


        [Test]
        public void Today_Is_Xmas()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2020, 12,25));
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Xmas", result);
        }
        
        [Test]
        public void Today_1224_Is_Xmas()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2020, 12,24));
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Xmas", result);
        }
    }
    
    public class FakeHoliday : Holiday
    {
        private DateTime _today;

        public void SetToday(DateTime dateTime)
        {
            _today = dateTime;
        }
        
        protected override DateTime GetToday()
        {
            return _today;
        }
    }
}