using System;
using NUnit.Framework;

namespace Xmas.UnitTests
{
    public class HolidayTests
    {
        private FakeHoliday _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new FakeHoliday();
        }
        
        
        [Test]
        public void Today_Is_Not_Xmas()
        {
            GivenToday(2020, 5, 8);
            ShouldBeValid("Today is not Xmas");
        }


        [Test]
        public void Today_Is_Xmas()
        {
            GivenToday(2020, 12, 25);
            ShouldBeValid("Xmas");
        }
        
        [Test]
        public void Today_1224_Is_Xmas()
        {
            GivenToday(2020, 12, 24);
            ShouldBeValid("Xmas");
        }

        private void ShouldBeValid(string expected)
        {
            Assert.AreEqual(expected, _target.GetXmasValue());
        }

        private void GivenToday(int year, int month, int day)
        {
            _target.SetToday(new DateTime(year, month, day));
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