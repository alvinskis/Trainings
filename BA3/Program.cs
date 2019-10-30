using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BA3
{
    class Program
    {
        static void Main(string[] args)
        {
            var kindergarten = ProcessFile("Darzeliu galimu priimti ir lankantys vaikai2018.csv");

            var itemWithMinChildCount = kindergarten.OrderBy(c => c.ChildCount).First();
            var itemWithMaxChildCount = kindergarten.OrderBy(c => c.ChildCount).Last();

            Console.WriteLine($"Max ChildCount {itemWithMaxChildCount.ChildCount}");
            Console.WriteLine($"Min ChildCount {itemWithMinChildCount.ChildCount}");

            string nameWhenChildCountValueIsMax = FormName(itemWithMaxChildCount);
            string nameWhenChildCountValueIsMin = FormName(itemWithMinChildCount);

            var groupsByLanguage = kindergarten.GroupBy(l => l.LanId);

            var groupWithMaxFreeSpace = groupsByLanguage.OrderByDescending(group => group.Sum(f =>
                                        f.FreeSpace) * 100 / group.Sum(c => c.ChildCount + c.FreeSpace))
                                        .First();

            var kindergartenWithMostFreeSpacePercentage = (double)groupWithMaxFreeSpace.Sum(f => f.FreeSpace)
                                                          * 100 / (double)groupWithMaxFreeSpace
                                                          .Sum(c => c.ChildCount + c.FreeSpace);

            kindergartenWithMostFreeSpacePercentage = Math.Round(kindergartenWithMostFreeSpacePercentage, 2);

            var groupedByName = kindergarten.GroupBy(s => s.SchoolName)
                                .Where(k => k.Sum(f => f.FreeSpace) > 1 && k.Sum(f => f.FreeSpace) < 5)
                                .OrderByDescending(k => k.Key)
                                .ToList();

            var groupedByNameArray = groupedByName.Select(k => Convert.ToString(k.Key))
                                             .ToArray();

            string[] firstArrayToTextFile = { $"Min ChildCount: {itemWithMinChildCount.ChildCount} \nMax ChildCount: {itemWithMaxChildCount.ChildCount}" };
            string[] secondArrayToTextFile =
            {
                $"Name when max ChildCount: {nameWhenChildCountValueIsMax} \nName when min ChildCount: {nameWhenChildCountValueIsMin}"
            };
            string[] thirdArrayToTextFile = { $"Percent of kindergarten with most free space: {kindergartenWithMostFreeSpacePercentage}" };

            File.WriteAllLines(@"C:\Users\xmodi\Desktop\BA3\BA3\BA3\BA3_1.txt", firstArrayToTextFile);
            File.WriteAllLines(@"C:\Users\xmodi\Desktop\BA3\BA3\BA3\BA3_2.txt", secondArrayToTextFile);
            File.WriteAllLines(@"C:\Users\xmodi\Desktop\BA3\BA3\BA3\BA3_3.txt", thirdArrayToTextFile);
            File.WriteAllLines(@"C:\Users\xmodi\Desktop\BA3\BA3\BA3\BA3_4.txt", groupedByNameArray);

            Console.ReadKey();
        }

        private static List<Kindergarten> ProcessFile(string path)
        {
            return File.ReadAllLines(path)
                   .Skip(1)
                   .Where(line => line.Length > 1)
                   .Select(Kindergarten.ParseFromCsv)
                   .ToList();
        }

        private static string FormName(Kindergarten kindergarten)
        {
            var schoolName = kindergarten.SchoolName.Substring(0, 3);
            var typeLabel = GetTypeLabel(kindergarten.TypeLabel);
            var lanLabel = kindergarten.LanLabel.Substring(0, 4);
            var result = $"{schoolName}_{typeLabel}_{lanLabel}";

            return result;
        }

        private static string GetTypeLabel(string data)
        {
            var numbers = new List<string>();
            var matchedValues = Regex.Matches(data, @"\d*\,?\d*");

            foreach (var item in matchedValues)
            {
                if (!string.IsNullOrEmpty(item.ToString()))
                {
                    numbers.Add(item.ToString());
                }
            }

            return string.Join("-", numbers);
        }
    }
}
