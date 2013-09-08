﻿using NUnit.Framework;

namespace NodaTime.Humanization.Test.SingleUnit
{
    [TestFixture]
    public class WeekTests
    {
        [Test]
        public void Can_Get_Relative_Time_For_One_Week()
        {
            var start = new LocalDateTime(2013, 1, 1, 0, 0);
            var end = new LocalDateTime(2013, 1, 8, 0, 0);

            var result = Humanizer.GetRelativeTime(start, end, countWeeks: true);

            Assert.AreEqual("a week", result);
        }

        [Test]
        public void Can_Get_Relative_Time_For_OneAndAHalf_Weeks()
        {
            var start = new LocalDateTime(2013, 1, 1, 0, 0);
            var end = new LocalDateTime(2013, 1, 11, 12, 0);

            var result = Humanizer.GetRelativeTime(start, end, countWeeks: true);

            Assert.AreEqual("1.5 weeks", result);
        }

        [Test]
        public void Can_Get_Relative_Time_For_Two_Weeks()
        {
            var start = new LocalDateTime(2013, 1, 1, 0, 0);
            var end = new LocalDateTime(2013, 1, 15, 0, 0);

            var result = Humanizer.GetRelativeTime(start, end, countWeeks: true);

            Assert.AreEqual("2 weeks", result);
        }
    }
}
