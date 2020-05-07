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
            Holiday holiday = new Holiday();
            var result = holiday.GetXmasValue();
            Assert.AreEqual("Today is not Xmas", result);
        }
        
        
    }
}