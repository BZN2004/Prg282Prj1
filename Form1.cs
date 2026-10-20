using System.Data;

namespace Prg282Prj
{
    public partial class Form1 : Form
    {
        //DataTable holding all data fro the datagridview
        DataTable dataHolder = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void DataRefresh()
        {
            dataHolder.Rows.Clear();
            string filePath = Path.Combine(Application.StartupPath, @"..\..\..\animals.txt");
            //checking if the file exists
            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line;
                //Getting each line in the text file
                while ((line = sr.ReadLine()) != null)
                {
                    //Creating a array that holds each seperate value of the animal
                    string[] lines = line.Split('|');
                    //Adding each value into the correct column with the correct type
                    dataHolder.Rows.Add(lines[0], lines[1], lines[2], int.Parse(lines[3]), int.Parse(lines[4]), lines[5], lines[6]);
                }
                sr.Close();
                fs.Close();
                //Setting it to show in the datagridview
                dgvAnimals.DataSource = dataHolder;
            }
        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Getting the index of the cell clicked
            int index = dgvAnimals.CurrentCell.RowIndex;
            // Creating a object to hold all the data of the selected row
            DataGridViewRow row = dgvAnimals.Rows[index];

            //Assigning all the data to the correct textboxes
            IDtxt.Text = row.Cells[0].Value.ToString();
            Nametxt.Text = row.Cells[1].Value.ToString();
            Speciestxt.Text = row.Cells[2].Value.ToString();
            Agetxt.Text = row.Cells[3].Value.ToString();
            Scoretxt.Text = row.Cells[4].Value.ToString();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                string filePath = Path.Combine(Application.StartupPath, @"..\..\..\animals.txt");
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

            //DataGridView Add Response
            DataRefresh();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchID.Text.Trim();
            bool found = false;

            if (!search.StartsWith("WR-") || string.IsNullOrEmpty(search)|| search.Length != 7)
            {
                MessageBox.Show("Invalid ID", "Please enter a valid ID (WR-0001)", MessageBoxButtons.OK);
                txtSearchID.Focus();
                return;
            } 

            dgvAnimals.ClearSelection();

            foreach (DataGridViewRow r in dgvAnimals.Rows)
            {
                if (r.IsNewRow)
                {
                    continue;
                }

                if (r.Cells[0].Value.ToString().Trim().ToUpper() == search)
                {
                    dgvAnimals.ClearSelection();
                    r.Selected = true;
                    dgvAnimals.CurrentCell = r.Cells[0];
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("ID Not Found");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing text from textboxes
            IDtxt.Clear();
            Nametxt.Clear();
            Speciestxt.Clear();
            Agetxt.Clear();
            Scoretxt.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loading the correct columns for the datatable
            dataHolder.Columns.Add("ID", typeof(string));
            dataHolder.Columns.Add("Name", typeof(string));
            dataHolder.Columns.Add("Species", typeof(string));
            dataHolder.Columns.Add("Age", typeof(int));
            dataHolder.Columns.Add("Recovery Score", typeof(int));
            dataHolder.Columns.Add("Recovery Condition", typeof(string));
            dataHolder.Columns.Add("Housing Unit", typeof(string));

            //Ensures that it uses the animal.txt in the application files, and not create a new one in the debug bin
            string filePath = Path.Combine(Application.StartupPath, @"..\..\..\animals.txt");

            //DataGridview Showing on opening of application
            DataRefresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, @"..\..\..\animals.txt");

            // Getting the index of the cell clicked
            int index = dgvAnimals.CurrentCell.RowIndex;
            // Creating a object to hold all the data of the selected row
            DataRow row = dataHolder.Rows[index];

            // Using the same validation as Adding to ensure formatting stays the same
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
            //Updating the DataTable
            row[0] = animalID;
            row[1] = animalName;
            row[2] = animalSpecies;
            row[3] = animalAge;
            row[4] = recoveryScore;
            //Updating the data grid view
            dgvAnimals.CurrentRow.Cells[0].Value = animalID;
            dgvAnimals.CurrentRow.Cells[1].Value = animalName;
            dgvAnimals.CurrentRow.Cells[2].Value = animalSpecies;
            dgvAnimals.CurrentRow.Cells[3].Value = animalAge;
            dgvAnimals.CurrentRow.Cells[4].Value = recoveryScore;

            //Saving the data by rewriting the whole text document
            List<string> lines = new List<string>();
            foreach (DataRow dr in dataHolder.Rows)
            {
                Animal animal = new Animal();
                animal.AnimalID = dr[0].ToString();
                animal.AnimalName = dr[1].ToString();
                animal.AnimalSpecies = dr[2].ToString();
                animal.AnimalAge = int.Parse(dr[3].ToString());
                animal.RecoveryScore = int.Parse(dr[4].ToString());

                animal.Classification();
                lines.Add(animal.ToFileFormat());
            }

            File.WriteAllLines(filePath, lines);

        }
    }
}
