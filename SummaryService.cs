using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Prg282Prj
{
    internal class SummaryResult
    {
        public int TotalAnimals { get; set; }

        public decimal AverageAge { get; set; }
        public decimal AverageRecoveryScore { get; set; }

        public Dictionary<string, int> StatusCounts { get; set; } = new Dictionary<string, int>();
    }

    internal static class SummaryService
    {
       
        public static readonly string[] StatusNames = {"Critical", "Serious", "Stable", "Recovering", "Release-Ready"};

        public static SummaryResult Calculate(IEnumerable<Animal> animals)
        {
            SummaryResult result = new SummaryResult();

            foreach (string status in StatusNames)
            {
                result.StatusCounts[status] = 0;
            }

            long ageTotal = 0;
            long scoreTotal = 0;

            foreach (Animal animal in animals)
            {
                animal.Classification();
                result.TotalAnimals++;
                ageTotal += animal.AnimalAge;
                scoreTotal += animal.RecoveryScore;
                result.StatusCounts[animal.Status]++;
            }

            if (result.TotalAnimals > 0)
            {
                result.AverageAge = (decimal)ageTotal / result.TotalAnimals;
                result.AverageRecoveryScore = (decimal)scoreTotal / result.TotalAnimals;
            }

            return result;
        }

        public static string FormatAverage(decimal average, int totalAnimals)
        {
            if (totalAnimals == 0)
            {
                return "N/A";
            }

            return average.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static string BuildReport(SummaryResult result, DateTime generatedAt)
        {
            return "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE\n"
                + "ANIMAL SUMMARY REPORT\n"
                + "Generated: " + generatedAt.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) + "\n"
                + "----------------------------------------\n"
                + "Total animals:            " + result.TotalAnimals + "\n"
                + "Average age (years):      " + FormatAverage(result.AverageAge, result.TotalAnimals) + "\n"
                + "Average recovery score:   " + FormatAverage(result.AverageRecoveryScore, result.TotalAnimals) + "\n"
                + "----------------------------------------\n"
                + "Animals per status:\n"
                + "  Critical:               " + result.StatusCounts["Critical"] + "\n"
                + "  Serious:                " + result.StatusCounts["Serious"] + "\n"
                + "  Stable:                 " + result.StatusCounts["Stable"] + "\n"
                + "  Recovering:             " + result.StatusCounts["Recovering"] + "\n"
                + "  Release-Ready:          " + result.StatusCounts["Release-Ready"] + "\n";
        }

        public static bool TryWriteReport(SummaryResult result, DateTime generatedAt, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (StreamWriter writer = new StreamWriter("summary.txt"))
                {
                    writer.Write(BuildReport(result, generatedAt));
                }

                return true;
            }
            catch (UnauthorizedAccessException)
            {
                errorMessage = "summary.txt could not be saved because the program does not have permission " +
                               "(the file may be read-only).";
            }
            catch (DirectoryNotFoundException)
            {
                errorMessage = "summary.txt could not be saved because the program folder was not found.";
            }
            catch (IOException)
            {
                errorMessage = "summary.txt could not be saved because it is open in another program. " +
                               "Close it and try again.";
            }

            return false;
        }
    }
}