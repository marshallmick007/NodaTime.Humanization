﻿using NUnit.Framework;

namespace NodaTime.Humanization.Test.TwoUnit
{
    [TestFixture]
    [SetCulture("en-US")]
    [SetUICulture("en")]
    public class YearMonthTests
    {
        [Test]
        public void Can_Get_Relative_Time_For_One_Year_And_One_Month()
        {
            var start = new LocalDateTime(2013, 1, 1, 0, 0);
            var end = new LocalDateTime(2014, 2, 1, 0, 0);

            var result = new Humanizer(2).GetRelativeTime(start, end);

            Assert.AreEqual("a year and a month", result);
        }
    }
}
