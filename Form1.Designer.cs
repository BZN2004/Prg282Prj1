namespace Prg282Prj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        private void InitializeComponent()
        {
            lblAnimalID = new Label();
            Nametxt = new TextBox();
            IDtxt = new TextBox();
            lblAnimalName = new Label();
            lblSpecies = new Label();
            Agetxt = new TextBox();
            Speciestxt = new TextBox();
            Scoretxt = new TextBox();
            lblAge = new Label();
            lblRecoveryScore = new Label();
            btnAdd = new Button();
            dgvAnimals = new DataGridView();
            btnDelete = new Button();
            btnSummary = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            lblSearchID = new Label();
            txtSearchID = new TextBox();
            btnSave = new Button();
            grpSummary = new GroupBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(18, 19);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(75, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(414, 12);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(125, 27);
            Nametxt.TabIndex = 1;
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(99, 19);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(125, 27);
            IDtxt.TabIndex = 2;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(333, 12);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(49, 20);
            lblAnimalName.TabIndex = 3;
            lblAnimalName.Text = "Name";
            lblAnimalName.Click += label2_Click;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(18, 55);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(414, 55);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(125, 27);
            Agetxt.TabIndex = 5;
            // 
            // Speciestxt
            // 
            Speciestxt.Location = new Point(99, 55);
            Speciestxt.Name = "Speciestxt";
            Speciestxt.Size = new Size(125, 27);
            Speciestxt.TabIndex = 6;
            // 
            // Scoretxt
            // 
            Scoretxt.Location = new Point(689, 19);
            Scoretxt.Name = "Scoretxt";
            Scoretxt.Size = new Size(125, 27);
            Scoretxt.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(333, 58);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(84, 20);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age (Years)";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(573, 19);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 9;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 102);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 43);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(38, 151);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(832, 276);
            dgvAnimals.TabIndex = 11;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(143, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 43);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(0, 215);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(145, 31);
            btnSummary.TabIndex = 13;
            btnSummary.Text = "Summarize";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(393, 459);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 43);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 102);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 43);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // lblSearchID
            // 
            lblSearchID.AutoSize = true;
            lblSearchID.Location = new Point(45, 470);
            lblSearchID.Name = "lblSearchID";
            lblSearchID.Size = new Size(145, 20);
            lblSearchID.TabIndex = 15;
            lblSearchID.Text = "Search  by animal ID";
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(196, 470);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(186, 27);
            txtSearchID.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(498, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 43);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(btnSummary);
            grpSummary.Location = new Point(45, 550);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(769, 252);
            grpSummary.TabIndex = 18;
            grpSummary.TabStop = false;
            grpSummary.Text = "SummaryBox";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(598, 459);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 43);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 886);
            Controls.Add(btnUpdate);
            Controls.Add(grpSummary);
            Controls.Add(btnSave);
            Controls.Add(txtSearchID);
            Controls.Add(lblSearchID);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(dgvAnimals);
            Controls.Add(btnAdd);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblAge);
            Controls.Add(Scoretxt);
            Controls.Add(Speciestxt);
            Controls.Add(Agetxt);
            Controls.Add(lblSpecies);
            Controls.Add(lblAnimalName);
            Controls.Add(IDtxt);
            Controls.Add(Nametxt);
            Controls.Add(lblAnimalID);
            Name = "Form1";
            Text = "Baobab Ridge Wildlife Rehabilitation Records";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpSummary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        private Label lblAnimalID;
        private TextBox Nametxt;
        private TextBox IDtxt;
        private Label lblAnimalName;
        private Label lblSpecies;
        private TextBox Agetxt;
        private TextBox Speciestxt;
        private TextBox Scoretxt;
        private Label lblAge;
        private Label lblRecoveryScore;
        private Button btnAdd;
        private DataGridView dgvAnimals;
        private Button btnDelete;
        private Button btnSummary;
        private Button btnSearch;
        private Button btnClear;
        private Label lblSearchID;
        private TextBox txtSearchID;
        private Button btnSave;
        private GroupBox grpSummary;
        private Button btnUpdate;
    }
}
