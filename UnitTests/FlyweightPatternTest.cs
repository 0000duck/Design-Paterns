﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main.Structural_Patterns.Flyweight_Pattern;

namespace UnitTests
{
    [TestClass]
    public class FlyweightPatternTest
    {
        [TestMethod]
        public void TestDailyReportShouldBeCreated()
        {
            var flyWeightFactory = new ReportFactory();

            var report = ReportFactory.GetReport("Daily");

            Assert.IsTrue(report.GetType() == typeof(DailyReport));
        }

        [TestMethod]
        public void TestWeeklyReportShouldBeCreated()
        {
            var flyWeightFactory = new ReportFactory();

            var report = ReportFactory.GetReport("Weekly");

            Assert.IsTrue(report.GetType() == typeof(WeeklyReport));
        }

        [TestMethod]
        public void TestWeeklyReportShouldBeCreatedOnce()
        {
            var flyWeightFactory = new ReportFactory();

            var report1 = ReportFactory.GetReport("Weekly");
            var report2 = ReportFactory.GetReport("Weekly");
            Assert.IsTrue(System.Object.ReferenceEquals(report1, report2));
        }

        [TestMethod]
        public void TestWeeklyReportShouldBeCreatedTwice()
        {
            var report1 = new WeeklyReport();
            var report2 = new WeeklyReport();
            Assert.IsFalse(System.Object.ReferenceEquals(report1, report2));
        }
    }
}