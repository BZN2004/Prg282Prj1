namespace Prg282Prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                    private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine ID to delete: prefer ID textbox, fallback to selected row in grid
                string animalID = IDtxt.Text.Trim().ToUpper();
                if (string.IsNullOrEmpty(animalID) && dgvAnimals.SelectedRows.Count > 0)
                {
                    var cell = dgvAnimals.SelectedRows[0].Cells[0].Value;
                    if (cell != null)
                        animalID = cell.ToString().Trim().ToUpper();
                }

                if (string.IsNullOrEmpty(animalID))
                {
                    MessageBox.Show("Please enter or select an Animal ID to delete.");
                    IDtxt.Focus();
                    return;
                }

                // Basic ID format validation (WR-####)
                if (!animalID.StartsWith("WR-") || animalID.Length != 7 || !int.TryParse(animalID.Substring(3), out _))
                {
                    MessageBox.Show("Animal ID must be WR- followed by exactly 4 digits (e.g., WR-0007).");
                    IDtxt.Focus();
                    return;
                }

                // Confirm deletion with the user
                var confirm = MessageBox.Show($"Are you sure you want to delete record {animalID}? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                string[] allLines = ReadAnimalFileLines();
                if (allLines == null)
                    return;
                var remaining = new System.Collections.Generic.List<string>();
                bool removed = false;

                foreach (string line in allLines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split('|');
                    if (parts.Length == 0)
                        continue;

                    string idInFile = parts[0].Trim().ToUpper();
                    if (idInFile == animalID)
                    {
                        removed = true;
                        continue; // skip adding this line
                    }

                    remaining.Add(line);
                }

                if (!removed)
                {
                    MessageBox.Show("No record found with that Animal ID.");
                    return;
                }

                if (!TryWriteAnimalFileLines(remaining))
                    return;

                MessageBox.Show($"Deleted record {animalID}.");

                // Clear inputs and refresh grid
                IDtxt.Clear();
                Nametxt.Clear();
                Speciestxt.Clear();
                Agetxt.Clear();
                Scoretxt.Clear();

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                // 1. Get raw text inputs and format ID
                string animalID = IDtxt.Text.Trim().ToUpper();
                string animalName = Nametxt.Text.Trim();
                string animalSpecies = Speciestxt.Text.Trim();
                string ageText = Agetxt.Text.Trim();
                string scoreText = Scoretxt.Text.Trim();

                // 2. Validate Age and Score (prevents crashes from letters or blank inputs)
                if (!int.TryParse(ageText, out int animalAge) || animalAge < 0 || animalAge > 100)
                {
                    MessageBox.Show("Age must be a whole number between 0 and 100.");
                    Agetxt.Focus();
                    return;
                }

                if (!int.TryParse(scoreText, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
                {
                    MessageBox.Show("Recovery Score must be a whole number between 0 and 100.");
                    Scoretxt.Focus();
                    return;
                }

                // 3. Validate ID format (Must be WR- followed by 4 digits)
                if (!animalID.StartsWith("WR-") || animalID.Length != 7 || !int.TryParse(animalID.Substring(3), out _))
                {
                    MessageBox.Show("Animal ID must be WR- followed by exactly 4 digits (e.g., WR-0007).");
                    IDtxt.Focus();
                    return;
                }

                // 4. Validate Name and Species
                if (string.IsNullOrEmpty(animalName) || animalName.Length > 30 || animalName.Contains("|"))
                {
                    MessageBox.Show("Name is required, must be 1-30 characters, and cannot contain the pipe (|) character.");
                    Nametxt.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(animalSpecies) || animalSpecies.Length > 30 || animalSpecies.Contains("|"))
                {
                    MessageBox.Show("Species is required, must be 1-30 characters, and cannot contain the pipe (|) character.");
                    Speciestxt.Focus();
                    return;
                }

                // 5. Validate Uniqueness against animals.txt
                string filePath = "animals.txt";
                if (System.IO.File.Exists(filePath))
                {
                    string[] existingRecords = System.IO.File.ReadAllLines(filePath);
                    foreach (string record in existingRecords)
                    {
                        if (record.StartsWith(animalID + " |") || record.StartsWith(animalID + "|"))
                        {
                            MessageBox.Show("This Animal ID already exists.");
                            IDtxt.Focus();
                            return;
                        }
                    }
                }

                // 6. Create Object and Calculate Status
                Animal newAnimal = new Animal();
                newAnimal.AnimalID = animalID;
                newAnimal.AnimalName = animalName;
                newAnimal.AnimalSpecies = animalSpecies;
                newAnimal.AnimalAge = animalAge;
                newAnimal.RecoveryScore = recoveryScore;

                newAnimal.Classification();

                // 7. Save to File
                System.IO.File.AppendAllText(filePath, newAnimal.ToFileFormat() + Environment.NewLine);
                MessageBox.Show($"Animal added successfully!\nStatus: {newAnimal.Status}\nHousing: {newAnimal.HousingUnit}");

                // 8. Clear inputs for the next entry
                IDtxt.Clear();
                Nametxt.Clear();
                Speciestxt.Clear();
                Agetxt.Clear();
                Scoretxt.Clear();
            }
            catch (Exception ex)
            {
                // Catches unexpected file errors (like permission issues) without crashing
                MessageBox.Show("Error saving to file: " + ex.Message);
            }


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            private void Form1_Load(object sender, EventArgs e)
{
    // Load any existing animals into the grid on startup
    RefreshGrid();
}

/// <summary>
/// Reads animals.txt and loads the records into the DataGridView.
/// </summary>
private void RefreshGrid()
{
    try
    {
        var list = new System.Collections.Generic.List<Animal>();
        string[] lines = ReadAnimalFileLines();
        if (lines == null)
            return; // read error already shown to user

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split('|');
            // skip malformed lines that do not contain at least ID,Name,Species,Age,Score
            if (parts.Length < 5)
                continue;

            var a = new Animal();
            a.AnimalID = parts[0].Trim();
            a.AnimalName = parts[1].Trim();
            a.AnimalSpecies = parts[2].Trim();
            if (int.TryParse(parts[3].Trim(), out int age))
                a.AnimalAge = age;
            if (int.TryParse(parts[4].Trim(), out int score))
                a.RecoveryScore = score;

            // Recompute classification to ensure Status/Housing are populated
            a.Classification();

            list.Add(a);
        }

        dgvAnimals.DataSource = null;
        dgvAnimals.DataSource = list;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading data: " + ex.Message);
    }
}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
