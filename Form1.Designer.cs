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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            btnClear = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(38, 36);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(75, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(434, 29);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(125, 27);
            Nametxt.TabIndex = 1;
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(119, 36);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(125, 27);
            IDtxt.TabIndex = 2;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(353, 29);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(49, 20);
            lblAnimalName.TabIndex = 3;
            lblAnimalName.Text = "Name";
            lblAnimalName.Click += label2_Click;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(38, 72);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(434, 72);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(125, 27);
            Agetxt.TabIndex = 5;
            // 
            // Speciestxt
            // 
            Speciestxt.Location = new Point(119, 72);
            Speciestxt.Name = "Speciestxt";
            Speciestxt.Size = new Size(125, 27);
            Speciestxt.TabIndex = 6;
            // 
            // Scoretxt
            // 
            Scoretxt.Location = new Point(709, 36);
            Scoretxt.Name = "Scoretxt";
            Scoretxt.Size = new Size(125, 27);
            Scoretxt.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(353, 75);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(84, 20);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age (Years)";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(593, 36);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 9;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(203, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 43);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(12, 229);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(900, 280);
            dgvAnimals.TabIndex = 11;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(455, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 43);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(325, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 43);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(575, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 43);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
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
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btnClear;
        private Button btnSearch;
    }
}
