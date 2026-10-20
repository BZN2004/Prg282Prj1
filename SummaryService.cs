using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Prg282Prj
{
    // Created class for storing the summary figures
    internal class SummaryResult
    {
        public int TotalAnimals { get; set; }

        public decimal AverageAge { get; set; }
        public decimal AverageRecoveryScore { get; set; }

        // Stored the number of animals for each status
        public Dictionary<string, int> StatusCounts { get; } = new Dictionary<string, int>();
    }

    // Created class for calculating the summary and writing summary.txt
    internal static class SummaryService
    {
        public static readonly string[] StatusNames =
            { "Critical", "Serious", "Stable", "Recovering", "Release-Ready" };

        // Calculated the total and the averages and the count for each status
        public static SummaryResult Calculate(IEnumerable<Animal> animals)
        {
            SummaryResult result = new SummaryResult();

            // Set every status to 0 so empty statuses still show
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
                // Cast to decimal to keep the decimals
                result.AverageAge = (decimal)ageTotal / result.TotalAnimals;
                result.AverageRecoveryScore = (decimal)scoreTotal / result.TotalAnimals;
            }

            return result;
        }

        // Formatted the average with two decimals or N/A when empty
        public static string FormatAverage(decimal average, int totalAnimals)
        {
            if (totalAnimals == 0)
            {
                return "N/A";
            }

            // Used F2 for two decimals and InvariantCulture for a full stop
            return average.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static string BuildReport(SummaryResult result, DateTime generatedAt)
        {
            return "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE\r\n"
                + "ANIMAL SUMMARY REPORT\r\n"
                + "Generated: " + generatedAt.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) + "\r\n"
                + "----------------------------------------\r\n"
                + "Total animals:            " + result.TotalAnimals + "\r\n"
                + "Average age (years):      " + FormatAverage(result.AverageAge, result.TotalAnimals) + "\r\n"
                + "Average recovery score:   " + FormatAverage(result.AverageRecoveryScore, result.TotalAnimals) + "\r\n"
                + "----------------------------------------\r\n"
                + "Animals per status:\r\n"
                + "  Critical:               " + result.StatusCounts["Critical"] + "\r\n"
                + "  Serious:                " + result.StatusCounts["Serious"] + "\r\n"
                + "  Stable:                 " + result.StatusCounts["Stable"] + "\r\n"
                + "  Recovering:             " + result.StatusCounts["Recovering"] + "\r\n"
                + "  Release-Ready:          " + result.StatusCounts["Release-Ready"] + "\r\n";
        }

        // Saved the report to summary.txt and returned false with a message if saving failed
        public static bool TryWriteReport(SummaryResult result, DateTime generatedAt, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                // Replaced the old file each time and closed it with using
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
                // Placed before IOException because it is a type of IOException
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