using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Flyweight_Pattern
{
    public class ReportFactory
    {
        static Dictionary<string, IReport> reports = new Dictionary<string, IReport>();

        public static IReport GetReport(string key)
        {
            if (reports.Keys.Contains(key))
            {
                return reports[key];
            }

            IReport report = null;
            switch (key)
            {
                case "Daily":
                    report = new DailyReport();
                    reports.Add(key, report);
                    break;
                case "Weekly":
                    report = new WeeklyReport();
                    reports.Add(key, report);
                    break;
            }
            return report;
        }
    }
}
