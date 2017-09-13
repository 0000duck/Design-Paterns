using Main.Creational_Patterns.Builder_Patern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Main.Structural_Patterns.Proxy_Patern;
using Main.Structural_Patterns.Flyweight_Patern;

namespace UnitTests
{
    [TestClass]
    public class FlyweightPaternTest
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