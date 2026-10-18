using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prg282Prj
{
    // Created the summary feature as a partial class of Form1
    public partial class Form1
    {
        // Loaded the animals and calculated and displayed and saved the summary
        private void GenerateSummary()
        {
            List<Animal> animals;

            try
            {
                //This method will be replaced with the file loader method once it is complete. It is here to allow the summary report to be generated and tested while the file loader is still being developed.
                animals = LoadAnimalsForSummary();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("animals.txt could not be read because of a permission problem.",
                    "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt could not be read. It may be open in another program.",
                    "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SummaryResult result = SummaryService.Calculate(animals);

            DateTime now = DateTime.Now; // Used to get the current date and time for the report and the file name

            txtSummary.Text = SummaryService.BuildReport(result, now);

            if (!SummaryService.TryWriteReport(result, now, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //This is temporary and will be removed once the file loader method is complete. It is here to allow the summary report to be generated and tested while the file loader is still being developed.
        private List<Animal> LoadAnimalsForSummary()
        {
            List<Animal> animals = new List<Animal>();
            string path = "animals.txt";

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length == 7
                            && Regex.IsMatch(fields[0], @"^WR-\d{4}$")
                            && int.TryParse(fields[3], out int age)
                            && int.TryParse(fields[4], out int score))
                        {
                            Animal animal = new Animal
                            {
                                AnimalID = fields[0],
                                AnimalName = fields[1],
                                AnimalSpecies = fields[2],
                                AnimalAge = age,
                                RecoveryScore = score
                            };

                            animal.Classification();
                            animals.Add(animal);
                        }
                    }
                }
            }

            return animals;
        }
    }
}